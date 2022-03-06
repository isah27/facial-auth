namespace Authentication
{
    partial class BACKUP
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
            this.label1 = new System.Windows.Forms.Label();
            this.PinTbox = new System.Windows.Forms.TextBox();
            this.ProceedBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorTbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "SECRET PIN";
            // 
            // PinTbox
            // 
            this.PinTbox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PinTbox.Location = new System.Drawing.Point(181, 23);
            this.PinTbox.Name = "PinTbox";
            this.PinTbox.Size = new System.Drawing.Size(157, 23);
            this.PinTbox.TabIndex = 1;
            // 
            // ProceedBtn
            // 
            this.ProceedBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProceedBtn.FlatAppearance.BorderSize = 0;
            this.ProceedBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProceedBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProceedBtn.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProceedBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ProceedBtn.Location = new System.Drawing.Point(252, 130);
            this.ProceedBtn.Name = "ProceedBtn";
            this.ProceedBtn.Size = new System.Drawing.Size(112, 40);
            this.ProceedBtn.TabIndex = 2;
            this.ProceedBtn.Text = "PROCEED";
            this.ProceedBtn.UseVisualStyleBackColor = false;
            this.ProceedBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "FAVORITE COLOR";
            // 
            // ColorTbox
            // 
            this.ColorTbox.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorTbox.Location = new System.Drawing.Point(181, 67);
            this.ColorTbox.Name = "ColorTbox";
            this.ColorTbox.Size = new System.Drawing.Size(157, 23);
            this.ColorTbox.TabIndex = 4;
            // 
            // BACKUP
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(394, 216);
            this.Controls.Add(this.ColorTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProceedBtn);
            this.Controls.Add(this.PinTbox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "BACKUP";
            this.Opacity = 0.8D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BACKUP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PinTbox;
        private System.Windows.Forms.Button ProceedBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ColorTbox;
    }
}