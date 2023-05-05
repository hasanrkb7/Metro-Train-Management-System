using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UserDashBoard : Form
    {
        
        public UserDashBoard(int Id,String UserName,int Amount)
        {
           
              InitializeComponent();

            LblUserId.Text = Id.ToString();
            LblUserName.Text = UserName;
            lblAmount.Text = Amount.ToString();


        }

        private void TimeRoute_Click(object sender, EventArgs e)
        {
            TimeRoutes t = new TimeRoutes(LblUserId.Text);
            t.Show();
            Hide();
        }

        private void recharcge_Click(object sender, EventArgs e)
        {
            Recharge u = new Recharge(LblUserId.Text);
            u.Show();
            Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting u = new Setting(LblUserId.Text);
            u.Show();
            Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report r = new Report(LblUserId.Text);
            r.Show();
            Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HISTORY H = new HISTORY(LblUserId.Text);
            H.Show();
            Hide();
        }
    }
}
