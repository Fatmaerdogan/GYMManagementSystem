namespace GYMManagamentSystem
{
    partial class AddQrPanel
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
            this.back_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.qr_code_add_button = new System.Windows.Forms.Button();
            this.qr_code_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qr_code_pictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.back_button.TabIndex = 24;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 26);
            this.textBox1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 30);
            this.label1.TabIndex = 26;
            this.label1.Text = "QR CODE NAME";
            // 
            // qr_code_add_button
            // 
            this.qr_code_add_button.Location = new System.Drawing.Point(96, 185);
            this.qr_code_add_button.Name = "qr_code_add_button";
            this.qr_code_add_button.Size = new System.Drawing.Size(204, 53);
            this.qr_code_add_button.TabIndex = 27;
            this.qr_code_add_button.Text = "CODE ADD";
            this.qr_code_add_button.UseVisualStyleBackColor = true;
            this.qr_code_add_button.Click += new System.EventHandler(this.qr_code_add_button_Click);
            // 
            // qr_code_pictureBox
            // 
            this.qr_code_pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qr_code_pictureBox.Location = new System.Drawing.Point(356, 79);
            this.qr_code_pictureBox.Name = "qr_code_pictureBox";
            this.qr_code_pictureBox.Size = new System.Drawing.Size(217, 217);
            this.qr_code_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qr_code_pictureBox.TabIndex = 28;
            this.qr_code_pictureBox.TabStop = false;
            // 
            // AddQrPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(792, 445);
            this.Controls.Add(this.qr_code_pictureBox);
            this.Controls.Add(this.qr_code_add_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.back_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddQrPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQrPanel";
            this.Load += new System.EventHandler(this.AddQrPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qr_code_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button qr_code_add_button;
        private System.Windows.Forms.PictureBox qr_code_pictureBox;
    }
}