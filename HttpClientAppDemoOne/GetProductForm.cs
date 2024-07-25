using HttpClientAppDemoOne.Entity;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;
using static HttpClientAppDemoOne.GetProductForm;

namespace HttpClientAppDemoOne
{
    public partial class GetProductForm : Form
    {
        public GetProductForm()
        {
            InitializeComponent();
        }

        private async Task DeleteProduct(int productId)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", TokenClass.Token);

                StringContent stringContent = new StringContent($"{{\r\n  \"product_id\": \"{productId}\"\r\n}}", Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync("https://apidemo.eticaret.deha.dev/api/seller/product/delete", stringContent);
                response.EnsureSuccessStatusCode();
            }
        }

        private async Task UpdateProduct(int productId, string stockcode, string name, string stock, string description, string unit, double sale_price, double vat, double discount, string currency)
        {
            using (HttpClient httpClient = new HttpClient())
            {

                httpClient.DefaultRequestHeaders.Add("Authorization", TokenClass.Token);
                var jsonData = new
                {
                    product_id = productId,
                    stockcode = stockcode,
                    name = name,
                    stock = stock,
                    description = description,
                    unit = unit,
                    sale_price = sale_price,
                    vat = vat,
                    discount = discount,
                    currency = currency
                };

                string jsonString = JsonConvert.SerializeObject(jsonData);
                StringContent stringContent = new StringContent(jsonString, Encoding.UTF8, "application/json");

                try
                {
                    var response = await httpClient.PostAsync("https://apidemo.eticaret.deha.dev/api/seller/product/update", stringContent);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Product updated successfully.");
                    }
                    else
                    {
                        string errorMessage = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Update failed. Status code: {response.StatusCode}. Response: {errorMessage}");
                    }
                }
                catch (HttpRequestException e)
                {
                    MessageBox.Show($"Request error: {e.Message}");
                }
                catch (JsonException e)
                {
                    MessageBox.Show($"JSON error: {e.Message}");
                }
            }
            RefreshDatagrid();
        }


        private async Task<List<Product>> GetProducts()
        {

            var products = new List<Product>();
            using (HttpClient httpClient = new HttpClient())
            {
                int total = 0;
                int seen = 0;
                int pageSize = 10; // Sayfa baþýna ürün sayýsýný belirliyoruz
                int currentPage = 1;

                do
                {

                    var response = await httpClient.GetAsync($"https://apidemo.eticaret.deha.dev/api/products?page={currentPage}");
                    var responseString = await response.Content.ReadAsStringAsync();
                    //MessageBox.Show("API Response: " + responseString); // Yanýtý bir MessageBox'ta gösteriyoruz


                    dynamic? result = JsonConvert.DeserializeObject(responseString);
                    if (result != null && result.error != null && (bool)result.error)
                    {
                        //  MessageBox.Show($"API Error: {result.error}");
                        //  MessageBox.Show($"Message: {result.message}");
                        break;
                    }

                    // Yanýtýn beklenen veriyi içerip içermediðini kontrol et
                    total = result.total != null ? (int)result.total : 0;
                    seen += result.seen != null ? (int)result.seen : 0;
                    currentPage = result.current_page != null ? (int)result.current_page + 1 : currentPage + 1;

                    if (result.products != null && result.products.Count > 0)
                    {
                        foreach (var item in result.products)
                        {
                            products.Add(new Product()
                            {
                                ProductId = item.product_id != null ? (int)item.product_id : 0,
                                StockCode = item.stockcode != null ? (string)item.stockcode : string.Empty,
                                ProductName = item.name != null ? (string)item.name : string.Empty,
                                Stock = item.stock != null ? (string)item.stock : string.Empty,
                                ImageUrl = item.image != null ? (string)item.image : string.Empty,
                                Description = item.description != null ? (string)item.description : string.Empty,
                                Unit = item.unit != null && item.unit.name != null ? (string)item.unit.name : string.Empty,
                                SalePrice = item.price != null && item.price.sale_price != null ? (double)item.price.sale_price : 0.0,
                                VAT = item.price != null && item.price.vat != null ? (double)item.price.vat : 0.0,
                                Discount = item.price != null && item.price.discount != null ? (double)item.price.discount : 0.0,
                                DiscountPrice = item.price != null && item.price.discount_price != null ? (double)item.price.discount_price : 0.0,
                                Currency = item.price != null && item.price.currency != null ? (string)item.price.currency : string.Empty,
                            });
                        }
                    }
                    else
                    {
                        MessageBox.Show("No products found in the response.");
                    }


                } while (total > seen);
            }

            return products;

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = await GetProducts();
        }

        private void tbDiscount_TextChanged(object sender, EventArgs e)
        {
            double discount;
            Double.TryParse(tbDiscount.Text, out discount);
            if (tbDiscount.Text == null)
                discount = 0;
            tbDiscountPrice.Text = (Double.Parse(tbSalePrice.Text) * (1 - (discount / 100))).ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //cells deðerleri bir arttýrýldý
            tbProductId.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbStockCode.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            tbProductName.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tbStock.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            pbImage.ImageLocation = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            tbDescription.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            tbUnit.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            tbSalePrice.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            tbVat.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            tbDiscount.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            tbDiscountPrice.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            tbCurrency.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();

        }
        private async void RefreshDatagrid()
        {
            dataGridView1.DataSource = await GetProducts();
            dataGridView1.Refresh();

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            await DeleteProduct(int.Parse(tbProductId.Text));
            RefreshDatagrid();
        }




        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                await UpdateProduct(
                    int.Parse(tbProductId.Text),
                    tbStockCode.Text,
                    tbProductName.Text,
                    tbStock.Text,
                    tbDescription.Text,
                    tbUnit.Text,
                    double.Parse(tbSalePrice.Text),
                    double.Parse(tbVat.Text),
                    double.Parse(tbDiscount.Text),
                    tbCurrency.Text
                );


                RefreshDatagrid();
            }
            catch (FormatException fe)
            {
                MessageBox.Show($"Input format error: {fe.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetUserForm getUserForm = new GetUserForm();
            getUserForm.Show();
            this.Hide();

        }
    }
}
