using HttpClientAppDemoOne.Entity;
using HttpClientAppDemoOne.Entity.InsertProduct;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpClientAppDemoOne
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private async Task<string> GetBase64StringFromUrl(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var imageBytes = await httpClient.GetByteArrayAsync(url);
                return Convert.ToBase64String(imageBytes);
            }
        }

        public async Task AddProduct()
        {
            var imageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRgNGdH6wUBTLeEpqTb-53rFi3FoaGBJywyEA&s";
            var base64Image = await GetBase64StringFromUrl(imageUrl);
            var product = new Root
            {
                unique = "1", // Örnek bir değer
                name = tbName.Text,
                description = tbDescription.Text,
                buy_price = tbBuyPrice.Text,
                sale_price = tbSalePrice.Text,
                currency_id = cbCurrency.SelectedItem?.ToString(),
                vat = tbVat.Text,
                discount = tbDiscount.Text,
                vat_included = "0", // Null olarak ayarladık
                stock = tbStock.Text,
                barcode = tbBarcode.Text,
                slug = "slug-metni", // Null olarak ayarladık
                stockcode = tbStockCode.Text,
                unit_id = (cbUnit.SelectedItem as ComboBoxItem)?.Value,
                brand_id = null, // Null olarak ayarladık
                warranty_id = (cbWarranty.SelectedItem as ComboBoxItem)?.Value,
                category_ids = new List<string> { (cbCategory.SelectedItem as ComboBoxItem)?.Value },
                product_images = new List<string> { base64Image },
                seo_informations = new SeoInformations
                {
                    seo_title = "SEO Başlığı",
                    seo_description = "SEO Açıklaması",
                    seo_keywords = "SEO Anahtar Kelimeleri"
                }, // Null olarak ayarladık
                special_area_values = new List<SpecialAreaValue>
                {
                    new SpecialAreaValue { id = "Özel Alan ID", value = "Değer" }
                } // Null olarak ayarladık
            };

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", TokenClass.Token);
                var requestUrl = "https://apidemo.eticaret.deha.dev/api/seller/product/add";

                var json = JsonConvert.SerializeObject(product);
                var data = new StringContent(json, Encoding.UTF8, "application/json");

                try
                {
                    var response = await client.PostAsync(requestUrl, data);

                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Ürün başarıyla eklendi.\nFiyatlar: " +
                                   $"\nAlış Fiyatı: {product.buy_price}" +
                                   $"\nSatış Fiyatı: {product.sale_price}");
                    }
                    else
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Error: {response.StatusCode}\nMessage: {result}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Exception: {ex.Message}");
                }
            }
        }
        private void LoadComboBoxes()
        {
            cbCurrency.Items.Add(new ComboBoxItem { Text = "TL", Value = "1" });
            cbCurrency.Items.Add(new ComboBoxItem { Text = "USD", Value = "2" });
            cbCurrency.Items.Add(new ComboBoxItem { Text = "EURO", Value = "3" });

            cbUnit.Items.Add(new ComboBoxItem { Text = "Adet", Value = "1" });


            cbWarranty.Items.Add(new ComboBoxItem { Text = "3 Aylık Garanti", Value = "1" });
            cbWarranty.Items.Add(new ComboBoxItem { Text = "6 Aylık Garanti", Value = "2" });
            cbWarranty.Items.Add(new ComboBoxItem { Text = "9 Aylık Garanti", Value = "3" });
            cbWarranty.Items.Add(new ComboBoxItem { Text = "12 Aylık Garanti", Value = "4" });

            cbCategory.Items.Add(new ComboBoxItem { Text = "Kategori 1", Value = "1" });
            cbCategory.Items.Add(new ComboBoxItem { Text = "Kategori 2", Value = "2" });
        }




        private async void btnAdded_Click(object sender, EventArgs e)
        {
            await AddProduct();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GetUserForm getUserForm = new GetUserForm();
            getUserForm.Show();
            this.Hide();
        }
    }
}
