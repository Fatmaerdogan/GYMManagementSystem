using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
namespace GYMManagamentSystem
{
    public partial class AddQrPanel : Form
    {
        public AddQrPanel()
        {
            InitializeComponent();
        }
        QRCodeEncoder code = new QRCodeEncoder();
        Image picture;
        private void back_button_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void AddQrPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void qr_code_add_button_Click(object sender, EventArgs e)
        {
            picture = code.Encode(textBox1.Text);
            qr_code_pictureBox.Image = picture;
        }
    }
}
