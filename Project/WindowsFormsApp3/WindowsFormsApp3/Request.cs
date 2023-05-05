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
    public partial class Request : Form
    {
        public Request(string Id)
        {
            InitializeComponent();
            LblId.Text = Id;
        }
        SqlConnection Con = new SqlConnection("data source = DESKTOP-M0QONM4\\PULOCK; database = MetroTrainManagement; " +
                                   "integrated security = SSPI");

        private void Request_Load(object sender, EventArgs e)
        {
            var query = "select * from Request";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {             
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    DgvRequest.DataSource = source;
                }
                else
                {
                    Show();
                    MessageBox.Show("NOTHING TO SHOW");
                }
            }
            Con.Close();
        }

        
        
        private void DgvRequest_SelectionChanged(object sender, EventArgs e)
        {
            if (DgvRequest.SelectedRows.Count== 0)
                return;

            LblUid.Text = DgvRequest.SelectedRows[0].Cells[0].Value.ToString();
            LblName.Text = DgvRequest.SelectedRows[0].Cells[1].Value.ToString();
            LblNid.Text = DgvRequest.SelectedRows[0].Cells[2].Value.ToString();
            LblEmail.Text = DgvRequest.SelectedRows[0].Cells[3].Value.ToString();
            LblPhn.Text = DgvRequest.SelectedRows[0].Cells[4].Value.ToString();
            LblDob.Text = DgvRequest.SelectedRows[0].Cells[5].Value.ToString();
            LblGender.Text = DgvRequest.SelectedRows[0].Cells[6].Value.ToString();
            LblAddress.Text = DgvRequest.SelectedRows[0].Cells[7].Value.ToString();
            lblUserName.Text= DgvRequest.SelectedRows[0].Cells[8].Value.ToString();
            lblPassword.Text= DgvRequest.SelectedRows[0].Cells[9].Value.ToString();

        }

        private void Approve_Click(object sender, EventArgs e)
        {
            
            Con.Open();
            if (LblUid.Text != "-----")
            {
                SqlCommand cmd1 = new SqlCommand("insert into UserTable values('" + Convert.ToInt32(LblUid.Text) + "','" + LblName.Text + "','" + LblNid.Text + "','" + LblEmail.Text + "','" + LblPhn.Text + "','" + Convert.ToDateTime(LblDob.Text) + "','" + LblGender.Text + "','" + LblAddress.Text + "','" + lblUserName.Text + "','" + lblPassword.Text + "','2','0')", Con);
                cmd1.ExecuteNonQuery();
                Con.Close();

                Con.Open();
                SqlCommand cmd2 = new SqlCommand("delete from Request where Id='" + Convert.ToInt32(LblUid.Text) + "'", Con);
                cmd2.ExecuteNonQuery();
                Con.Close();

                var query = "select * from Request";
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        BindingSource source = new BindingSource();
                        source.DataSource = reader;
                        DgvRequest.DataSource = source;
                    }
                    else
                    {
                        Show();
                        MessageBox.Show("NOTHING TO SHOW");
                    }
                }
                Con.Close();


            }
            else
                MessageBox.Show("Nothing to show");
            Con.Close();


        }

        private void Reject_Click(object sender, EventArgs e)
        {
            if (LblUid.Text != "-----")
            {
                Con.Open();
                SqlCommand cmd2 = new SqlCommand("delete from Request where Id='" + Convert.ToInt32(LblUid.Text) + "'", Con);
                cmd2.ExecuteNonQuery();
                Con.Close();

                var query = "select * from Request";
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        BindingSource source = new BindingSource();
                        source.DataSource = reader;
                        DgvRequest.DataSource = source;
                    }
                    else
                    {
                        Show();
                        MessageBox.Show("NOTHING TO SHOW");
                        Con.Close();
                    }
                }
            }
            else
                MessageBox.Show("NOTHIING TO SHOW");
                Con.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from UserTable where Id='" + Convert.ToInt32(LblId.Text) + "' ", Con);

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

      
    }
}

