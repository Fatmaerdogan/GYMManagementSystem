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
    public partial class SalaryForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");

        public SalaryForm()
        {
            InitializeComponent();
            displaySalaryData();
            disableFields();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            displaySalaryData();
            disableFields();
        }

        public void displaySalaryData()
        {
            SalaryData sd = new SalaryData();
            List<SalaryData> listData = sd.salaryCustomerListData();

            dataGridView1.DataSource = listData;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                customer_id_textBox.Text = row.Cells[1].Value.ToString();
                fullname_textBox.Text = row.Cells[2].Value.ToString();
                salary_textBox.Text = row.Cells[3].Value.ToString();
            }
        }

        private void back_button_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
        public void clearFields()
        {
            customer_id_textBox.Text = "";
            salary_textBox.Text = "";
            fullname_textBox.Text = "";
        }
        private void update_button_Click(object sender, EventArgs e)
        {
            if (salary_textBox.Text == ""
                || fullname_textBox.Text == ""
                || customer_id_textBox.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to UPDATE Customer ID: "
                    + salary_textBox.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                                connect.Open();
                            DateTime today = DateTime.Today;

                            string updateData = "UPDATE customer SET salary = @salary WHERE customer_id = @customer_id " ;
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@customer_id", customer_id_textBox.Text.Trim());
                                cmd.Parameters.AddWithValue("@salary", salary_textBox.Text.Trim());

                                cmd.ExecuteNonQuery();

                                    displaySalaryData();

                                    MessageBox.Show("Updated successfully!"
                                        , "Information Message", MessageBoxButtons.OK
                                        , MessageBoxIcon.Information);

                                    clearFields();
                                
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex, "Error Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled", "Information Message"
                    , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void disableFields()
        {
            customer_id_textBox.Enabled = false;
            fullname_textBox.Enabled = false;
        }
        private void clear_button_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void salary_textBox_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
    }
}
