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
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace GYMManagamentSystem
{
    public partial class MainForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");

        public MainForm()
        {
            InitializeComponent();
            CustomerText();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sign_out_button_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?"
               , "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void add_customer_button_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            this.Hide();
        }

        private void add_qr_button_Click(object sender, EventArgs e)
        {
            AddQrPanel addQrPanel = new AddQrPanel();
            addQrPanel.Show();
            this.Hide();

        }

        private void salary_button_Click(object sender, EventArgs e)
        {
            SalaryForm salaryForm = new SalaryForm();
            salaryForm.Show();
            if (salaryForm != null)
            {
                salaryForm.RefreshData();
            }
            this.Hide();
        }

        private void add_program_button_Click(object sender, EventArgs e)
        {
            AddProgram programform = new AddProgram();
            programform.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        public void CustomerText()
        {
            CustomerData ed = new CustomerData();
            List<CustomerData> listData = ed.customerListData();
            int active=0, inactive=0;
            foreach(CustomerData item in listData ) {
                if (item.Active == "Active") active++;
                else inactive++;
            }
            total_c_label.Text= listData.Count.ToString();
            active_c_label.Text= active.ToString();
            inactive_c_label.Text= inactive.ToString();
            
        }
    }
}
