namespace GYMManagamentSystem
{
    partial class QRScanningPanel
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
            this.components = new System.ComponentModel.Container();
            this.qr_scanning_comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.camera_open_button = new System.Windows.Forms.Button();
            this.qr_scanning_button = new System.Windows.Forms.Button();
            this.qr_scanning_textBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.back_button = new System.Windows.Forms.Button();
            this.qrscanning_pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.qrscanning_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // qr_scanning_comboBox
            // 
            this.qr_scanning_comboBox.FormattingEnabled = true;
            this.qr_scanning_comboBox.Location = new System.Drawing.Point(244, 29);
            this.qr_scanning_comboBox.Name = "qr_scanning_comboBox";
            this.qr_scanning_comboBox.Size = new System.Drawing.Size(384, 28);
            this.qr_scanning_comboBox.TabIndex = 0;
            this.qr_scanning_comboBox.SelectedIndexChanged += new System.EventHandler(this.qr_scanning_comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Camera";
            // 
            // camera_open_button
            // 
            this.camera_open_button.Location = new System.Drawing.Point(301, 72);
            this.camera_open_button.Name = "camera_open_button";
            this.camera_open_button.Size = new System.Drawing.Size(123, 43);
            this.camera_open_button.TabIndex = 3;
            this.camera_open_button.Text = "Camera Open";
            this.camera_open_button.UseVisualStyleBackColor = true;
            this.camera_open_button.Click += new System.EventHandler(this.camera_open_button_Click);
            // 
            // qr_scanning_button
            // 
            this.qr_scanning_button.Location = new System.Drawing.Point(439, 72);
            this.qr_scanning_button.Name = "qr_scanning_button";
            this.qr_scanning_button.Size = new System.Drawing.Size(123, 43);
            this.qr_scanning_button.TabIndex = 4;
            this.qr_scanning_button.Text = "QR Scanning";
            this.qr_scanning_button.UseVisualStyleBackColor = true;
            this.qr_scanning_button.Click += new System.EventHandler(this.qr_scanning_button_Click);
            // 
            // qr_scanning_textBox
            // 
            this.qr_scanning_textBox.Location = new System.Drawing.Point(301, 388);
            this.qr_scanning_textBox.Name = "qr_scanning_textBox";
            this.qr_scanning_textBox.Size = new System.Drawing.Size(262, 26);
            this.qr_scanning_textBox.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // back_button
            // 
            this.back_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.back_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(87)))), ((int)(((byte)(70)))));
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_button.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.back_button.ForeColor = System.Drawing.Color.White;
            this.back_button.Location = new System.Drawing.Point(12, 8);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(118, 48);
            this.back_button.TabIndex = 24;
            this.back_button.Text = "BACK";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // qrscanning_pictureBox
            // 
            this.qrscanning_pictureBox.Location = new System.Drawing.Point(301, 121);
            this.qrscanning_pictureBox.Name = "qrscanning_pictureBox";
            this.qrscanning_pictureBox.Size = new System.Drawing.Size(260, 239);
            this.qrscanning_pictureBox.TabIndex = 25;
            this.qrscanning_pictureBox.TabStop = false;
            // 
            // QRScanningPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(792, 436);
            this.Controls.Add(this.qrscanning_pictureBox);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.qr_scanning_textBox);
            this.Controls.Add(this.qr_scanning_button);
            this.Controls.Add(this.camera_open_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qr_scanning_comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QRScanningPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QRScanningPanel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRScanningPanel_FormClosing);
            this.Load += new System.EventHandler(this.QRScanningPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrscanning_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox qr_scanning_comboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button camera_open_button;
        private System.Windows.Forms.Button qr_scanning_button;
        private System.Windows.Forms.TextBox qr_scanning_textBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.PictureBox qrscanning_pictureBox;
    }
}