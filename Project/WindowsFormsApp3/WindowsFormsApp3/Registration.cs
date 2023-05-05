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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("data source = DESKTOP-M0QONM4\\PULOCK; database = MetroTrainManagement; " +
                                   "integrated security = SSPI");

        

        private void back_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            
            if (txtName.Text.Trim() == "" || txtNid.Text.Trim()== "" || txtEmail.Text.Trim() == "" || txtPhn.Text.Trim() == "" || txtAddress.Text.Trim() == "" || txtUserName.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("PLEASE PROVIDE ALL DETAILS");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into request(Name,Nid,Email,Phone,Dob,Gender,address,UserName,Password) values(@Name,@Nid,@Email,@Phone,@Dob,@Gender,@address,@UserName,@Password)", Con);
                cmd.Parameters.Add("@Name", txtName.Text);
                cmd.Parameters.Add("@Nid", txtNid.Text);
                cmd.Parameters.Add("@Email", txtEmail.Text);
                cmd.Parameters.Add("@Phone", txtPhn.Text);
                cmd.Parameters.Add("@Dob", dtmDob.Value);
                string gender;
                if (rMale.Checked)
                    gender = rMale.Text;
                else
                    gender = rFemale.Text;

                cmd.Parameters.Add("@Gender", gender);
                cmd.Parameters.Add("@address", txtAddress.Text);
                cmd.Parameters.Add("@UserName", txtUserName.Text.Trim());
                cmd.Parameters.Add("@Password", txtPassword.Text);
                cmd.ExecuteNonQuery();
                Con.Close();

                MessageBox.Show("SUBMIT SUCCESSFUL");

                
            }

        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from UserTable where UserName='" + txtUserName.Text.Trim() + "'", Con);

            SqlDataReader reader = cmd.ExecuteReader();


            if (reader.HasRows)
            {
                lblWarning.Text = "UserName Exists Plz select differnet One";
                txtUserName.Text = "";

                Con.Close();
            }
            else
            {
                lblWarning.Text = "";
                Con.Close();
            }
        }

       
    }
}
