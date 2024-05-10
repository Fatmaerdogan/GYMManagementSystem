namespace GYMManagamentSystem
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sign_out_button = new System.Windows.Forms.Button();
            this.add_program_button = new System.Windows.Forms.Button();
            this.add_qr_button = new System.Windows.Forms.Button();
            this.salary_button = new System.Windows.Forms.Button();
            this.add_customer_button = new System.Windows.Forms.Button();
            this.dashboard_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inactive_c_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.active_c_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.total_c_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 47);
            this.panel1.TabIndex = 0;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(50)))), ((int)(((byte)(44)))));
            this.panel2.Controls.Add(this.sign_out_button);
            this.panel2.Controls.Add(this.add_program_button);
            this.panel2.Controls.Add(this.add_qr_button);
            this.panel2.Controls.Add(this.salary_button);
            this.panel2.Controls.Add(this.add_customer_button);
            this.panel2.Controls.Add(this.dashboard_button);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 47);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 545);
            this.panel2.TabIndex = 1;
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
            // add_program_button
            // 
            this.add_program_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.add_program_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.add_program_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_program_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_program_button.ForeColor = System.Drawing.Color.White;
            this.add_program_button.Location = new System.Drawing.Point(24, 361);
            this.add_program_button.Name = "add_program_button";
            this.add_program_button.Size = new System.Drawing.Size(170, 55);
            this.add_program_button.TabIndex = 5;
            this.add_program_button.Text = "ADD PROGRAM";
            this.add_program_button.UseVisualStyleBackColor = true;
            this.add_program_button.Click += new System.EventHandler(this.add_program_button_Click);
            // 
            // add_qr_button
            // 
            this.add_qr_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.add_qr_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.add_qr_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_qr_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_qr_button.ForeColor = System.Drawing.Color.White;
            this.add_qr_button.Location = new System.Drawing.Point(25, 300);
            this.add_qr_button.Name = "add_qr_button";
            this.add_qr_button.Size = new System.Drawing.Size(170, 55);
            this.add_qr_button.TabIndex = 4;
            this.add_qr_button.Text = "ADD QR";
            this.add_qr_button.UseVisualStyleBackColor = true;
            this.add_qr_button.Click += new System.EventHandler(this.add_qr_button_Click);
            // 
            // salary_button
            // 
            this.salary_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.salary_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.salary_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salary_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary_button.ForeColor = System.Drawing.Color.White;
            this.salary_button.Location = new System.Drawing.Point(24, 239);
            this.salary_button.Name = "salary_button";
            this.salary_button.Size = new System.Drawing.Size(170, 55);
            this.salary_button.TabIndex = 3;
            this.salary_button.Text = "SALARY";
            this.salary_button.UseVisualStyleBackColor = true;
            this.salary_button.Click += new System.EventHandler(this.salary_button_Click);
            // 
            // add_customer_button
            // 
            this.add_customer_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.add_customer_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.add_customer_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_customer_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_customer_button.ForeColor = System.Drawing.Color.White;
            this.add_customer_button.Location = new System.Drawing.Point(25, 178);
            this.add_customer_button.Name = "add_customer_button";
            this.add_customer_button.Size = new System.Drawing.Size(170, 55);
            this.add_customer_button.TabIndex = 2;
            this.add_customer_button.Text = "ADD CUSTOMER";
            this.add_customer_button.UseVisualStyleBackColor = true;
            this.add_customer_button.Click += new System.EventHandler(this.add_customer_button_Click);
            // 
            // dashboard_button
            // 
            this.dashboard_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.dashboard_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.dashboard_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_button.ForeColor = System.Drawing.Color.White;
            this.dashboard_button.Location = new System.Drawing.Point(24, 116);
            this.dashboard_button.Name = "dashboard_button";
            this.dashboard_button.Size = new System.Drawing.Size(170, 55);
            this.dashboard_button.TabIndex = 1;
            this.dashboard_button.Text = "DASHBOARD";
            this.dashboard_button.UseVisualStyleBackColor = true;
            this.dashboard_button.Click += new System.EventHandler(this.dashboard_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Welcome,Personel";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.inactive_c_label);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(247, 438);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 141);
            this.panel3.TabIndex = 5;
            // 
            // inactive_c_label
            // 
            this.inactive_c_label.AutoSize = true;
            this.inactive_c_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.inactive_c_label.Location = new System.Drawing.Point(210, 63);
            this.inactive_c_label.Name = "inactive_c_label";
            this.inactive_c_label.Size = new System.Drawing.Size(23, 24);
            this.inactive_c_label.TabIndex = 1;
            this.inactive_c_label.Text = "0";
            this.inactive_c_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(110, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Inactive Customer";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.active_c_label);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(248, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 141);
            this.panel4.TabIndex = 4;
            // 
            // active_c_label
            // 
            this.active_c_label.AutoSize = true;
            this.active_c_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.active_c_label.Location = new System.Drawing.Point(210, 72);
            this.active_c_label.Name = "active_c_label";
            this.active_c_label.Size = new System.Drawing.Size(23, 24);
            this.active_c_label.TabIndex = 1;
            this.active_c_label.Text = "0";
            this.active_c_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(121, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Active Customer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.total_c_label);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(247, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(458, 141);
            this.panel5.TabIndex = 3;
            // 
            // total_c_label
            // 
            this.total_c_label.AutoSize = true;
            this.total_c_label.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.total_c_label.Location = new System.Drawing.Point(211, 70);
            this.total_c_label.Name = "total_c_label";
            this.total_c_label.Size = new System.Drawing.Size(23, 24);
            this.total_c_label.TabIndex = 1;
            this.total_c_label.Text = "0";
            this.total_c_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(122, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Total Customer";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(896, 592);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dashboard_button;
        private System.Windows.Forms.Button add_program_button;
        private System.Windows.Forms.Button add_qr_button;
        private System.Windows.Forms.Button salary_button;
        private System.Windows.Forms.Button add_customer_button;
        private System.Windows.Forms.Button sign_out_button;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label inactive_c_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label active_c_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label total_c_label;
        private System.Windows.Forms.Label label8;
    }
}