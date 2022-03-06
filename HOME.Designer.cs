namespace Authentication
{
    partial class HOME
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HOME));
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.AddpersonBtn = new System.Windows.Forms.Button();
            this.ContactBtn = new System.Windows.Forms.Button();
            this.HelpBtn = new System.Windows.Forms.Button();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Yellow;
            this.HomeBtn.FlatAppearance.BorderSize = 0;
            this.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HomeBtn.ForeColor = System.Drawing.Color.Black;
            this.HomeBtn.Location = new System.Drawing.Point(1, 0);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(142, 56);
            this.HomeBtn.TabIndex = 6;
            this.HomeBtn.Text = "HOME";
            this.HomeBtn.UseVisualStyleBackColor = false;
            this.HomeBtn.Visible = false;
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.ForeColor = System.Drawing.Color.Yellow;
            this.ExitBtn.Location = new System.Drawing.Point(805, 14);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(87, 35);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // AddpersonBtn
            // 
            this.AddpersonBtn.FlatAppearance.BorderSize = 0;
            this.AddpersonBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AddpersonBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddpersonBtn.ForeColor = System.Drawing.Color.Yellow;
            this.AddpersonBtn.Location = new System.Drawing.Point(176, 14);
            this.AddpersonBtn.Name = "AddpersonBtn";
            this.AddpersonBtn.Size = new System.Drawing.Size(142, 36);
            this.AddpersonBtn.TabIndex = 4;
            this.AddpersonBtn.Text = "ADD USER";
            this.AddpersonBtn.UseVisualStyleBackColor = true;
            this.AddpersonBtn.Click += new System.EventHandler(this.AddpersonBtn_Click);
            // 
            // ContactBtn
            // 
            this.ContactBtn.FlatAppearance.BorderSize = 0;
            this.ContactBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContactBtn.ForeColor = System.Drawing.Color.Yellow;
            this.ContactBtn.Location = new System.Drawing.Point(21, 14);
            this.ContactBtn.Name = "ContactBtn";
            this.ContactBtn.Size = new System.Drawing.Size(132, 36);
            this.ContactBtn.TabIndex = 3;
            this.ContactBtn.Text = "CONTACT";
            this.ContactBtn.UseCompatibleTextRendering = true;
            this.ContactBtn.UseVisualStyleBackColor = true;
            this.ContactBtn.Click += new System.EventHandler(this.Contact_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            this.HelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.HelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelpBtn.ForeColor = System.Drawing.Color.Yellow;
            this.HelpBtn.Location = new System.Drawing.Point(328, 16);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(95, 31);
            this.HelpBtn.TabIndex = 6;
            this.HelpBtn.Text = "HELP";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.HelpBtn_Click);
            // 
            // DataPanel
            // 
            this.DataPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataPanel.AutoSize = true;
            this.DataPanel.BackColor = System.Drawing.Color.White;
            this.DataPanel.Location = new System.Drawing.Point(-1, 54);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(892, 503);
            this.DataPanel.TabIndex = 7;
            this.DataPanel.Visible = false;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.Color.Black;
            this.contentPanel.Controls.Add(this.ContactBtn);
            this.contentPanel.Controls.Add(this.HelpBtn);
            this.contentPanel.Controls.Add(this.ExitBtn);
            this.contentPanel.Controls.Add(this.AddpersonBtn);
            this.contentPanel.Location = new System.Drawing.Point(1, -2);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(892, 58);
            this.contentPanel.TabIndex = 8;
            // 
            // HOME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Authentication.Properties.Resources.lock_icon_29045;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 548);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.HomeBtn);
            this.Controls.Add(this.DataPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "HOME";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOME";
            this.Load += new System.EventHandler(this.HOME_Load);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button AddpersonBtn;
        private System.Windows.Forms.Button ContactBtn;
        private System.Windows.Forms.Button HelpBtn;
        private System.Windows.Forms.Panel DataPanel;
        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Panel contentPanel;
    }
}