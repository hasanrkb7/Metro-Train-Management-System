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

namespace WindowsFormsApp3
{
    public partial class ReportViewAdmin : Form
    {
        public ReportViewAdmin(string Id)
        {
            InitializeComponent();
            LblUserId.Text = Id;
            btnRestore.Hide();
        }

        SqlConnection Con = new SqlConnection("data source = DESKTOP-M0QONM4\\PULOCK; database = MetroTrainManagement; " +
                                   "integrated security = SSPI");

        private void btnBack_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from UserTable where Id='" + Convert.ToInt32(LblUserId.Text) + "' ", Con);

            Con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var LoginType = reader.GetInt32(10);
                    int Id = reader.GetInt32(0);
                    string UserName = reader.GetString(8);
                    int Amount = reader.GetInt32(11);

                    if (LoginType == 2)
                    {
                        UserDashBoard d = new UserDashBoard(Id, UserName, Amount);
                        d.Show();
                        Hide();
                    }
                    else
                    {
                        ADMIN_Dashboard a = new ADMIN_Dashboard(Id, UserName);
                        a.Show();
                        Hide();
                    }

                    Con.Close();
                    return;
                }
            }
        }

        private void ReportViewAdmin_Load(object sender, EventArgs e)
        {
            var query = "select Serial,UserId,Report,Time from Report where Checked='0' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dgvReport.DataSource = source;
                }
                else
                {
                    Show();
                    MessageBox.Show("NOTHING TO SHOW");
                }
            }
            Con.Close();

            
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            btnDltReport.Show();
            btnDltUser.Show();
            btnRestore.Hide();

            var query = "select Serial,UserId,Report,Time from Report where Checked='0' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dgvReport.DataSource = source;
                }
                else
                {
                    Show();
                    MessageBox.Show("NOTHING TO SHOW");
                }
            }
            Con.Close();

            var query1 = "select Serial,UserId,Report,Time from Report where Checked='0' ";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            Con.Open();
            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dgvReport.DataSource = source;
                }
                else
                {
                    Show();
                    MessageBox.Show("NOTHING TO SHOW");
                }
            }
            Con.Close();
        }

        private void btnOldReport_Click(object sender, EventArgs e)
        {
            btnDltReport.Hide();
            btnDltUser.Hide();
            btnRestore.Show();
            var query = "select Serial,UserId,Report,Time from Report where Checked='1' ";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dgvReport.DataSource = source;
                }
                else
                {
                    Show();
                    MessageBox.Show("NOTHING TO SHOW");
                }
            }
            Con.Close();
           

            var query1 = "select Serial,UserId,Report,Time from Report where Checked='1' ";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            Con.Open();
            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dgvReport.DataSource = source;
                }
                else
                {
                    Show();
                    MessageBox.Show("NOTHING TO SHOW");
                }
            }
            Con.Close();

        }

        private void dgvReport_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReport.SelectedRows.Count == 0)
                return;

            string p = dgvReport.SelectedRows[0].Cells[0].Value.ToString();
            string s= dgvReport.SelectedRows[0].Cells[1].Value.ToString();
            Report= dgvReport.SelectedRows[0].Cells[2].Value.ToString();
            Time= dgvReport.SelectedRows[0].Cells[3].Value.ToString();

            reportId = Convert.ToInt32(s);
            Serial= Convert.ToInt32(p);

        }
        public int reportId { get; set; }
        public int Serial { get; set; }
        public string Report { get; set; }
        public string Time { get; set; }

        private void btnDltReport_Click(object sender, EventArgs e)
        {
            if (reportId==0)
            {
                MessageBox.Show("PLEASE SELECT ONE FROM TABLE");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Report set Checked='1' where Serial='" + Serial + "' and UserId='" + reportId + "' ", Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                var query1 = "select Serial,UserId,Report,Time from Report where Checked='0' ";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                Con.Open();
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        BindingSource source = new BindingSource();
                        source.DataSource = reader;
                        dgvReport.DataSource = source;
                    }
                    else
                    {
                        Show();
                        MessageBox.Show("NOTHING TO SHOW");
                    }
                }
                Con.Close();
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (reportId == 0)
            {
                MessageBox.Show("PLEASE SELECT ONE FROM TABLE");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update Report set Checked='0' where Serial='" + Serial + "' and UserId='" + reportId + "' ", Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                var query1 = "select Serial,UserId,Report,Time from Report where Checked='1' ";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                Con.Open();
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        BindingSource source = new BindingSource();
                        source.DataSource = reader;
                        dgvReport.DataSource = source;
                    }
                    else
                    {
                        Show();
                        MessageBox.Show("NOTHING TO SHOW");
                    }
                }
                Con.Close();
            }
        }

        private void btnDltUser_Click(object sender, EventArgs e)
        {
            if (reportId == 0)
            {
                MessageBox.Show("PLEASE SELECT ONE FROM TABLE");
            }
            else
            {
                Con.Open();
                SqlCommand cmd2 = new SqlCommand("delete from UserTable where Id='" + reportId + "'", Con);
                cmd2.ExecuteNonQuery();
                Con.Close();

                Con.Open();
                SqlCommand cmd4= new SqlCommand("delete from Report where Id='" + reportId + "'", Con);
                cmd4.ExecuteNonQuery();
                Con.Close();


                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into DeletedUser values('"+reportId+"','"+Report+"','"+Time+"','"+Convert.ToInt32(LblUserId.Text)+"','"+DateTime.Now+"')  ", Con);
                cmd.ExecuteNonQuery();
                Con.Close();

                var query1 = "select Serial,UserId,Report,Time from Report where Checked='0' ";
                SqlCommand cmd1 = new SqlCommand(query1, Con);
                Con.Open();
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        BindingSource source = new BindingSource();
                        source.DataSource = reader;
                        dgvReport.DataSource = source;
                    }
                    else
                    {
                        Show();
                        MessageBox.Show("NOTHING TO SHOW");
                    }
                }
                Con.Close();

            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            btnDltReport.Hide();
            btnDltUser.Hide();
            btnRestore.Hide();

            var query1 = "select * from DeletedUser";
            SqlCommand cmd1 = new SqlCommand(query1, Con);
            Con.Open();
            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dgvReport.DataSource = source;
                }
                else
                {
                    Show();
                    MessageBox.Show("NOTHING TO SHOW");
                }
            }
            Con.Close();
        }
    }
}
