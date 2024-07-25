namespace HttpClientAppDemoOne
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            label1 = new Label();
            tbName = new TextBox();
            label2 = new Label();
            tbDescription = new TextBox();
            label3 = new Label();
            tbStockCode = new TextBox();
            label4 = new Label();
            tbStock = new TextBox();
            label5 = new Label();
            tbBarcode = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbVat = new TextBox();
            label9 = new Label();
            tbBuyPrice = new TextBox();
            label10 = new Label();
            label11 = new Label();
            tbDiscount = new TextBox();
            tbSalePrice = new TextBox();
            label12 = new Label();
            cbCategory = new ComboBox();
            label13 = new Label();
            cbCurrency = new ComboBox();
            cbWarranty = new ComboBox();
            cbUnit = new ComboBox();
            btnAdded = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Adı";
            // 
            // tbName
            // 
            tbName.Location = new Point(12, 31);
            tbName.Name = "tbName";
            tbName.Size = new Size(100, 23);
            tbName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 0;
            label2.Text = "Açklaması";
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(12, 85);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(100, 23);
            tbDescription.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 127);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 0;
            label3.Text = "Stok Kodu";
            // 
            // tbStockCode
            // 
            tbStockCode.Location = new Point(12, 149);
            tbStockCode.Name = "tbStockCode";
            tbStockCode.Size = new Size(100, 23);
            tbStockCode.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 181);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 0;
            label4.Text = "Stok Sayısı";
            // 
            // tbStock
            // 
            tbStock.Location = new Point(12, 203);
            tbStock.Name = "tbStock";
            tbStock.Size = new Size(100, 23);
            tbStock.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 9);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 0;
            label5.Text = "Barkodu";
            // 
            // tbBarcode
            // 
            tbBarcode.Location = new Point(162, 31);
            tbBarcode.Name = "tbBarcode";
            tbBarcode.Size = new Size(100, 23);
            tbBarcode.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(162, 127);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 0;
            label6.Text = "Garanti";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(162, 63);
            label7.Name = "label7";
            label7.Size = new Size(35, 15);
            label7.TabIndex = 0;
            label7.Text = "Birim";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(162, 181);
            label8.Name = "label8";
            label8.Size = new Size(27, 15);
            label8.TabIndex = 0;
            label8.Text = "Kdv";
            // 
            // tbVat
            // 
            tbVat.Location = new Point(162, 203);
            tbVat.Name = "tbVat";
            tbVat.Size = new Size(100, 23);
            tbVat.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(320, 9);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 0;
            label9.Text = "Alış Fiyatı";
            // 
            // tbBuyPrice
            // 
            tbBuyPrice.Location = new Point(320, 31);
            tbBuyPrice.Name = "tbBuyPrice";
            tbBuyPrice.Size = new Size(100, 23);
            tbBuyPrice.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(320, 127);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 0;
            label10.Text = "İskonto Oranı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(320, 63);
            label11.Name = "label11";
            label11.Size = new Size(62, 15);
            label11.TabIndex = 0;
            label11.Text = "Satış Fiyatı";
            // 
            // tbDiscount
            // 
            tbDiscount.Location = new Point(320, 149);
            tbDiscount.Name = "tbDiscount";
            tbDiscount.Size = new Size(100, 23);
            tbDiscount.TabIndex = 1;
            // 
            // tbSalePrice
            // 
            tbSalePrice.Location = new Point(320, 85);
            tbSalePrice.Name = "tbSalePrice";
            tbSalePrice.Size = new Size(100, 23);
            tbSalePrice.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(320, 181);
            label12.Name = "label12";
            label12.Size = new Size(64, 15);
            label12.TabIndex = 0;
            label12.Text = "Para Birimi";
            // 
            // cbCategory
            // 
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(495, 203);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(121, 23);
            cbCategory.TabIndex = 2;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(495, 181);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 0;
            label13.Text = "Kategorisi";
            // 
            // cbCurrency
            // 
            cbCurrency.FormattingEnabled = true;
            cbCurrency.Location = new Point(320, 203);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(121, 23);
            cbCurrency.TabIndex = 2;
            // 
            // cbWarranty
            // 
            cbWarranty.FormattingEnabled = true;
            cbWarranty.Location = new Point(162, 149);
            cbWarranty.Name = "cbWarranty";
            cbWarranty.Size = new Size(121, 23);
            cbWarranty.TabIndex = 2;
            // 
            // cbUnit
            // 
            cbUnit.FormattingEnabled = true;
            cbUnit.Location = new Point(162, 85);
            cbUnit.Name = "cbUnit";
            cbUnit.Size = new Size(121, 23);
            cbUnit.TabIndex = 2;
            // 
            // btnAdded
            // 
            btnAdded.Location = new Point(409, 250);
            btnAdded.Name = "btnAdded";
            btnAdded.Size = new Size(336, 42);
            btnAdded.TabIndex = 3;
            btnAdded.Text = "Ekle";
            btnAdded.UseVisualStyleBackColor = true;
            btnAdded.Click += btnAdded_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.MenuBar;
            btnBack.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnBack.Location = new Point(797, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(87, 32);
            btnBack.TabIndex = 29;
            btnBack.Text = "Geri  <--";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 420);
            Controls.Add(btnBack);
            Controls.Add(btnAdded);
            Controls.Add(cbUnit);
            Controls.Add(cbWarranty);
            Controls.Add(cbCurrency);
            Controls.Add(cbCategory);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(tbVat);
            Controls.Add(label8);
            Controls.Add(tbSalePrice);
            Controls.Add(tbStock);
            Controls.Add(tbDiscount);
            Controls.Add(label4);
            Controls.Add(label11);
            Controls.Add(tbDescription);
            Controls.Add(label7);
            Controls.Add(label10);
            Controls.Add(tbStockCode);
            Controls.Add(label6);
            Controls.Add(tbBuyPrice);
            Controls.Add(label2);
            Controls.Add(tbBarcode);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(tbName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Apidemo";
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbName;
        private Label label2;
        private TextBox tbDescription;
        private Label label3;
        private TextBox tbStockCode;
        private Label label4;
        private TextBox tbStock;
        private Label label5;
        private TextBox tbBarcode;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbVat;
        private Label label9;
        private TextBox tbBuyPrice;
        private Label label10;
        private Label label11;
        private TextBox tbDiscount;
        private TextBox tbSalePrice;
        private Label label12;
        private ComboBox cbCategory;
        private Label label13;
        private ComboBox cbCurrency;
        private ComboBox cbWarranty;
        private ComboBox cbUnit;
        private Button btnAdded;
        private Button btnBack;
    }
}