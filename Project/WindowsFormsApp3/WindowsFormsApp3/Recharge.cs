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
    public partial class Recharge : Form
    {
        public Recharge(string id)
        {
            InitializeComponent();
            LblId.Text = id;
        }

        SqlConnection Con = new SqlConnection("data source = DESKTOP-M0QONM4\\PULOCK; database = MetroTrainManagement; " +
                           "integrated security = SSPI ");

        private void textBoxUserName_Leave(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserTable where UserName='" + txtuName.Text.Trim() + "'", Con);

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                LbluName.Text = "Valid";

                Con.Close();
            }
            else
            {
                LbluName.Text = "USERNAME DOESN'T EXIST";
                txtuName.Text = "";
                Con.Close();
            }
        }

        private void txtuId_Leave(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserTable where Id='" + txtuId.Text.Trim() + "'", Con);

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                LbluId.Text = "Valid";
                Con.Close();
            }
            else
            {
                LbluId.Text = "USERID DOESN'T EXIST";
                txtuId.Text = "";
                Con.Close();
            }
        }

        private void btnRecharge_Click(object sender, EventArgs e)
        {

            if (txtuName.Text.Trim() == "" || txtuId.Text.Trim() == "")
            {
                MessageBox.Show("PLEASE PROVIDE ALL DETAILS");
            }
            else
            {
                var query = "select * from UserTable where Id='" + Convert.ToInt32(txtuId.Text) + "' and UserName='" + txtuName.Text.Trim() + "' ";
                SqlCommand cmd1 = new SqlCommand(query, Con);
                Con.Open();
                using (SqlDataReader reader = cmd1.ExecuteReader())
                {
                    if (reader.HasRows)
                    {

                        while (reader.Read())
                        {
                            int amount = reader.GetInt32(11);
                            int UpdateAmount = Convert.ToInt32(txtAmount.Text) + amount;
                            Amount = UpdateAmount;
                        }
                        reader.Close();
                        SqlCommand cmd = new SqlCommand("update UserTable set Amount='" + Amount + "' where Id='" + Convert.ToInt32(txtuId.Text) + "'  ", Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Amount debited");
                    }
                    else
                    {
                        MessageBox.Show("USERID AND USERNAME DOESN'T MATCH");
                    }

                }
                Con.Close();
            }

        }
        public int Amount { get; set; }

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
