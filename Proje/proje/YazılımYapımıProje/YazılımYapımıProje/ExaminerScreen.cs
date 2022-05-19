using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazılımYapımıProje
{
    public partial class ExaminerScreen : Form
    {
        public ExaminerScreen()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=.\\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
        string imagepath;
        private void btnQuestionSelect_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Seç";
            openFileDialog1.Filter = "Jpg Dosyaları(*.jpg)|*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imgBrowser.Image = Image.FromFile(openFileDialog1.FileName);
                imagepath = openFileDialog1.FileName;

            }
        }


        private void btnQuestionAdd_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fileStream = new FileStream(imagepath, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                byte[] img = binaryReader.ReadBytes((int)fileStream.Length);
                binaryReader.Close();
                fileStream.Close();

                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into QuestionInformations(ClassLevel,UnitNo,SectionNo,QuestionNo,LessonName," +
                    "UnitName,SectionName,RightAnswer,isAccepted,QuestionImage) values(@ClassLevel,@UnitNo,@SectionNo,@QuestionNo,@LessonName," +
                    "@UnitName,@SectionName,@RightAnswer,@isAccepted,@images)", connection);
                cmd.Parameters.AddWithValue("@ClassLevel", int.Parse(txtClassLevel.Text));
                cmd.Parameters.AddWithValue("@UnitNo", int.Parse(txtUnitNo.Text));
                cmd.Parameters.AddWithValue("@SectionNo", int.Parse(txtSectionNo.Text));
                cmd.Parameters.AddWithValue("@QuestionNo", int.Parse(txtQuestionNo.Text));
                cmd.Parameters.AddWithValue("@LessonName", txtLessonName.Text);
                cmd.Parameters.AddWithValue("@UnitName", txtUnitName.Text);
                cmd.Parameters.AddWithValue("@SectionName", txtSectionName.Text);
                cmd.Parameters.AddWithValue("@RightAnswer", txtRightAnswer.Text);
                cmd.Parameters.AddWithValue("@isAccepted", "0");
                cmd.Parameters.Add("@images", SqlDbType.Image, img.Length).Value = img;
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Kayıt Eklendi", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Hatalı Doldurma");
            }
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            UserLogin userLogin= new UserLogin();
            this.Hide();
            userLogin.Show();
        }
    }
}
