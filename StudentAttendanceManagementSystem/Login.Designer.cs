namespace BookStoreManagmentSystem
{
    partial class Login
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
            UNameTb = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(AdminLink);
            panel2.Controls.Add(LoginBtn);
            panel2.Controls.Add(UPasswordTb);
            panel2.Controls.Add(UNameTb);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(702, 399);
            panel2.TabIndex = 1;
            // 
            // AdminLink
            // 
            AdminLink.AutoSize = true;
            AdminLink.Cursor = Cursors.Hand;
            AdminLink.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 204);
            AdminLink.Location = new Point(267, 304);
            AdminLink.Name = "AdminLink";
            AdminLink.Size = new Size(186, 28);
            AdminLink.TabIndex = 3;
            AdminLink.Text = "Continue as Admin";
            AdminLink.Click += AdminLink_Click;
            // 
            // LoginBtn
            // 
            LoginBtn.Cursor = Cursors.Hand;
            LoginBtn.Location = new Point(308, 220);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(109, 42);
            LoginBtn.TabIndex = 2;
            LoginBtn.Text = "Login";
            LoginBtn.UseVisualStyleBackColor = true;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // UPasswordTb
            // 
            UPasswordTb.Location = new Point(217, 151);
            UPasswordTb.Name = "UPasswordTb";
            UPasswordTb.PasswordChar = '*';
            UPasswordTb.Size = new Size(303, 31);
            UPasswordTb.TabIndex = 1;
            // 
            // UNameTb
            // 
            UNameTb.Location = new Point(217, 87);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(303, 31);
            UNameTb.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(126, 154);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 2;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(123, 90);
            label5.Name = "label5";
            label5.Size = new Size(91, 25);
            label5.TabIndex = 3;
            label5.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            ClientSize = new Size(710, 408);
            Controls.Add(panel2);
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label4;
        private Label label5;
        private Label AdminLink;
        private Button LoginBtn;
        private TextBox UPasswordTb;
        private TextBox UNameTb;
    }
}