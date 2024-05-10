namespace GYMManagamentSystem
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_id_textBox = new System.Windows.Forms.TextBox();
            this.full_name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_number_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.weight_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.height_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.program_type_comboBox = new System.Windows.Forms.ComboBox();
            this.back_button = new System.Windows.Forms.Button();
            this.salary_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.clear_button);
            this.panel1.Controls.Add(this.add_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(662, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 642);
            this.panel1.TabIndex = 1;
            // 
            // clear_button
            // 
            this.clear_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.clear_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.clear_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.Location = new System.Drawing.Point(55, 291);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(170, 55);
            this.clear_button.TabIndex = 5;
            this.clear_button.Text = "CLEAR";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // add_button
            // 
            this.add_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.add_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.add_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.ForeColor = System.Drawing.Color.White;
            this.add_button.Location = new System.Drawing.Point(55, 205);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(170, 55);
            this.add_button.TabIndex = 2;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(94, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ID :";
            // 
            // customer_id_textBox
            // 
            this.customer_id_textBox.Location = new System.Drawing.Point(206, 100);
            this.customer_id_textBox.Name = "customer_id_textBox";
            this.customer_id_textBox.Size = new System.Drawing.Size(403, 26);
            this.customer_id_textBox.TabIndex = 7;
            this.customer_id_textBox.TextChanged += new System.EventHandler(this.customer_id_textBox_TextChanged);
            // 
            // full_name_textBox
            // 
            this.full_name_textBox.Location = new System.Drawing.Point(206, 142);
            this.full_name_textBox.Name = "full_name_textBox";
            this.full_name_textBox.Size = new System.Drawing.Size(403, 26);
            this.full_name_textBox.TabIndex = 9;
            this.full_name_textBox.TextChanged += new System.EventHandler(this.full_name_textBox_TextChanged);
            this.full_name_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.full_name_textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(112, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Full Name :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // phone_number_textBox
            // 
            this.phone_number_textBox.Location = new System.Drawing.Point(206, 184);
            this.phone_number_textBox.MaxLength = 10;
            this.phone_number_textBox.Name = "phone_number_textBox";
            this.phone_number_textBox.Size = new System.Drawing.Size(403, 26);
            this.phone_number_textBox.TabIndex = 11;
            this.phone_number_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_number_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(77, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Phone Number :";
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.gender_comboBox.Location = new System.Drawing.Point(206, 439);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(403, 28);
            this.gender_comboBox.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(124, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Gender :";
            // 
            // age_textBox
            // 
            this.age_textBox.Location = new System.Drawing.Point(206, 220);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(403, 26);
            this.age_textBox.TabIndex = 15;
            this.age_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(149, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Age :";
            // 
            // weight_textBox
            // 
            this.weight_textBox.Location = new System.Drawing.Point(206, 261);
            this.weight_textBox.Name = "weight_textBox";
            this.weight_textBox.Size = new System.Drawing.Size(403, 26);
            this.weight_textBox.TabIndex = 17;
            this.weight_textBox.TextChanged += new System.EventHandler(this.weight_textBox_TextChanged);
            this.weight_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weight_textBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(133, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Weight :";
            // 
            // height_textBox
            // 
            this.height_textBox.Location = new System.Drawing.Point(206, 309);
            this.height_textBox.Name = "height_textBox";
            this.height_textBox.Size = new System.Drawing.Size(403, 26);
            this.height_textBox.TabIndex = 19;
            this.height_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.height_textBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Location = new System.Drawing.Point(133, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Height :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(82, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Program Type :";
            // 
            // program_type_comboBox
            // 
            this.program_type_comboBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.program_type_comboBox.FormattingEnabled = true;
            this.program_type_comboBox.Items.AddRange(new object[] {
            "None"});
            this.program_type_comboBox.Location = new System.Drawing.Point(206, 393);
            this.program_type_comboBox.Name = "program_type_comboBox";
            this.program_type_comboBox.Size = new System.Drawing.Size(403, 28);
            this.program_type_comboBox.TabIndex = 20;
            this.program_type_comboBox.SelectedIndexChanged += new System.EventHandler(this.program_type_comboBox_SelectedIndexChanged);
            // 
            // back_button
            // 
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(12, 12);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(170, 55);
            this.back_button.TabIndex = 22;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // salary_textBox
            // 
            this.salary_textBox.Location = new System.Drawing.Point(206, 351);
            this.salary_textBox.Name = "salary_textBox";
            this.salary_textBox.Size = new System.Drawing.Size(403, 26);
            this.salary_textBox.TabIndex = 24;
            this.salary_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_textBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Location = new System.Drawing.Point(133, 351);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Salary :";
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(944, 642);
            this.Controls.Add(this.salary_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.program_type_comboBox);
            this.Controls.Add(this.height_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.weight_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.age_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gender_comboBox);
            this.Controls.Add(this.phone_number_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.full_name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customer_id_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customer_id_textBox;
        private System.Windows.Forms.TextBox full_name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone_number_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox weight_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox height_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox program_type_comboBox;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox salary_textBox;
        private System.Windows.Forms.Label label9;
    }
}