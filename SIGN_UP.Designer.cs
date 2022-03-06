namespace Authentication
{
    partial class SIGN_UP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SIGN_UP));
            this.XBtn = new System.Windows.Forms.Button();
            this.camBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTbox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.detectedFace = new System.Windows.Forms.PictureBox();
            this.capturBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedFace)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // XBtn
            // 
            this.XBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.XBtn.BackColor = System.Drawing.Color.Transparent;
            this.XBtn.FlatAppearance.BorderSize = 0;
            this.XBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.XBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.XBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.XBtn.Location = new System.Drawing.Point(730, 0);
            this.XBtn.Name = "XBtn";
            this.XBtn.Size = new System.Drawing.Size(23, 30);
            this.XBtn.TabIndex = 0;
            this.XBtn.Text = "X";
            this.XBtn.UseVisualStyleBackColor = false;
            this.XBtn.Click += new System.EventHandler(this.XBtn_Click);
            // 
            // camBtn
            // 
            this.camBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.camBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.camBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.camBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.camBtn.ForeColor = System.Drawing.Color.Black;
            this.camBtn.Location = new System.Drawing.Point(143, 176);
            this.camBtn.Name = "camBtn";
            this.camBtn.Size = new System.Drawing.Size(125, 32);
            this.camBtn.TabIndex = 5;
            this.camBtn.Text = "CAMERA";
            this.camBtn.UseVisualStyleBackColor = true;
            this.camBtn.Click += new System.EventHandler(this.camBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(-1, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "NAME";
            // 
            // nameTbox
            // 
            this.nameTbox.BackColor = System.Drawing.Color.White;
            this.nameTbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTbox.ForeColor = System.Drawing.Color.Black;
            this.nameTbox.Location = new System.Drawing.Point(98, 112);
            this.nameTbox.Multiline = true;
            this.nameTbox.Name = "nameTbox";
            this.nameTbox.Size = new System.Drawing.Size(235, 27);
            this.nameTbox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(348, 113);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(393, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // detectedFace
            // 
            this.detectedFace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.detectedFace.Location = new System.Drawing.Point(13, 324);
            this.detectedFace.Name = "detectedFace";
            this.detectedFace.Size = new System.Drawing.Size(329, 198);
            this.detectedFace.TabIndex = 9;
            this.detectedFace.TabStop = false;
            this.detectedFace.Visible = false;
            // 
            // capturBtn
            // 
            this.capturBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.capturBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.capturBtn.FlatAppearance.BorderSize = 0;
            this.capturBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.capturBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.capturBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.capturBtn.ForeColor = System.Drawing.Color.Black;
            this.capturBtn.Location = new System.Drawing.Point(96, 531);
            this.capturBtn.Name = "capturBtn";
            this.capturBtn.Size = new System.Drawing.Size(135, 32);
            this.capturBtn.TabIndex = 11;
            this.capturBtn.Text = "CAPTURE";
            this.capturBtn.UseVisualStyleBackColor = true;
            this.capturBtn.Visible = false;
            this.capturBtn.Click += new System.EventHandler(this.capturBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.helpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.helpBtn.ForeColor = System.Drawing.Color.Black;
            this.helpBtn.Location = new System.Drawing.Point(666, 33);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(85, 32);
            this.helpBtn.TabIndex = 12;
            this.helpBtn.Text = "HELP";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.XBtn);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(753, 27);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(-1, 567);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 15);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(0, 455);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 114);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(739, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 114);
            this.panel4.TabIndex = 16;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(743, 455);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 114);
            this.panel5.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(739, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 114);
            this.panel6.TabIndex = 16;
            // 
            // cboCamera
            // 
            this.cboCamera.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(207, 27);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(193, 29);
            this.cboCamera.TabIndex = 18;
            // 
            // SIGN_UP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(753, 581);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.capturBtn);
            this.Controls.Add(this.detectedFace);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.nameTbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.camBtn);
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "SIGN_UP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIGN UP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detectedFace)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button XBtn;
        private System.Windows.Forms.Button camBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox detectedFace;
        private System.Windows.Forms.Button capturBtn;
        private System.Windows.Forms.Button helpBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cboCamera;
    }
}

