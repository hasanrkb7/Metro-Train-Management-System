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
    public partial class TimeRoutes : Form
    {
        public TimeRoutes(string Id)
        {
            InitializeComponent();

            LblUserId.Text = Id;
        }
        SqlConnection Con = new SqlConnection("data source = DESKTOP-M0QONM4\\PULOCK; database = MetroTrainManagement; " +
                                  "integrated security = SSPI");

        private void TimeRoutes_Load(object sender, EventArgs e)
        {
            var query = "select * from TrainTable where Status !='DEPARTED' and Ticket>0";
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from UserTable where Id='" + Convert.ToInt32(LblUserId.Text) + "'  ", Con);

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

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (txtTrainIName.Text.Trim() == "" || txtFrom.Text.Trim() == "" || txtTo.Text.Trim() == "" || txtTime.Text.Trim() == "" || txtDay.Text.Trim() == "" || txtAmount.Text.Trim() == "" || txtSeat.Text.Trim() == "")
            {
                MessageBox.Show("PLEASE SELECT ONE FROM TABLE");
            }
            else
            {
                Payment p = new Payment(LblUserId.Text,txtTrainId.Text, txtTrainIName.Text, txtFrom.Text, txtDay.Text, txtTime.Text, txtTo.Text, txtAmount.Text);
                p.Show();
                Hide();
            }
        }
    }
}
