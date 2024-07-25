namespace HttpClientAppDemoOne
{
    partial class GetUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetUserForm));
            btnUpdateUser = new Button();
            btnUserAdd = new Button();
            btnGotoAddProduct = new Button();
            btnGotoProduct = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.BackColor = SystemColors.MenuBar;
            btnUpdateUser.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUpdateUser.Location = new Point(640, 130);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(110, 23);
            btnUpdateUser.TabIndex = 16;
            btnUpdateUser.Text = "Kullanıcı Güncelle";
            btnUpdateUser.UseVisualStyleBackColor = false;
            btnUpdateUser.Click += btnUpdateUser_Click_1;
            // 
            // btnUserAdd
            // 
            btnUserAdd.BackColor = SystemColors.MenuBar;
            btnUserAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnUserAdd.Location = new Point(756, 130);
            btnUserAdd.Name = "btnUserAdd";
            btnUserAdd.Size = new Size(105, 23);
            btnUserAdd.TabIndex = 17;
            btnUserAdd.Text = "Kullanıcı Ekle";
            btnUserAdd.UseVisualStyleBackColor = false;
            btnUserAdd.Click += btnUserAdd_Click_1;
            // 
            // btnGotoAddProduct
            // 
            btnGotoAddProduct.BackColor = SystemColors.MenuBar;
            btnGotoAddProduct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGotoAddProduct.Location = new Point(718, 369);
            btnGotoAddProduct.Name = "btnGotoAddProduct";
            btnGotoAddProduct.Size = new Size(156, 39);
            btnGotoAddProduct.TabIndex = 15;
            btnGotoAddProduct.Text = "Ürün Ekle";
            btnGotoAddProduct.UseVisualStyleBackColor = false;
            btnGotoAddProduct.Click += btnGotoAddProduct_Click_1;
            // 
            // btnGotoProduct
            // 
            btnGotoProduct.BackColor = SystemColors.MenuBar;
            btnGotoProduct.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnGotoProduct.Location = new Point(564, 369);
            btnGotoProduct.Name = "btnGotoProduct";
            btnGotoProduct.Size = new Size(148, 39);
            btnGotoProduct.TabIndex = 14;
            btnGotoProduct.Text = "Ürünler";
            btnGotoProduct.UseVisualStyleBackColor = false;
            btnGotoProduct.Click += btnGotoProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(2, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(869, 97);
            dataGridView1.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Left;
            label1.Font = new Font("Rockwell", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(250, 39);
            label1.TabIndex = 18;
            label1.Text = "HOŞGELDİNİZ";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = SystemColors.MenuBar;
            btnLogout.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLogout.Location = new Point(738, 7);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(148, 39);
            btnLogout.TabIndex = 19;
            btnLogout.Text = "Çıkış Yap";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // GetUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 420);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnUserAdd);
            Controls.Add(btnGotoAddProduct);
            Controls.Add(btnGotoProduct);
            Controls.Add(dataGridView1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "GetUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apidemo";
            Load += GetUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdateUser;
        private Button btnUserAdd;
        private Button btnGotoAddProduct;
        private Button btnGotoProduct;
        private DataGridView dataGridView1;
        private Label label1;
        private Button btnLogout;
    }
}