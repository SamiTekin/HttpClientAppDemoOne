namespace HttpClientAppDemoOne
{
    partial class ForgotPasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPasswordForm));
            label1 = new Label();
            tbMailContent = new TextBox();
            btnForgotPassword = new Button();
            label2 = new Label();
            tbCodeVerification = new TextBox();
            label3 = new Label();
            tbEmail = new TextBox();
            label4 = new Label();
            tbNewPassword = new TextBox();
            label5 = new Label();
            tbPasswordConfirmation = new TextBox();
            btnSave = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 0;
            label1.Text = "Mail Adresiniz";
            // 
            // tbMailContent
            // 
            tbMailContent.Location = new Point(12, 27);
            tbMailContent.Name = "tbMailContent";
            tbMailContent.Size = new Size(139, 23);
            tbMailContent.TabIndex = 1;
            // 
            // btnForgotPassword
            // 
            btnForgotPassword.BackColor = SystemColors.MenuBar;
            btnForgotPassword.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnForgotPassword.Location = new Point(115, 56);
            btnForgotPassword.Name = "btnForgotPassword";
            btnForgotPassword.Size = new Size(154, 23);
            btnForgotPassword.TabIndex = 2;
            btnForgotPassword.Text = "Doğrulama Gönder";
            btnForgotPassword.UseVisualStyleBackColor = false;
            btnForgotPassword.Click += btnForgotPassword_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(21, 163);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 0;
            label2.Text = "Doğrulama Kodu";
            // 
            // tbCodeVerification
            // 
            tbCodeVerification.Location = new Point(21, 181);
            tbCodeVerification.Name = "tbCodeVerification";
            tbCodeVerification.Size = new Size(139, 23);
            tbCodeVerification.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(21, 106);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 0;
            label3.Text = "Mail Adresiniz";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(21, 124);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(139, 23);
            tbEmail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(21, 227);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 0;
            label4.Text = "Yeni Şifre";
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(21, 245);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(139, 23);
            tbNewPassword.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(21, 284);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 0;
            label5.Text = "Şifre Tekrar";
            // 
            // tbPasswordConfirmation
            // 
            tbPasswordConfirmation.Location = new Point(21, 302);
            tbPasswordConfirmation.Name = "tbPasswordConfirmation";
            tbPasswordConfirmation.Size = new Size(139, 23);
            tbPasswordConfirmation.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.MenuBar;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSave.Location = new Point(127, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(142, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.MenuBar;
            btnBack.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBack.Location = new Point(794, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(87, 32);
            btnBack.TabIndex = 29;
            btnBack.Text = "Geri  <--";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 420);
            Controls.Add(btnBack);
            Controls.Add(btnSave);
            Controls.Add(btnForgotPassword);
            Controls.Add(tbPasswordConfirmation);
            Controls.Add(label5);
            Controls.Add(tbNewPassword);
            Controls.Add(label4);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(tbCodeVerification);
            Controls.Add(label2);
            Controls.Add(tbMailContent);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apidemo";
            Load += ForgotPasswordForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbMailContent;
        private Button btnForgotPassword;
        private Label label2;
        private TextBox tbCodeVerification;
        private Label label3;
        private TextBox tbEmail;
        private Label label4;
        private TextBox tbNewPassword;
        private Label label5;
        private TextBox tbPasswordConfirmation;
        private Button btnSave;
        private Button btnBack;
    }
}