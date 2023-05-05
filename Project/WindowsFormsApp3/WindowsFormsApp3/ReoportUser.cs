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
    public partial class Report : Form
    {
        public Report(String Id)
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Report values('"+Convert.ToInt32(LblUserId.Text)+"','"+txtReport.Text+"','0','"+DateTime.Now+"')",Con);
            cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("THANKS FOR REPORTING WE WILL LOOK AFTER IT");
        }
    }
}

