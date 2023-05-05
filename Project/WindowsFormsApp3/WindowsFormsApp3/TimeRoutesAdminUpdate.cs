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
    public partial class TimeRoutesAdminUpdate : Form
    {
        public TimeRoutesAdminUpdate(string id)
        {
            InitializeComponent();
            LblId.Text = id;
        }

        SqlConnection Con = new SqlConnection("data source = DESKTOP-M0QONM4\\PULOCK; database = MetroTrainManagement; " +
                                  "integrated security = SSPI");

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ( txtTrainIName.Text.Trim() == "" || txtFrom.Text.Trim() == "" || txtTo.Text.Trim() == "" || txtTime.Text.Trim() == "" || txtDay.Text.Trim() == "" || txtAmount.Text.Trim() == "" || txtSeat.Text.Trim() == "")
            {
                MessageBox.Show("PLEASE INSERT ALL VALUES");
            }
            else
            {
                Con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into TrainTable values('" + txtTrainIName.Text + "','" + txtFrom.Text + "','" + txtTo.Text + "','" + txtTime.Text + "','" + txtDay.Text + "','" + Convert.ToString(txtSeat.Text) + "','" + Convert.ToString(txtAmount.Text) + "','Arrivinng')", Con);
                cmd1.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("VALUE INSERT");
                var query = "select * from TrainTable";
                SqlCommand cmd = new SqlCommand(query, Con);
                Con.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        BindingSource source = new BindingSource();
                        source.DataSource = reader;
                        dgvTrain.DataSource = source;
                    }

                }
                Con.Close();

            }
        }

        private void TimeRoutesAdminUpdate_Load(object sender, EventArgs e)
        {
            var query = "select * from TrainTable";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dgvTrain.DataSource = source;
                }
                else
                {
                    Show();
                    MessageBox.Show("NOTHING TO SHOW");
                }
            }
            Con.Close();
        }

        private void dgvTrain_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTrain.SelectedRows.Count == 0)
                return;

            txtTrainId.Text = dgvTrain.SelectedRows[0].Cells[0].Value.ToString();
            txtTrainIName.Text = dgvTrain.SelectedRows[0].Cells[1].Value.ToString();
            txtFrom.Text = dgvTrain.SelectedRows[0].Cells[2].Value.ToString();
            txtTo.Text = dgvTrain.SelectedRows[0].Cells[3].Value.ToString();
            txtTime.Text = dgvTrain.SelectedRows[0].Cells[4].Value.ToString();
            txtDay.Text = dgvTrain.SelectedRows[0].Cells[5].Value.ToString();
            txtSeat.Text = dgvTrain.SelectedRows[0].Cells[6].Value.ToString();
            txtAmount.Text = dgvTrain.SelectedRows[0].Cells[7].Value.ToString();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTrainId.Text.Trim() == "" || txtTrainIName.Text.Trim() == "" || txtFrom.Text.Trim() == "" || txtTo.Text.Trim() == "" || txtTime.Text.Trim() == "" || txtDay.Text.Trim() == "" || txtAmount.Text.Trim() == "" || txtSeat.Text.Trim() == "")
            {
                MessageBox.Show("PLEASE INSERT ALL VALUES");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update TrainTable set TrainName='" + txtTrainIName.Text + "',Start='" + txtFrom.Text + "' , Destination='" + txtTo.Text + "' , Time ='" + txtTime.Text + "' , Day='" + txtDay.Text + "' , Ticket ='" + Convert.ToInt32(txtSeat.Text) + "' , Amount= '" + Convert.ToInt32(txtAmount.Text) + "' where TrainId='" + Convert.ToInt32(txtTrainId.Text) + "' ", Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                MessageBox.Show("VALUE UPDATED");

                var query = "select * from TrainTable";
                SqlCommand cmd1 = new SqlCommand(query, Con);
                Con.Open();
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        BindingSource source = new BindingSource();
                        source.DataSource = reader;
                        dgvTrain.DataSource = source;
                    }

                }
                Con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
         
            Con.Open();
            SqlCommand cmd = new SqlCommand("delete from TrainTable where TrainId ='" + Convert.ToInt32(txtTrainId.Text) + "' ", Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("VALUE DELETED");

            var query = "select * from TrainTable";
                SqlCommand cmd1 = new SqlCommand(query, Con);
                Con.Open();
            using (SqlDataReader reader = cmd1.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dgvTrain.DataSource = source;
                }
                else
                {
                    Show();
                    MessageBox.Show("NOTHING TO SHOW");
                }
            }
                Con.Close();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand("select * from UserTable where Id='" + Convert.ToInt32(LblId.Text) + "'  ", Con);

            Con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
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
}
