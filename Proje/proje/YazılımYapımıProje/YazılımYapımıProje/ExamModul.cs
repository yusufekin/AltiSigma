using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
//Bura bak
namespace YazılımYapımıProje
{
    public partial class ExamModul : Form
    {

        public ExamModul(string username, int userid)
        {
            InitializeComponent();
            userName = username;
            userID = userid;
        }

        int minute = 10, second = 60;
        int questionIDCounter = 0;
        List<int> randQuestions = new List<int>();
        string userName = ""; int userID;

        public void StartExam(List<int> randquestions)
        {
            randQuestions = randquestions;
            lblQuestionInfo.Text = questionIDCounter + " / " + randQuestions.Count;
            imgExamQuestions.Image = null;
            panelOptions.Visible = true;
            imgExamQuestions.SizeMode = PictureBoxSizeMode.StretchImage;
            QuestionShow(questionIDCounter);
            ExamTimer.Start();
        }

        private void QuestionShow(int counter)
        {
            System.Threading.Thread.Sleep(100);
            SqlConnection connection = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("select * from QuestionInformations where QuestionID=" + randQuestions[counter], connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                byte[] img = (byte[])reader["QuestionImage"];
                MemoryStream ms = new MemoryStream(img);
                imgExamQuestions.Image = Image.FromStream(ms);
            }
            connection.Close();
        }

        private void TrueFalseControl(string answer, string rightAnswer)
        {
            if (answer == rightAnswer)
            {
                picBearTrue.BringToFront();
                picBearDefault.SendToBack();
                picBearFalse.SendToBack();
            }
            else
            {
                picBearFalse.BringToFront();
                picBearDefault.SendToBack();
                picBearTrue.SendToBack();
            }
        }

        private bool QuestionControl()
        {
            string answer = "", rightAnswer = "";
            List<RadioButton> Options = new List<RadioButton> { rdBtnA, rdBtnB, rdBtnC, rdBtnD };

            foreach (RadioButton rdBtn in Options)
            {
                if (rdBtn.Checked == true)
                    answer = rdBtn.Text.ToString();
            }

            if (answer == "")
            {
                MessageBox.Show("Lütfen bir seçenek seçiniz!");
                return false;
            }
            else
            {
                SqlConnection connection = new SqlConnection(@"Data Source =.\; Initial Catalog = dbStudentExamSystem; Integrated Security = True");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from QuestionInformations where QuestionID=" + randQuestions[questionIDCounter], connection);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    rightAnswer = reader["RightAnswer"].ToString();
                    TrueFalseControl(answer, rightAnswer);
                }

                connection.Close();
                connection.Open();

                SqlCommand cmd2 = new SqlCommand("Select * From Questions Where " +
                                                "QuestionID = '" + randQuestions[questionIDCounter] + "'" +
                                                "And UserName = '" + userName + "'", connection);
                SqlDataReader dr = cmd2.ExecuteReader();

                if (dr.Read())
                {
                    if (rightAnswer == answer)
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                        con.Open();
                        new SqlCommand("Update Questions Set AccuraryLevel = '" + (Convert.ToInt32(dr["AccuraryLevel"]) + 1) + "', " +
                                       "DateTime = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                                       "Where QuestionID = '" + randQuestions[questionIDCounter] + "'", con).ExecuteNonQuery();
                    }
                    else
                    {
                        SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                        con.Open();
                        new SqlCommand("Update Questions Set AccuraryLevel = '" + 0 + "', " +
                                       "DateTime = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                                       "Where QuestionID = '" + randQuestions[questionIDCounter] + "'", con).ExecuteNonQuery();
                    }
                }
                else
                {
                    SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                    con.Open();
                    SqlCommand command = new SqlCommand("Insert Into Questions " +
                                                        "(QuestionID, DateTime, AccuraryLevel, UserID, UserName)" +
                                                        "values " +
                                                        "(@QuestionID, @DateTime, @AccuraryLevel, @UserID, @UserName)", con);

                    command.Parameters.AddWithValue("QuestionID", randQuestions[questionIDCounter]);
                    command.Parameters.AddWithValue("DateTime", Convert.ToDateTime(DateTime.Now.ToShortDateString()));
                    command.Parameters.AddWithValue("UserID", userID);
                    command.Parameters.AddWithValue("UserName", userName);

                    if (rightAnswer == answer)
                        command.Parameters.AddWithValue("AccuraryLevel", 1);
                    else
                        command.Parameters.AddWithValue("AccuraryLevel", 0);
                    command.ExecuteNonQuery();
                    con.Close();
                }

                rdBtnA.Checked = false;
                rdBtnB.Checked = false;
                rdBtnC.Checked = false;
                rdBtnD.Checked = false;
                questionIDCounter++;

                return true;
            }
        }

        private void btnNextQuestion_MouseMove(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Hand;
            btnNextQuestion.SendToBack();
        }

        private void btnNextQuestion_MouseLeave(object sender, EventArgs e)
        {
            btnNextQuestion.BringToFront();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (QuestionControl())
            {
                lblQuestionInfo.Text = questionIDCounter + " / " + randQuestions.Count;
                if (randQuestions.Count == questionIDCounter)
                {
                    MessageBox.Show("Sınav bitti");
                    DailyUse(true);
                    this.Close();
                }
                else
                {
                    QuestionShow(questionIDCounter);
                }
            }
        }

        private void DailyUse(bool dailyUse)
        {
            SqlManager sqlManager = new SqlManager(new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True"));
            SqlCommand command = new SqlCommand("Update Users Set DailyUse = '" + dailyUse + "' " +
                                            "Where UserID = '" + userID + "'");
            sqlManager.Update(command.CommandText);
        }

        private void logExitDate(string dateTime)
        {
            SqlManager sqlManager = new SqlManager(new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True"));
            SqlCommand command = new SqlCommand("Update Users Set ExitDate = '" + dateTime + "' " +
                                            "Where UserID = '" + userID + "'");
            sqlManager.Update(command.CommandText);
        }

        private void ExamModul_FormClosed(object sender, FormClosedEventArgs e)
        {
            logExitDate(DateTime.Now.ToShortDateString());
        }

        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            ExamTimer.Interval = 1000;
            second -= 1;
            lblSecond.Text = second.ToString();
            lblMinute.Text = (minute - 1).ToString();

            if (second == 0)
            {
                minute -= 1;
                lblMinute.Text = minute.ToString();
                if (minute == 0) this.Close();
                second = 60;
            }
        }
    }
}
