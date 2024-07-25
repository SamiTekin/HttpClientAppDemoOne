namespace HttpClientAppDemoOne
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            tbMail = new TextBox();
            tbPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            btnForgotPassword = new Button();
            btnUserRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(208, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 1;
            label1.Text = "Mail";
            // 
            // tbMail
            // 
            tbMail.BackColor = SystemColors.Window;
            tbMail.Location = new Point(208, 33);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(402, 23);
            tbMail.TabIndex = 2;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.Window;
            tbPassword.Location = new Point(208, 94);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(402, 23);
            tbPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(210, 71);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.MenuBar;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnLogin.Location = new Point(220, 136);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(106, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = SystemColors.MenuBar;
            btnForgotPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnForgotPassword.Location = new Point(347, 136);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(121, 23);
            btnForgotPassword.TabIndex = 7;
            btnForgotPassword.Text = "Şifremi Unuttum";
            btnForgotPassword.UseVisualStyleBackColor = false;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // btnUserRegister
            // 
            btnUserRegister.BackColor = SystemColors.MenuBar;
            btnUserRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUserRegister.Location = new Point(495, 136);
            btnUserRegister.Name = "btnUserRegister";
            btnUserRegister.Size = new Size(115, 23);
            btnUserRegister.TabIndex = 8;
            btnUserRegister.Text = "Kayıt Ol";
            btnUserRegister.UseVisualStyleBackColor = false;
            btnUserRegister.Click += btnUserRegister_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(883, 420);
            Controls.Add(btnUserRegister);
            Controls.Add(btnForgotPassword);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(tbPassword);
            Controls.Add(tbMail);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apidemo";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tbMail;
        private TextBox tbPassword;
        private Label label2;
        private Button btnLogin;
        private Button btnForgotPassword;
        private Button btnUserRegister;
    }
}