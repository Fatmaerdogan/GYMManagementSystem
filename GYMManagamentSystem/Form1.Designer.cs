namespace GYMManagamentSystem
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.customer_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.login_username = new System.Windows.Forms.TextBox();
            this.login_password = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.login_showpassword = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(147)))), ((int)(((byte)(175)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.customer_button);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 595);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customer_button
            // 
            this.customer_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(147)))), ((int)(((byte)(175)))));
            this.customer_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.customer_button.Location = new System.Drawing.Point(29, 528);
            this.customer_button.Name = "customer_button";
            this.customer_button.Size = new System.Drawing.Size(323, 44);
            this.customer_button.TabIndex = 14;
            this.customer_button.Text = "CUSTOMER ENTRY";
            this.customer_button.UseVisualStyleBackColor = true;
            this.customer_button.Click += new System.EventHandler(this.customer_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(108, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "PERSONEL";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(106, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 39);
            this.label6.TabIndex = 12;
            this.label6.Text = "SYSTEM";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "MANAGEMENT";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(137, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "GYM";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "SWITCH TO CUSTOMER ACCOUNT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.exit.Location = new System.Drawing.Point(810, 9);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(27, 27);
            this.exit.TabIndex = 2;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOGIN ACCOUNT";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.username.Location = new System.Drawing.Point(397, 216);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(102, 19);
            this.username.TabIndex = 4;
            this.username.Text = "Username :";
            this.username.Click += new System.EventHandler(this.username_Click);
            // 
            // login_username
            // 
            this.login_username.Location = new System.Drawing.Point(401, 248);
            this.login_username.Name = "login_username";
            this.login_username.Size = new System.Drawing.Size(392, 26);
            this.login_username.TabIndex = 5;
            this.login_username.TextChanged += new System.EventHandler(this.login_username_TextChanged);
            // 
            // login_password
            // 
            this.login_password.Location = new System.Drawing.Point(401, 360);
            this.login_password.Name = "login_password";
            this.login_password.PasswordChar = '*';
            this.login_password.Size = new System.Drawing.Size(392, 26);
            this.login_password.TabIndex = 6;
            this.login_password.TextChanged += new System.EventHandler(this.login_password_TextChanged);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.password.Location = new System.Drawing.Point(397, 327);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(98, 19);
            this.password.TabIndex = 7;
            this.password.Text = "Password :";
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.White;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.login_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Location = new System.Drawing.Point(504, 460);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(176, 57);
            this.login_button.TabIndex = 8;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // login_showpassword
            // 
            this.login_showpassword.AutoSize = true;
            this.login_showpassword.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login_showpassword.Location = new System.Drawing.Point(649, 392);
            this.login_showpassword.Name = "login_showpassword";
            this.login_showpassword.Size = new System.Drawing.Size(146, 23);
            this.login_showpassword.TabIndex = 9;
            this.login_showpassword.Text = "Show Password";
            this.login_showpassword.UseVisualStyleBackColor = true;
            this.login_showpassword.CheckedChanged += new System.EventHandler(this.login_showpassword_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(899, 595);
            this.Controls.Add(this.login_showpassword);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login_password);
            this.Controls.Add(this.login_username);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.CheckBox login_showpassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button customer_button;
    }
}

