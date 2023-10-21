namespace WinFormsApp1
{
    partial class frm_login
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
            lb_username = new Label();
            lb_password = new Label();
            txt_userName = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_close = new Button();
            SuspendLayout();
            // 
            // lb_username
            // 
            lb_username.AutoSize = true;
            lb_username.Location = new Point(53, 43);
            lb_username.Name = "lb_username";
            lb_username.Size = new Size(99, 25);
            lb_username.TabIndex = 0;
            lb_username.Text = "User Name";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Location = new Point(65, 104);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(87, 25);
            lb_password.TabIndex = 0;
            lb_password.Text = "Password";
            // 
            // txt_userName
            // 
            txt_userName.Location = new Point(194, 43);
            txt_userName.Name = "txt_userName";
            txt_userName.Size = new Size(313, 31);
            txt_userName.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(194, 98);
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "enter password";
            txt_password.Size = new Size(313, 31);
            txt_password.TabIndex = 2;
            txt_password.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(218, 159);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(107, 36);
            btn_login.TabIndex = 3;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(350, 159);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(107, 36);
            btn_close.TabIndex = 3;
            btn_close.Text = "Cancel";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 271);
            Controls.Add(btn_close);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_userName);
            Controls.Add(lb_password);
            Controls.Add(lb_username);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_login";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_username;
        private Label lb_password;
        private TextBox txt_userName;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_close;
    }
}