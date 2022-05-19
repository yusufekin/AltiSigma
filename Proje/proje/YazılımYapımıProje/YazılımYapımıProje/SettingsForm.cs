using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımıProje
{
    public partial class SettingsForm : Form
    {
        int userID;
        string userName;
        public SettingsForm(int userid, string username)
        {
            InitializeComponent();
            userID = userid;
            userName = username;
        }

        private void txtStep1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (control(e))
                e.Handled = true;
        }

        private void txtStep2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (control(e))
                e.Handled = true;
        }

        private void txtStep3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (control(e))
                e.Handled = true;
        }

        private void txtStep4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (control(e))
                e.Handled = true;
        }

        private void txtStep5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (control(e))
                e.Handled = true;
        }

        private void txtStep6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (control(e))
                e.Handled = true;
        }

        private bool control(KeyPressEventArgs e)
        {
            if (
               char.IsLetter(e.KeyChar) ||
               char.IsSymbol(e.KeyChar) ||
               char.IsWhiteSpace(e.KeyChar) ||
               char.IsPunctuation(e.KeyChar)
               )
                return true;
            else
                return false;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            txtStep2.Enabled = txtStep3.Enabled = txtStep4.Enabled = txtStep5.Enabled = txtStep6.Enabled = true;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtStep2.Text != "" && txtStep3.Text != "" && txtStep4.Text != "" &&
                txtStep5.Text != "" && txtStep6.Text != "")
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                con.Open();
                SqlCommand command = new SqlCommand("Update Steps set Step1 = '" + Convert.ToInt32(txtStep2.Text) + "', " +
                                                    "Step2 = '" + Convert.ToInt32(txtStep3.Text) + "', " +
                                                    "Step3 = '" + Convert.ToInt32(txtStep4.Text) + "', " +
                                                    "Step4 = '" + Convert.ToInt32(txtStep5.Text) + "', " +
                                                    "Step5 = '" + Convert.ToInt32(txtStep6.Text) + "' " +
                                                    "where UserID = '" + userID + "'", con);
                command.ExecuteNonQuery();
                con.Close();

                SqlConnection con2 = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                con2.Open();

                SqlCommand command2 = new SqlCommand("Select * From Questions where UserID= " + userID, con2);
                SqlDataReader dr = command2.ExecuteReader();

                while (dr.Read())
                {
                    SqlConnection con3 = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                    con3.Open();
                    SqlCommand command3 = new SqlCommand("Update Questions Set DateTime = '" + DateTime.Now.ToString("yyyy-MM-dd") + "' " +
                                                         "Where UserID = '" + userID + "'", con3);
                    command3.ExecuteNonQuery();
                    con3.Close();
                }

                StudentScreen studentScreen = new StudentScreen(userName, userID);
                studentScreen.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Tüm alanları doldurunuz!");
        }

        private void MakeExam(List<int> questions)
        {
            List<int> randQuestions = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randQuestion = random.Next(1, (questions.Count + 1));
                randQuestions.Add(questions[randQuestion - 1]);
            }

            TryExam tryExam = new TryExam(randQuestions);
            tryExam.Show();
            this.Hide();
        }

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            List<int> questions = new List<int>();

            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
            con.Open();
            SqlCommand command2 = new SqlCommand("Select * From Questions where UserID= " + userID, con);
            SqlDataReader dr = command2.ExecuteReader();

            while (dr.Read())
            {
                if (Convert.ToInt32(dr["accuraryLevel"]) == 0)
                    questions.Add(Convert.ToInt32(dr["QuestionID"]));
            }

            if (questions.Count == 0)
                MessageBox.Show("Daha sınav olmadın!");
            else
            {
                MakeExam(questions);
            }
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtStep1.Enabled = txtStep2.Enabled = txtStep3.Enabled = txtStep4.Enabled = txtStep5.Enabled = txtStep6.Enabled = false;
            TrueFalsePercentage();
        }

        private void TrueFalsePercentage()
        {
            int trueCount = 0, falseCount = 0;

            SqlConnection con = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
            con.Open();
            SqlCommand command = new SqlCommand("Select * From Questions where UserID= " + userID, con);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (Convert.ToInt32(dr["AccuraryLevel"]) == 0)
                    falseCount++;
                else
                    trueCount++;
            }
            float truePercentage = Convert.ToSingle((trueCount + falseCount)) * (Convert.ToSingle(trueCount) / Convert.ToSingle(100));
            float falsePercentage = Convert.ToSingle((trueCount + falseCount)) * (Convert.ToSingle(falseCount) / Convert.ToSingle(100));

            lblTruePercentage.Text = "%" + (truePercentage * 100).ToString();
            lblFalsePercentage.Text = "%" + (falsePercentage * 100).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentScreen studentScreen = new StudentScreen(userName, userID);
            studentScreen.Show();
            this.Hide();
        }
    }
}
