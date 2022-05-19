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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            DatagridviewSettings(dgvQuestions);
        }

        SqlConnection conn = new SqlConnection(@"Data Source =.\; Initial Catalog = dbStudentExamSystem; Integrated Security = True");
        SqlConnection conn2 = new SqlConnection(@"Data Source =.\; Initial Catalog = dbStudentExamSystem; Integrated Security = True");
        SqlConnection conn3 = new SqlConnection(@"Data Source =.\; Initial Catalog = dbStudentExamSystem; Integrated Security = True");
        SqlConnection conn4 = new SqlConnection(@"Data Source =.\; Initial Catalog = dbStudentExamSystem; Integrated Security = True");

        void Yenile()
        {
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM QuestionInformations WHERE isAccepted=0", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgvQuestions.DataSource = ds.Tables[0];
            conn.Close();
        }

        void Sil(int QuestionID)
        {
            string sql = "DELETE FROM QuestionInformations WHERE QuestionID=@QuestionID";
            SqlCommand cmd2 = new SqlCommand(sql, conn2);
            cmd2.Parameters.AddWithValue("@QuestionID", QuestionID);
            conn2.Open();
            cmd2.ExecuteNonQuery();
            conn2.Close();
        }

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conn4.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select QuestionID,ClassLevel,LessonName,QuestionImage from QuestionInformations", conn4);
            adtr.Fill(dt);
            dgvQuestions.DataSource = dt;
            conn4.Close();
            Yenile();
        }

        private void btnAccepted_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.RowCount > 0)
            {
                conn3.Open();
                string guncelle = "UPDATE QuestionInformations SET isAccepted=@isAccepted where QuestionID=@QuestionID";
                SqlCommand cmd3 = new SqlCommand(guncelle, conn3);
                cmd3.Parameters.AddWithValue("@isAccepted", (1));
                cmd3.Parameters.AddWithValue("@QuestionID", Convert.ToInt32(dgvQuestions.SelectedCells[0].Value));
                cmd3.ExecuteNonQuery();
                cmd3.Parameters.Clear();
                conn3.Close();
                Yenile();
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dgvQuestions.SelectedRows)
            {
                int QuestionID = Convert.ToInt32(drow.Cells[0].Value);
                Sil(QuestionID);
            }
            Yenile();
        }

        private void btnShowQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedRows = dgvQuestions.SelectedRows[0].Cells["questionIDDataGridViewTextBoxColumn"].Value.ToString();
                SqlConnection conn4 = new SqlConnection(@"Data Source=.\;Initial Catalog=dbStudentExamSystem;Integrated Security=True");
                conn4.Open();
                SqlCommand command = new SqlCommand("select * from QuestionInformations where QuestionID=" + int.Parse(selectedRows), conn4);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    byte[] img = (byte[])reader["QuestionImage"];
                    MemoryStream ms = new MemoryStream(img);
                    imgQuestion.Image = Image.FromStream(ms);
                }
                conn4.Close();
            }
            catch
            {
                MessageBox.Show("Gösterilecek soru yok!");
            }
        }


        public void DatagridviewSettings(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(39, 39, 58);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(34, 34, 53);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(29, 29, 48);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void dgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAccepted.Enabled = true;
            btnReject.Enabled = true;
            btnShowQuestion.Enabled = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            UserLogin userLogin = new UserLogin();
            this.Hide();
            userLogin.Show();
        }
    }
}
