using HttpClientAppDemoOne.Entity;
using HttpClientAppDemoOne.Entity.Users;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpClientAppDemoOne
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public async Task<bool> LoginControl(string email, string password)
        {
            string _token = string.Empty;
            string _tokenType = string.Empty;

            var loginInfo = new
            {
                email = email,
                password = password
            };
            var json = JsonConvert.SerializeObject(loginInfo);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                var response = await client.PostAsync("https://apidemo.eticaret.deha.dev/api/login", data);
                if (!response.IsSuccessStatusCode)
                {
                    return (false);
                }
                var devam = await response.Content.ReadAsStringAsync();
                var responseObject = JsonConvert.DeserializeObject<ApiResponse>(devam);


                if (responseObject != null && responseObject.error == false)
                {
                    TokenClass.Token = $"{responseObject.tokenType} {responseObject.token}";
                    return (true);
                }
            }
            return false;

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            var email = tbMail.Text;
            var password = tbPassword.Text;
            var isValid = await LoginControl(email, password);

            if (isValid)
            {
                MessageBox.Show("Giriş Başarılı");

                GetUserForm getUserForm = new GetUserForm();
                getUserForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Giriş Başarısız");
            }


        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }



        private void btnUserRegister_Click(object sender, EventArgs e)
        {
            UserRegisterForm userRegisterForm = new UserRegisterForm();
            userRegisterForm.Show();
            this.Hide();
        }

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm forgotPasswordForm = new ForgotPasswordForm();
            forgotPasswordForm.Show();
            this.Hide();
        }
    }
}
