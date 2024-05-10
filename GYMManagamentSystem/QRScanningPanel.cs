using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;

namespace GYMManagamentSystem
{
    public partial class QRScanningPanel : Form
    {
        FilterInfoCollection wepcam;
        VideoCaptureDevice cam;
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");
        string customer_ID;
        int ActiveTemp;
        public QRScanningPanel(string value, int activetemp)
        {
            InitializeComponent();
            customer_ID = value;
            ActiveTemp = activetemp;
        }

        private void qr_scanning_button_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void camera_open_button_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(wepcam[qr_scanning_comboBox.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(AssigningNewImageToCamera);
            cam.Start();
        }

        private void QRScanningPanel_Load(object sender, EventArgs e)
        {
            wepcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in wepcam)
            {
                qr_scanning_comboBox.Items.Add(info.Name);
            }
            qr_scanning_comboBox.SelectedIndex = 0;
        }
        private void AssigningNewImageToCamera(object sender, NewFrameEventArgs eventArgs)
        {
            if ((Bitmap)eventArgs.Frame.Clone() != null)
            {
                qrscanning_pictureBox.Image=((Bitmap) eventArgs.Frame.Clone());
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader barcode=new BarcodeReader();
            if (qrscanning_pictureBox.Image != null)
            {
                Result res=barcode.Decode((Bitmap)qrscanning_pictureBox.Image);
                if(res != null)
                {
                    try
                    {
                        string dec = res.ToString().Trim();
                        if (dec != "")
                        {
                            timer1.Stop();
                            qr_scanning_textBox.Text = dec;
                            MessageBox.Show("QR Read!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActiveSet();
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
                    
            }
        }
        public void ActiveSet()
        {
            if (connect.State == ConnectionState.Closed)
            {

                try
                {
                    connect.Open();
                    
                    string UpdateData = "UPDATE customer SET active=@active WHERE customer_id = @customer_id ";

                    using (SqlCommand command = new SqlCommand(UpdateData, connect))
                    {

                        command.Parameters.AddWithValue("@customer_id", customer_ID);
                        command.Parameters.AddWithValue("@active", (ActiveTemp == 1) ? 0 : 1);

                        command.ExecuteNonQuery();
                        CustomerMainForm mainForm = new CustomerMainForm(customer_ID);
                        mainForm.Show();
                        this.Hide();

                    }

                    
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void QRScanningPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cam != null && cam.IsRunning == true)
                {
                    cam.Stop();
                }
               
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            CustomerMainForm mainForm = new CustomerMainForm(customer_ID);
            mainForm.Show();
            this.Hide();
        }

        private void qr_scanning_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
