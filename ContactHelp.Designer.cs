namespace Authentication
{
    partial class ContactHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactHelp));
            this.helpTextB = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // helpTextB
            // 
            this.helpTextB.BackColor = System.Drawing.Color.White;
            this.helpTextB.BulletIndent = 1;
            this.helpTextB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpTextB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpTextB.Location = new System.Drawing.Point(0, 0);
            this.helpTextB.Name = "helpTextB";
            this.helpTextB.ReadOnly = true;
            this.helpTextB.Size = new System.Drawing.Size(744, 508);
            this.helpTextB.TabIndex = 0;
            this.helpTextB.Text = resources.GetString("helpTextB.Text");
            this.helpTextB.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // ContactHelp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(744, 508);
            this.Controls.Add(this.helpTextB);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ContactHelp";
            this.ShowIcon = false;
            this.Text = "ContactHelp";
            this.Load += new System.EventHandler(this.ContactHelp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox helpTextB;
    }
}