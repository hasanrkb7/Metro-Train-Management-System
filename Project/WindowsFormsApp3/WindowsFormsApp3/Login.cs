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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("data source = DESKTOP-M0QONM4\\PULOCK; database = MetroTrainManagement; " +
                                  "integrated security = SSPI");

        private void SignUp_Click(object sender, EventArgs e)
        {
            Registration r = new Registration();
            r.Show();
            this.Hide();


        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
                SqlCommand cmd = new SqlCommand("select * from UserTable where UserName='" + txtUserName.Text.Trim() + "' and Password='" + txtPassword.Text + "' ", Con);

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
                    
                    else
                    {
                        MessageBox.Show("Invalid user");
                        Con.Close();
                    }

                }
            }
        }
    }