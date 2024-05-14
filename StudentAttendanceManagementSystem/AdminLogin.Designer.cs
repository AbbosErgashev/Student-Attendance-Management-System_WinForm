namespace BookStoreManagmentSystem
{
    partial class AdminLogin
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
            panel2 = new Panel();
            AdminLink = new Label();
            LoginBtn = new Button();
            UPasswordTb = new TextBox();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(AdminLink);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(UPasswordTb);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(5, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 322);
            panel2.TabIndex = 2;
            // 
            // AdminLink
            // 
            AdminLink.AutoSize = true;
            AdminLink.BackColor = Color.Transparent;
            AdminLink.Cursor = Cursors.Hand;
            AdminLink.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            AdminLink.Location = new Point(258, 243);
            AdminLink.Name = "AdminLink";
            AdminLink.Size = new Size(113, 28);
            AdminLink.TabIndex = 2;
            AdminLink.Text = "Login Page";
            AdminLink.Click += AdminLink_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.Transparent;
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Location = new Point(263, 142);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(109, 47);
            LoginBtn.TabIndex = 1;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UPasswordTb
            // 
            UPasswordTb.Location = new Point(196, 72);
            UPasswordTb.Name = "UPasswordTb";
            UPasswordTb.PasswordChar = '*';
            UPasswordTb.Size = new Size(300, 31);
            UPasswordTb.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 75);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(637, 332);
            Controls.Add(panel2);
            MaximizeBox = false;
            Name = "AdminLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminLogin";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label AdminLink;
        private Button LoginBtn;
        private TextBox UPasswordTb;
        private Label label4;
    }
}