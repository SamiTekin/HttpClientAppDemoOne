namespace HttpClientAppDemoOne
{
    partial class UserUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUpdateForm));
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            tbEmail = new TextBox();
            label3 = new Label();
            tbSurName = new TextBox();
            btnUpdate = new Button();
            btnNewPasswordSave = new Button();
            tbNewPasswordConfirmation = new TextBox();
            lblYeniSifreTekrar = new Label();
            tbOldPassword = new TextBox();
            tbNewPassword = new TextBox();
            lblEskiSifre = new Label();
            lblYeniSifre = new Label();
            lblSifreSifirla = new Label();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 27);
            tbName.Name = "tbName";
            tbName.Size = new Size(132, 23);
            tbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(314, 9);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 0;
            label2.Text = "E Posta";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(314, 27);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(132, 23);
            tbEmail.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(162, 9);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 0;
            label3.Text = "Soy İsim";
            // 
            // tbSurName
            // 
            tbSurName.Location = new Point(162, 27);
            tbSurName.Name = "tbSurName";
            tbSurName.Size = new Size(132, 23);
            tbSurName.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.MenuBar;
            btnUpdate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdate.Location = new Point(359, 56);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 23);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNewPasswordSave
            // 
            btnNewPasswordSave.BackColor = SystemColors.MenuBar;
            btnNewPasswordSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNewPasswordSave.Location = new Point(148, 299);
            btnNewPasswordSave.Name = "btnNewPasswordSave";
            btnNewPasswordSave.Size = new Size(90, 23);
            btnNewPasswordSave.TabIndex = 19;
            btnNewPasswordSave.Text = "Kaydet";
            btnNewPasswordSave.UseVisualStyleBackColor = false;
            btnNewPasswordSave.Click += btnNewPasswordSave_Click;
            // 
            // tbNewPasswordConfirmation
            // 
            tbNewPasswordConfirmation.Location = new Point(20, 270);
            tbNewPasswordConfirmation.Name = "tbNewPasswordConfirmation";
            tbNewPasswordConfirmation.Size = new Size(213, 23);
            tbNewPasswordConfirmation.TabIndex = 16;
            // 
            // lblYeniSifreTekrar
            // 
            lblYeniSifreTekrar.AutoSize = true;
            lblYeniSifreTekrar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblYeniSifreTekrar.Location = new Point(20, 252);
            lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            lblYeniSifreTekrar.Size = new Size(94, 15);
            lblYeniSifreTekrar.TabIndex = 12;
            lblYeniSifreTekrar.Text = "Yeni Şifre Tekrar ";
            // 
            // tbOldPassword
            // 
            tbOldPassword.Location = new Point(20, 178);
            tbOldPassword.Name = "tbOldPassword";
            tbOldPassword.Size = new Size(213, 23);
            tbOldPassword.TabIndex = 17;
            // 
            // tbNewPassword
            // 
            tbNewPassword.Location = new Point(20, 226);
            tbNewPassword.Name = "tbNewPassword";
            tbNewPassword.Size = new Size(213, 23);
            tbNewPassword.TabIndex = 18;
            // 
            // lblEskiSifre
            // 
            lblEskiSifre.AutoSize = true;
            lblEskiSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblEskiSifre.Location = new Point(22, 160);
            lblEskiSifre.Name = "lblEskiSifre";
            lblEskiSifre.Size = new Size(54, 15);
            lblEskiSifre.TabIndex = 13;
            lblEskiSifre.Text = "Eski Şifre";
            // 
            // lblYeniSifre
            // 
            lblYeniSifre.AutoSize = true;
            lblYeniSifre.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            lblYeniSifre.Location = new Point(20, 208);
            lblYeniSifre.Name = "lblYeniSifre";
            lblYeniSifre.Size = new Size(56, 15);
            lblYeniSifre.TabIndex = 14;
            lblYeniSifre.Text = "Yeni Şifre";
            // 
            // lblSifreSifirla
            // 
            lblSifreSifirla.AutoSize = true;
            lblSifreSifirla.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblSifreSifirla.Location = new Point(18, 130);
            lblSifreSifirla.Name = "lblSifreSifirla";
            lblSifreSifirla.Size = new Size(94, 21);
            lblSifreSifirla.TabIndex = 15;
            lblSifreSifirla.Text = "Şifre Sıfırla";
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.MenuBar;
            btnBack.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBack.Location = new Point(795, 1);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(87, 32);
            btnBack.TabIndex = 20;
            btnBack.Text = "Geri  <--";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // UserUpdateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(883, 420);
            Controls.Add(btnBack);
            Controls.Add(btnNewPasswordSave);
            Controls.Add(tbNewPasswordConfirmation);
            Controls.Add(lblYeniSifreTekrar);
            Controls.Add(tbOldPassword);
            Controls.Add(tbNewPassword);
            Controls.Add(lblEskiSifre);
            Controls.Add(lblYeniSifre);
            Controls.Add(lblSifreSifirla);
            Controls.Add(btnUpdate);
            Controls.Add(tbSurName);
            Controls.Add(label3);
            Controls.Add(tbEmail);
            Controls.Add(label2);
            Controls.Add(tbName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserUpdateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apidemo";
            Load += UserUpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private Label label2;
        private TextBox tbEmail;
        private Label label3;
        private TextBox tbSurName;
        private Button btnUpdate;
        private Button btnNewPasswordSave;
        private TextBox tbNewPasswordConfirmation;
        private Label lblYeniSifreTekrar;
        private TextBox tbOldPassword;
        private TextBox tbNewPassword;
        private Label lblEskiSifre;
        private Label lblYeniSifre;
        private Label lblSifreSifirla;
        private Button btnBack;
    }
}