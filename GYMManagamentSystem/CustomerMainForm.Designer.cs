namespace GYMManagamentSystem
{
    partial class CustomerMainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.sign_out_button = new System.Windows.Forms.Button();
            this.program_button = new System.Windows.Forms.Button();
            this.qr_scanning_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.customer_id_label = new System.Windows.Forms.Label();
            this.full_name_label = new System.Windows.Forms.Label();
            this.phone_number_label = new System.Windows.Forms.Label();
            this.height_label = new System.Windows.Forms.Label();
            this.weight_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.gender_label = new System.Windows.Forms.Label();
            this.daily_calorie_rewuirement_label = new System.Windows.Forms.Label();
            this.amount_label = new System.Windows.Forms.Label();
            this.active_status_label = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.sign_out_button);
            this.panel2.Controls.Add(this.program_button);
            this.panel2.Controls.Add(this.qr_scanning_button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 548);
            this.panel2.TabIndex = 7;
            // 
            // sign_out_button
            // 
            this.sign_out_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sign_out_button.Location = new System.Drawing.Point(25, 498);
            this.sign_out_button.Name = "sign_out_button";
            this.sign_out_button.Size = new System.Drawing.Size(86, 35);
            this.sign_out_button.TabIndex = 6;
            this.sign_out_button.Text = "Sign Out";
            this.sign_out_button.UseVisualStyleBackColor = true;
            this.sign_out_button.Click += new System.EventHandler(this.sign_out_button_Click);
            // 
            // program_button
            // 
            this.program_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.program_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.program_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.program_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.program_button.ForeColor = System.Drawing.Color.White;
            this.program_button.Location = new System.Drawing.Point(25, 178);
            this.program_button.Name = "program_button";
            this.program_button.Size = new System.Drawing.Size(170, 55);
            this.program_button.TabIndex = 2;
            this.program_button.Text = "Program";
            this.program_button.UseVisualStyleBackColor = true;
            this.program_button.Click += new System.EventHandler(this.program_button_Click);
            // 
            // qr_scanning_button
            // 
            this.qr_scanning_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.qr_scanning_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.qr_scanning_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.qr_scanning_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qr_scanning_button.ForeColor = System.Drawing.Color.White;
            this.qr_scanning_button.Location = new System.Drawing.Point(24, 116);
            this.qr_scanning_button.Name = "qr_scanning_button";
            this.qr_scanning_button.Size = new System.Drawing.Size(170, 55);
            this.qr_scanning_button.TabIndex = 1;
            this.qr_scanning_button.Text = "QR Scanning";
            this.qr_scanning_button.UseVisualStyleBackColor = true;
            this.qr_scanning_button.Click += new System.EventHandler(this.qr_scanning_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome,Customer";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(857, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 27);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 47);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "GYM MANAGEMENT SYSTEM";
            // 
            // customer_id_label
            // 
            this.customer_id_label.AutoSize = true;
            this.customer_id_label.Location = new System.Drawing.Point(267, 97);
            this.customer_id_label.Name = "customer_id_label";
            this.customer_id_label.Size = new System.Drawing.Size(166, 20);
            this.customer_id_label.TabIndex = 8;
            this.customer_id_label.Text = "Customer ID : CID001";
            // 
            // full_name_label
            // 
            this.full_name_label.AutoSize = true;
            this.full_name_label.Location = new System.Drawing.Point(267, 130);
            this.full_name_label.Name = "full_name_label";
            this.full_name_label.Size = new System.Drawing.Size(163, 20);
            this.full_name_label.TabIndex = 9;
            this.full_name_label.Text = "Full Name : Full Name";
            // 
            // phone_number_label
            // 
            this.phone_number_label.AutoSize = true;
            this.phone_number_label.Location = new System.Drawing.Point(267, 163);
            this.phone_number_label.Name = "phone_number_label";
            this.phone_number_label.Size = new System.Drawing.Size(199, 20);
            this.phone_number_label.TabIndex = 10;
            this.phone_number_label.Text = "Phone Number : 05555555";
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Location = new System.Drawing.Point(267, 260);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(95, 20);
            this.height_label.TabIndex = 11;
            this.height_label.Text = "Height : 165";
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Location = new System.Drawing.Point(267, 225);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(89, 20);
            this.weight_label.TabIndex = 12;
            this.weight_label.Text = "Weight : 70";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(267, 193);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(68, 20);
            this.age_label.TabIndex = 13;
            this.age_label.Text = "Age : 15";
            // 
            // gender_label
            // 
            this.gender_label.AutoSize = true;
            this.gender_label.Location = new System.Drawing.Point(267, 290);
            this.gender_label.Name = "gender_label";
            this.gender_label.Size = new System.Drawing.Size(109, 20);
            this.gender_label.TabIndex = 14;
            this.gender_label.Text = "Gender : Male";
            // 
            // daily_calorie_rewuirement_label
            // 
            this.daily_calorie_rewuirement_label.AutoSize = true;
            this.daily_calorie_rewuirement_label.Location = new System.Drawing.Point(267, 320);
            this.daily_calorie_rewuirement_label.Name = "daily_calorie_rewuirement_label";
            this.daily_calorie_rewuirement_label.Size = new System.Drawing.Size(222, 20);
            this.daily_calorie_rewuirement_label.TabIndex = 15;
            this.daily_calorie_rewuirement_label.Text = "Daily Calorie Requirement : 52";
            // 
            // amount_label
            // 
            this.amount_label.AutoSize = true;
            this.amount_label.Location = new System.Drawing.Point(267, 350);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(113, 20);
            this.amount_label.TabIndex = 16;
            this.amount_label.Text = "Amount : 1200";
            // 
            // active_status_label
            // 
            this.active_status_label.AutoSize = true;
            this.active_status_label.Location = new System.Drawing.Point(267, 381);
            this.active_status_label.Name = "active_status_label";
            this.active_status_label.Size = new System.Drawing.Size(111, 20);
            this.active_status_label.TabIndex = 17;
            this.active_status_label.Text = "Active Status :";
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(905, 595);
            this.Controls.Add(this.active_status_label);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.daily_calorie_rewuirement_label);
            this.Controls.Add(this.gender_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.phone_number_label);
            this.Controls.Add(this.full_name_label);
            this.Controls.Add(this.customer_id_label);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerMainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerMainForm_FormClosing);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button sign_out_button;
        private System.Windows.Forms.Button program_button;
        private System.Windows.Forms.Button qr_scanning_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label customer_id_label;
        private System.Windows.Forms.Label full_name_label;
        private System.Windows.Forms.Label phone_number_label;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label gender_label;
        private System.Windows.Forms.Label daily_calorie_rewuirement_label;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.Label active_status_label;
    }
}