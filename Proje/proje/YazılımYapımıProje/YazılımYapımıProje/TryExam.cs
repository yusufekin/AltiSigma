using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımıProje
{
    public partial class TryExam : Form
    {
        public TryExam(List<int> randquestions)
        {
            InitializeComponent();
            randQuestions = randquestions;
            StartExam();
        }

        List<int> randQuestions = new List<int>();
        int questionIDCounter = 0;

        private void QuestionShow(int counter)
        {
            rdBtnA.Checked = rdBtnB.Checked = rdBtnC.Checked = rdBtnD.Checked = false;
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
            string answer = "";
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
                    string rightAnswer = reader["RightAnswer"].ToString();
                    TrueFalseControl(answer, rightAnswer);
                }

                rdBtnA.Checked = false;
                rdBtnB.Checked = false;
                rdBtnC.Checked = false;
                rdBtnD.Checked = false;
                System.Threading.Thread.Sleep(100);
                questionIDCounter++;

                return true;
            }
        }

        public void StartExam()
        {
            lblQuestionInfo.Text = questionIDCounter + " / " + randQuestions.Count;
            imgExamQuestions.Image = null;
            panelOptions.Visible = true;
            imgExamQuestions.SizeMode = PictureBoxSizeMode.StretchImage;
            QuestionShow(questionIDCounter);
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            if (QuestionControl())
            {
                lblQuestionInfo.Text = questionIDCounter + " / " + randQuestions.Count;
                if (randQuestions.Count == questionIDCounter)
                {
                    MessageBox.Show("Sınav bitti");
                    UserLogin userLogin = new UserLogin();
                    userLogin.Show();
                    this.Hide();
                }
                else
                {
                    QuestionShow(questionIDCounter);
                }
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
    }
}
