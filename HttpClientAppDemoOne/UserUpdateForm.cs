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
    public partial class UserUpdateForm : Form
    {
        public List<UserGet.User> Users = new List<UserGet.User>();
        public UserUpdateForm()
        {
            InitializeComponent();

        }

        public async Task UserUpdate()
        {
            if (Users.Count > 0)
            {
                var userUpdate = new UserUpdate
                {
                   // id = Users.FirstOrDefault().id,
                    name = tbName.Text,
                    email = tbEmail.Text,
                    surname=tbSurName.Text,
                   // status_id = Users.FirstOrDefault().status_id
                };
                //

                using(HttpClient httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Add("Authorization", TokenClass.Token);
                    var json= JsonConvert.SerializeObject(userUpdate);
                    var data=new StringContent(json, Encoding.UTF8, "application/json");
                    Debug.WriteLine("Json Payload"+json);
                    var request = new HttpRequestMessage(HttpMethod.Post, "https://apidemo.eticaret.deha.dev/api/user/update")
                    {
                        Content = data
                    };
                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show(await response.Content.ReadAsStringAsync());
                        GetUserForm getUserForm = new GetUserForm();
                        getUserForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        var errorMessage= await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"{errorMessage}");
                    }
                }

            }
        }
        public async Task ChangePassword()
        {
            if (string.IsNullOrWhiteSpace(tbOldPassword.Text) ||
                string.IsNullOrWhiteSpace(tbNewPassword.Text) ||
                string.IsNullOrWhiteSpace(tbNewPasswordConfirmation.Text))
            {
                MessageBox.Show("bu alanlar boş geçilemez");
                return;
            }
            var changePassword = new ChangePassowords
            {
                oldPassword = tbOldPassword.Text,
                password = tbNewPassword.Text,
                passwordConfirmation = tbNewPasswordConfirmation.Text,
            };
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add("Authorization", TokenClass.Token);
            var json = JsonConvert.SerializeObject(changePassword);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            Debug.WriteLine("Json Payload " + json);
            var request = new HttpRequestMessage(HttpMethod.Post, "https://apidemo.eticaret.deha.dev/api/change-password")
            {
                Content = data
            };
            var response = await httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show(await response.Content.ReadAsStringAsync());
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                MessageBox.Show($"Error:{errorMessage}");
            }
        }


        private void UserUpdateForm_Load(object sender, EventArgs e)
        {
            //UserUpdate();
            tbName.Text = Users.FirstOrDefault().name;
            tbSurName.Text = Users.FirstOrDefault().surname;
            tbEmail.Text = Users.FirstOrDefault().email;

        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
           await UserUpdate();
        }

        private async void btnNewPasswordSave_Click(object sender, EventArgs e)
        {
            await ChangePassword();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GetUserForm getUserForm = new GetUserForm();
            getUserForm.Show();
            this.Hide();
        }
    }
}
