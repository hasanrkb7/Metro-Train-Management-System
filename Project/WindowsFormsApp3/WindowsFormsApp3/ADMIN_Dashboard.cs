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
    public partial class ADMIN_Dashboard : Form
    {
        public ADMIN_Dashboard(int iD,string UserName)
        {
            InitializeComponent();
            LblId.Text = iD.ToString();
            LblUserName.Text = UserName;
        }

        private void buttonTimeTable_Click(object sender, EventArgs e)
        {
            TimeRoutesAdminUpdate t = new TimeRoutesAdminUpdate(LblId.Text);
            t.Show();
            Hide();
        }

        private void buttonUserRegistration_Click(object sender, EventArgs e)
        {
            Request r = new Request(LblId.Text);
            r.Show();
            Hide();
        }

        private void buttonRecharge_Click(object sender, EventArgs e)
        {
            Recharge u = new Recharge(LblId.Text);
            u.Show();
            Hide();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            Setting s = new Setting(LblId.Text);
            s.Show();
            Hide();
        }

        private void btnTrainStatus_Click(object sender, EventArgs e)
        {
            TrainStatus t = new TrainStatus(LblId.Text);
            t.Show();
            Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn l = new LogIn();
            l.Show();
            Hide();
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ReportViewAdmin r = new ReportViewAdmin(LblId.Text);
            r.Show();
            Hide();
        }
    }
}
