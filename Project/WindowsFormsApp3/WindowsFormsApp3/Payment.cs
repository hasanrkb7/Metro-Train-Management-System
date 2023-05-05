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
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Payment : Form
    {
        public Payment(string Id, string Trainid, string name, string from, string day, string time, string to, string amount)
        {
            InitializeComponent();
            LblId.Text = Id;
            txtAmount.Text = amount;
            txtTrainId.Text = Trainid;
            txtTrainIName.Text = name;
            txtFrom.Text = from;
            txtTime.Text = time;
            txtTo.Text = to;
            txtDay.Text = day;



            cmbTicket.DropDownStyle = ComboBoxStyle.DropDownList;
            btnDownload.Hide();

        }

        SqlConnection Con = new SqlConnection("data source = DESKTOP-M0QONM4\\PULOCK; database = MetroTrainManagement; " +
                                  "integrated security = SSPI");



        private void btnBack_Click(object sender, EventArgs e)
        {
            TimeRoutes t = new TimeRoutes(LblId.Text);
            t.Show();
            Hide();

        }

        private void cmbTicket_SelectedIndexChanged(object sender, EventArgs e)
        {

            Con.Close();
            int b = Convert.ToInt32(cmbTicket.SelectedItem.ToString()) * Convert.ToInt32(txtAmount.Text);
            LblAmount.Text = b.ToString();

            setAmount();
            setTicket();

        }
        private void setAmount()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select Name,Amount,Phone,Address from UserTable where Id='" + Convert.ToInt32(LblId.Text) + "' ", Con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int amount = reader.GetInt32(1);
                OwnerName = reader.GetString(0);
                Phone = reader.GetString(2);
                Address = reader.GetString(3);

                int UpdateAmount = amount - Convert.ToInt32(LblAmount.Text);
                Amount = UpdateAmount;          
                Con.Close();
                return;
            }
        }

        private void setTicket()
        {
            SqlCommand cmd = new SqlCommand("select Ticket from TrainTable where TrainId='" + Convert.ToInt32(txtTrainId.Text) + "' ", Con);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int ticket = reader.GetInt32(0);
                updateticket = ticket - Convert.ToInt32(cmbTicket.SelectedItem.ToString());
                Con.Close();
                return;
            }

        }

        public int Amount { get; set; }
        public int updateticket { get; set; }
        public string OwnerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


        private void btnPay_Click(object sender, EventArgs e)
        {
            if (updateticket >= 0)
            {
                if (cmbTicket.Text != "")
                {
                    if (Convert.ToInt32(cmbTicket.SelectedItem.ToString()) > 0)
                    {
                        if (Amount >= 0)
                        {
                            if (checkUser())
                            {
                                Con.Open();
                                SqlCommand cmd1 = new SqlCommand("update TrainTable set Ticket='" + updateticket + "' where TrainId='" + Convert.ToInt32(txtTrainId.Text) + "' ", Con);
                                cmd1.ExecuteNonQuery();
                                Con.Close();

                                Con.Open();
                                SqlCommand cmd = new SqlCommand("update UserTable set Amount='" + Amount + "' where Id='" + Convert.ToInt32(LblId.Text) + "' ", Con);
                                cmd.ExecuteNonQuery();
                                Con.Close();

                                AnotherTryForPurchase();
                                btnDownload.Show();

                                SqlCommand cmd5 = new SqlCommand("select Seat from SeatCount where TrainId='" + Convert.ToInt32(txtTrainId.Text) + "' and UserId='" + Convert.ToInt32(LblId.Text) + "' and Status='New' ", Con);
                                Con.Open();
                                SqlDataReader reader = cmd5.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        a = reader.GetInt32(0);

                                    }
                                    int[] arr = new int[4 - a];

                                    if (arr.Length > 0)
                                    {
                                        for (int i = 0; i < arr.Length; i++)
                                        {
                                            arr[i] = i + 1;
                                        }

                                        cmbTicket.DataSource = arr;
                                        
                                    }
                                    else
                                    {
                                        int[] arr1 = { 0 };
                                        cmbTicket.DataSource = arr1;

                                    }


                                }
                            }
                            else
                            {
                                Con.Open();
                                SqlCommand cmd1 = new SqlCommand("update TrainTable set Ticket='" + updateticket + "' where TrainId='" + Convert.ToInt32(txtTrainId.Text) + "' ", Con);
                                cmd1.ExecuteNonQuery();
                                Con.Close();

                                Con.Open();
                                SqlCommand cmd = new SqlCommand("update UserTable set Amount='" + Amount + "' where Id='" + Convert.ToInt32(LblId.Text) + "' ", Con);
                                cmd.ExecuteNonQuery();
                                Con.Close();

                                FirstTimePurchase();
                                btnDownload.Show();

                                SqlCommand cmd6 = new SqlCommand("select Seat from SeatCount where TrainId='" + Convert.ToInt32(txtTrainId.Text) + "' and UserId='" + Convert.ToInt32(LblId.Text) + "' and Status='New' ", Con);
                                Con.Open();
                                SqlDataReader reader = cmd6.ExecuteReader();
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        a = reader.GetInt32(0);

                                    }
                                    int[] arr = new int[4 - a];

                                    if (arr.Length > 0)
                                    {
                                        for (int i = 0; i < arr.Length; i++)
                                        {
                                            arr[i] = i + 1;
                                        }

                                        cmbTicket.DataSource = arr;
                                    }
                                    else
                                    {
                                        int[] arr1 = { 0 };
                                        cmbTicket.DataSource = arr1;
                                    }

                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("tk nai");
                        }
                    }

                    else
                    {
                        MessageBox.Show("SORRY!! CAN'T PURCHASE MORE THAN 4 TICKET");


                    }
                }

                else
                {
                    MessageBox.Show("select one value from combobox");
                }
            }
            else
            {
                MessageBox.Show("TICKET NOT AVAILABLE");
            }
        }

        private void AnotherTryForPurchase()
        {
            Con.Open();
            SqlCommand cmd1 = new SqlCommand("select Seat from SeatCount where  TrainId='" + Convert.ToInt32(txtTrainId.Text) + "' and UserId='" + Convert.ToInt32(LblId.Text) + "' and Status='NEW' ", Con);
            SqlDataReader reader = cmd1.ExecuteReader();
            while (reader.Read())
            {
                seat = reader.GetInt32(0);
            }
            Con.Close();
            Con.Open();
            int finalseat = Convert.ToInt32(cmbTicket.SelectedItem.ToString()) + seat;
            SqlCommand cmd = new SqlCommand("update SeatCount set Seat='" + finalseat + "' where UserId='" + Convert.ToInt32(LblId.Text) + "' and Status='NEW'", Con);
            cmd.ExecuteNonQuery();
            Con.Close();

        }

        private void FirstTimePurchase()
        {
            Con.Open();
            SqlCommand cmd2 = new SqlCommand("Insert into SeatCount values('" + Convert.ToInt32(txtTrainId.Text) + "', '" + Convert.ToInt32(LblId.Text) + "' ,'" + Convert.ToInt32(cmbTicket.SelectedItem.ToString()) + "' ,'NEW')", Con);
            cmd2.ExecuteNonQuery();
            Con.Close();
        }

        private bool checkUser() //checking if the user purchase any ticket of a specific train before or this is the first time
        {
            SqlCommand cmd = new SqlCommand("select * from SeatCount where TrainId='" + Convert.ToInt32(txtTrainId.Text) + "' and UserId='" + Convert.ToInt32(LblId.Text) + "' and Status='New' ", Con);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                Con.Close();
                return true;

            }
            else
            {
                Con.Close();
                return false;
            }

        }
        public int count { get; set; }


        private void Payment_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Seat from SeatCount where TrainId='" + Convert.ToInt32(txtTrainId.Text) + "' and UserId='" + Convert.ToInt32(LblId.Text) + "' and Status='New' ", Con);
            Con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    a = reader.GetInt32(0);

                }
                int[] arr = new int[4 - a];

                if (arr.Length > 0)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = i + 1;
                    }
                    cmbTicket.DataSource = arr;
                }
                else
                {
                    int[] arr1 = { 0 };
                    cmbTicket.DataSource = arr1;
                }


            }
            else
            {
                cmbTicket.Items.Add(1);
                cmbTicket.Items.Add(2);
                cmbTicket.Items.Add(3);
                cmbTicket.Items.Add(4);

            }
        }
        int a { get; set; }
        int seat { get; set; }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            TicketDownload.Print();
            btnDownload.Hide();
        }

        private void TicketDownload_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Bitmap bmp = Properties.Resources.WaterMark;
            Image Img = bmp;
            e.Graphics.DrawImage(Img,0,0,900,1200);
            

            e.Graphics.DrawString("TRAIN DETAILS: ", new Font("ARIAL", 40, FontStyle.Underline), Brushes.Black, new Point(80, 200));

            e.Graphics.DrawString("TRAIN NAME: " + txtTrainIName.Text, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(0, 280));
            e.Graphics.DrawString("ID: " + txtTrainId.Text, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(0, 330));
            e.Graphics.DrawString("FROM: " + txtFrom.Text, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(0, 380));
            e.Graphics.DrawString("TO: " + txtTo.Text, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(425, 380));
            e.Graphics.DrawString("DAY: " + txtDay.Text, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(425, 330));     
            e.Graphics.DrawString("DEPARTURE TIME: " + txtTime.Text, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(425, 280));

            e.Graphics.DrawString("TICKET OWNER DETAILS: ", new Font("ARIAL", 40, FontStyle.Underline), Brushes.Black, new Point(25, 450));

            e.Graphics.DrawString("NAME: " +OwnerName, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(0, 550));
            e.Graphics.DrawString("TICKET QUANTITY: " + Convert.ToInt32(cmbTicket.SelectedItem.ToString()) , new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(300, 550));
            e.Graphics.DrawString("AMOUNT PAID: " +LblAmount.Text, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(600, 550));
            e.Graphics.DrawString("PHONE NUMBER: " +Phone, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(0,600));
            e.Graphics.DrawString("ADDRESS: " + Address, new Font("ARIAL", 20, FontStyle.Regular), Brushes.Black, new Point(0, 650));

            e.Graphics.DrawString("PURCHASE TIME: " +DateTime.Now, new Font("ARIAL", 25, FontStyle.Bold), Brushes.Black, new Point(0,750));
            e.Graphics.DrawString("TIME EXPIRED: " + DateTime.Now.AddDays(+1), new Font("ARIAL", 25, FontStyle.Bold), Brushes.Black, new Point(0, 800));

            e.Graphics.DrawString("***AFTER EXPIRED TIME THIS TICKET WILL BE INVALID", new Font("ARIAL", 20, FontStyle.Bold), Brushes.Red, new Point(0, 900));






        }
    }

        
    }
