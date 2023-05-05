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
    public partial class HISTORY : Form
    {
        public HISTORY(string Id)
        {
            InitializeComponent();
            LblUserId.Text = Id;
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

                   UserDashBoard d = new UserDashBoard(Id, UserName, Amount);
                   d.Show();
                   Hide();
                                 

                    Con.Close();
                    return;
                }
            }
        }

        private void HISTORY_Load(object sender, EventArgs e)
        {
            var query = "select TrainId,UserId,Seat from SeatCount where UserId='"+Convert.ToInt32(LblUserId.Text)+"'";
            SqlCommand cmd = new SqlCommand(query, Con);
            Con.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    BindingSource source = new BindingSource();
                    source.DataSource = reader;
                    dgvHistory.DataSource = source;
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
