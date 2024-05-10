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

namespace GYMManagamentSystem
{
    public partial class UserForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\GYMManagamentSystem\GYMManagamentSystem\GYM.mdf;Integrated Security=True;Connect Timeout=30");

        public UserForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void customer_login_showpassword_CheckedChanged(object sender, EventArgs e)
        {
            customer_login_id.PasswordChar = customer_login_showpassword.Checked ? '\0' : '*';
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void personel_button_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void customer_login_button_Click(object sender, EventArgs e)
        {
            if (customer_login_id.Text == ""
               || customer_login_username.Text == "")
            {
                MessageBox.Show("Please fill all blank fields"
                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectData = "SELECT * FROM customer WHERE customer_id = @customer_id " +
                            "AND fullname = @fullname";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@fullname", customer_login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@customer_id", customer_login_id.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login successfully!"
                                    , "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                CustomerMainForm form = new CustomerMainForm(customer_login_id.Text);
                                form.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Fullname/ID"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
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
        }

        private void customer_login_username_TextChanged(object sender, EventArgs e){}

        private void customer_login_username_KeyPress(object sender, KeyPressEventArgs e) => e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
    }
}
