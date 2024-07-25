using HttpClientAppDemoOne.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpClientAppDemoOne
{
    public partial class GetUserForm : Form
    {
        public GetUserForm()
        {
            InitializeComponent();
        }

        List<UserGet.User> users = new List<UserGet.User>();
        public async Task<List<UserGet.User>> GetUsers()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, "https://apidemo.eticaret.deha.dev/api/user/get");
                if (!string.IsNullOrEmpty(TokenClass.Token))
                {

                    request.Headers.Add("Authorization", TokenClass.Token);

                }

                var response = await httpClient.SendAsync(request);
                response.EnsureSuccessStatusCode();
                var result = JsonConvert.DeserializeObject<UserGet.Root>(await response.Content.ReadAsStringAsync());


                if (result != null && result.error == false)
                    users.Add(new UserGet.User
                    {
                        name = result.user.name,
                        surname = result.user.surname,
                        email = result.user.email,
                        company = result.user.company,
                        date_of_birth = result.user.date_of_birth,
                        id = result.user.id,
                        identity_number = result.user.identity_number,
                        phone = result.user.phone,
                        tax_number = result.user.tax_number,
                        tax_office = result.user.tax_office
                    });
            }
            return users;
        }
        public async void Logout()
        {
            using HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://apidemo.eticaret.deha.dev/api/logout");
            request.Headers.Add("Authorization", TokenClass.Token);
            var response = await client.SendAsync(request);
            Console.WriteLine(await response.Content.ReadAsStringAsync());

        }


        private async void GetUserForm_Load(object sender, EventArgs e)
        {
            var users = await GetUsers();
            dataGridView1.DataSource = users;
        }

        private void btnUpdateUser_Click_1(object sender, EventArgs e)
        {
            UserUpdateForm userUpdateForm = new UserUpdateForm();
            userUpdateForm.Users = users;
            userUpdateForm.Show();
            this.Hide();
        }

        private void btnUserAdd_Click_1(object sender, EventArgs e)
        {
            UserAddForm userAddForm = new UserAddForm();
            userAddForm.Show();
            this.Hide();
        }

        private void btnGotoAddProduct_Click_1(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Show();
            this.Hide();
        }

        private void btnGotoProduct_Click(object sender, EventArgs e)
        {
            GetProductForm form1 = new GetProductForm();
            form1.Show();
            this.Hide();
        }

        private async void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
