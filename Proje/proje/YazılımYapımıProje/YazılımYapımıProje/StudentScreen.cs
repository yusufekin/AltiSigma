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

namespace YazılımYapımıProje
{
    public partial class StudentScreen : Form
    {
        public StudentScreen(string username, int userID)
        {
            InitializeComponent();
            lblUserName.Text = username;
            lblUserID.Text = userID.ToString();
        }

        List<int> randQuestions = new List<int>();
        Dictionary<int, int> DayToAccuraryLevel = new Dictionary<int, int>();
        private Form activeForm = null;
        ExamModul examModul;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelExamModul.Controls.Add(childForm);
            panelExamModul.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void AddQuestionToSolve()
        {
            DateTime today = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            DateTime solutionDate;
            Random random = new Random();

            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
            con.Open();

            int questionCount = Convert.ToInt32(new SqlCommand("Select count(*) From QuestionInformations", con).ExecuteScalar());

            SqlCommand sqlCommand = new SqlCommand("Select * From Questions where UserID= " + lblUserID.Text, con);
            SqlDataReader reader = sqlCommand.ExecuteReader();

            while (reader.Read())
            {
                solutionDate = Convert.ToDateTime(
                               Convert.ToDateTime(reader["DateTime"]).ToShortDateString());
                int accuraryLevel = Convert.ToInt32(reader["AccuraryLevel"]);

                if (accuraryLevel == 1)
                {
                    randQuestions.Add(Convert.ToInt32(reader["QuestionID"]));
                }
                else if (accuraryLevel == 0)
                    continue;
                else
                {
                    foreach (var step in DayToAccuraryLevel)
                    {
                        if (accuraryLevel == step.Value)
                        {
                            if ((today - solutionDate).Days > step.Key)
                            {
                                SqlConnection connection = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                                connection.Open();
                                SqlCommand cmd = new SqlCommand("Update Questions Set AccuraryLevel = '" + 0 + "', " +
                                                                "DateTime = '" + DateTime.Now.ToString("yyyy-MM-dd") + "'" +
                                                                "Where QuestionID = '" + Convert.ToInt32(reader["QuestionID"]) + "'", connection);
                                cmd.ExecuteNonQuery();
                                connection.Close();

                            }
                            else if ((today - solutionDate).Days == step.Key)
                            {
                                randQuestions.Add(Convert.ToInt32(reader["QuestionID"]));
                            }
                            else
                                continue;
                        }
                    }
                }
            }

            int i = 0;
            while (true)
            {
                int randQuestion = random.Next(1, (questionCount + 1));
                SqlConnection conn = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From QuestionInformations where QuestionID= " + randQuestion, conn);
                SqlDataReader read = cmd.ExecuteReader();

                if (read.Read() && Convert.ToInt32(read["isAccepted"]) == 0)
                    continue;
                else if (randQuestions.Contains(randQuestion))
                    continue;
                else
                {
                    SqlConnection sqlConnection = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                    sqlConnection.Open();

                    SqlDataReader dataReader = new SqlCommand("Select * From Questions Where " +
                                                              "QuestionID = '" + randQuestion + "'" +
                                                              "And UserName = '" + lblUserName.Text + "'", sqlConnection).ExecuteReader();
                    if (!dataReader.Read())
                    {
                        randQuestions.Add(randQuestion);
                        i++;
                    }
                    else
                    {
                        if (Convert.ToInt32(dataReader["AccuraryLevel"]) == 0)
                        {
                            randQuestions.Add(randQuestion);
                            i++;
                        }
                    }
                }
                if (i == 10)
                {
                    conn.Close();
                    break;
                }
            }
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            AddQuestionToSolve();
            btnStartExam.Enabled = false;
            examModul.StartExam(randQuestions);
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            logExitDate(DateTime.Now.ToShortDateString());
            UserLogin userLogin = new UserLogin();
            userLogin.Show();
            this.Hide();
        }

        private void logExitDate(string dateTime)
        {
            SqlManager sqlManager = new SqlManager(new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True"));
            SqlCommand command = new SqlCommand("Update Users Set ExitDate = '" + dateTime + "' " +
                                            "Where UserID = '" + Convert.ToInt32(lblUserID.Text) + "'");
            sqlManager.Update(command.CommandText);
        }

        private void DailyUse(bool dailyUse)
        {
            SqlManager sqlManager = new SqlManager(new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True"));
            SqlCommand command = new SqlCommand("Update Users Set DailyUse = '" + dailyUse + "' " +
                                            "Where UserID = '" + Convert.ToInt32(lblUserID.Text) + "'");
            sqlManager.Update(command.CommandText);
        }

        private void StudentScreen_Load(object sender, EventArgs e)
        {
            StepDayFill();
            examModul = new ExamModul(lblUserName.Text, Convert.ToInt32(lblUserID.Text));
            openChildForm(examModul);

            SqlManager sqlManager = new SqlManager(new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True"));
            SqlCommand command = new SqlCommand("Select * From Users where UserID= " + lblUserID.Text);
            Dictionary<string, string> userInfo = sqlManager.ReadDatabase(command.CommandText);

            if (userInfo != null)
            {
                if (userInfo["ExitDate"] != DateTime.Now.ToShortDateString())
                    DailyUse(false);

                if (userInfo["ExitDate"] == DateTime.Now.ToShortDateString() &&
                   Convert.ToBoolean(userInfo["DailyUse"]) == true)
                {
                    btnStartExam.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Farklı bir giriş tespit edildi!");
                btnStartExam.Enabled = false;
            }
        }

        private void StudentScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            logExitDate(DateTime.Now.ToShortDateString());
        }

        private void StepDayFill()
        {
            SqlManager sqlManager = new SqlManager(new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True"));
            SqlCommand command = new SqlCommand("Select * From Steps Where UserID = " + lblUserID.Text);
            Dictionary<string, string> info = sqlManager.ReadDatabase(command.CommandText);
            info.Remove("UserID");
            int accuraryLevel = 1;
            foreach (var item in info)
            {
                DayToAccuraryLevel.Add(Convert.ToInt32(item.Value), ++accuraryLevel);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(Convert.ToInt32(lblUserID.Text), lblUserName.Text);
            settingsForm.Show();
            this.Hide();
        }
    }
}

