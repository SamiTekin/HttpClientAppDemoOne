using HttpClientAppDemoOne.Entity;
using HttpClientAppDemoOne.Entity.Users;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpClientAppDemoOne
{
    public partial class UserAddForm : Form
    {
        public UserAddForm()
        {
            InitializeComponent();
        }

        public async Task UserAdd()
        {
            var userUpdate = new UserAdd
            {
                identity_number = 18529299999,
                tax_number = 1,
                tax_office = "esenler",
                status_id = 1,
                name = tbName.Text,
                surname = tbsurname.Text,
                email = tbEmail.Text,
                password = tbPassword.Text,
                address = tbAddress.Text,
                phone = tbPhone.Text,
                country = tbCountry.Text,
                district = tbDistrict.Text,
                street = tbStreet.Text,
                city = tbCity.Text,
                neighborhood = tbNeighborhood.Text,
                postal_code = tbPostalCode.Text,
                note = "not",
            };

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Authorization", TokenClass.Token);
            var json = JsonConvert.SerializeObject(userUpdate);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            Debug.WriteLine("JSON Payload: " + json);

            var request = new HttpRequestMessage(HttpMethod.Post, "https://apidemo.eticaret.deha.dev/api/seller/user/add")
            {
                Content = data
            };

            var response = await client.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(await response.Content.ReadAsStringAsync());
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error: {errorMessage}");


            }
        }

        private async void btnUserAdd_Click(object sender, EventArgs e)
        {
            await UserAdd();
        }
        private void UserAddForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GetUserForm getUserForm = new GetUserForm();
            getUserForm.Show();
            this.Hide();
        }
    }
}
