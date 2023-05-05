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

namespace WindowsFormsApp3
{
    public partial class Setting : Form
    {
        public Setting(string id)
        {
            InitializeComponent();
            LblId.Text = id;

        }


        SqlConnection Con = new SqlConnection("data source = DESKTOP-M0QONM4\\PULOCK; database = MetroTrainManagement; " +
                           "integrated security = SSPI ");


        private void txtuName_Leave(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserTable where Id='"+Convert.ToInt32(LblId.Text)+"' and UserName='"+txtuName.Text.Trim()+"' ", Con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                LblWarning.Text = "";
            }
            else
            {
                LblWarning.Text = "UserName and Userid doesn't Match";
                txtuName.Text = "";
            }
            Con.Close();
        }


        private void txtReType_Leave(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Trim() == txtReType.Text.Trim())
            {
                LblWarning1.Text = "";
            }
            else
            {
                LblWarning1.Text = "Passwords doesn't Match";
                txtReType.Text = "";
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtOld.Text== "" || txtuName.Text.Trim() == "" || txtNewPass.Text.Trim() == "" || txtReType.Text.Trim() == "")
            {
                MessageBox.Show("Enter all information");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTable set Password='"+txtNewPass.Text.Trim()+ "' where Id='" + Convert.ToInt32(LblId.Text) + "' ", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("PASSWORD CHANGE SUCCESSFUL");
                Con.Close();
            }

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

        private void txtOld_Leave(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserTable where Id='" + Convert.ToInt32(LblId.Text) + "' and Password='" + txtOld.Text+ "' ", Con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                LblWarning.Text = "";
            }
            else
            {
                MessageBox.Show("WRONG PASSWORD");
                txtOld.Text = "";
            }
            Con.Close();
        }
    }
 }
