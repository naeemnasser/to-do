namespace to_do
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LoginBtn = new System.Windows.Forms.Button();
            this.ClrBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.AdminBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginBtn.Location = new System.Drawing.Point(642, 534);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(218, 91);
            this.LoginBtn.TabIndex = 0;
            this.LoginBtn.Text = "LOGIN";
            this.LoginBtn.UseVisualStyleBackColor = false;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // ClrBtn
            // 
            this.ClrBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClrBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ClrBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClrBtn.Location = new System.Drawing.Point(383, 534);
            this.ClrBtn.Name = "ClrBtn";
            this.ClrBtn.Size = new System.Drawing.Size(229, 91);
            this.ClrBtn.TabIndex = 0;
            this.ClrBtn.Text = "CLEAR";
            this.ClrBtn.UseVisualStyleBackColor = false;
            this.ClrBtn.Click += new System.EventHandler(this.ClrBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(874, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "                           TO DO LIST";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(874, 60);
            this.label2.TabIndex = 2;
            this.label2.Text = "                               LOGIN";
            // 
            // PassBox
            // 
            this.PassBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PassBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassBox.Location = new System.Drawing.Point(383, 354);
            this.PassBox.Name = "PassBox";
            this.PassBox.Size = new System.Drawing.Size(260, 31);
            this.PassBox.TabIndex = 4;
            // 
            // AdminBox
            // 
            this.AdminBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AdminBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminBox.Location = new System.Drawing.Point(383, 242);
            this.AdminBox.Name = "AdminBox";
            this.AdminBox.Size = new System.Drawing.Size(260, 31);
            this.AdminBox.TabIndex = 5;
            this.AdminBox.TextChanged += new System.EventHandler(this.AdminBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(106, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 38);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADMIN";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(106, 347);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 38);
            this.label4.TabIndex = 7;
            this.label4.Text = "PASSWORD";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(872, 657);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AdminBox);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClrBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button LoginBtn;
        private Button ClrBtn;
        private Label label1;
        private Label label2;
        private TextBox PassBox;
        private TextBox AdminBox;
        private Label label3;
        private Label label4;
    }
}