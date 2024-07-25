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

    public partial class ForgotPasswordForm : Form
    {
        public ForgotPasswordForm()
        {
            InitializeComponent();
        }
        public class ForgotMail
        {
            public string email { get; set; }
            public string token { get; set; }
            public string password { get; set; }
            public string passwordConfirmation { get; set; }
        }

        public async Task ForgotPassword()
        {
            if (string.IsNullOrWhiteSpace(tbMailContent.Text))
            {
                MessageBox.Show("Bu alan boş bırakılamaz");
                return;
            }
            var fargotMail = new ForgotMail
            {
                email = tbMailContent.Text
            };
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(fargotMail);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            Debug.WriteLine("Json Payolad:" + json);
            var request = new HttpRequestMessage(HttpMethod.Post, "https://apidemo.eticaret.deha.dev/api/forgot-password")
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
                MessageBox.Show($"Error:{errorMessage}");
            }
        }
        public async Task ResetPassword()
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text) ||
                string.IsNullOrWhiteSpace(tbCodeVerification.Text) ||
                string.IsNullOrWhiteSpace(tbNewPassword.Text) ||
                string.IsNullOrWhiteSpace(tbPasswordConfirmation.Text))
            {
                MessageBox.Show("Bu alanlar boş bırakılamaz");
                return;
            }
            var resetPassword = new ForgotMail
            {
                email = tbEmail.Text,
                token = tbCodeVerification.Text,
                password = tbNewPassword.Text,
                passwordConfirmation = tbPasswordConfirmation.Text,
            };
            var client = new HttpClient();
            var json = JsonConvert.SerializeObject(resetPassword);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            Debug.WriteLine("Json Payload" + json);

            var request = new HttpRequestMessage(HttpMethod.Post, "https://apidemo.eticaret.deha.dev/api/reset-password")
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
                MessageBox.Show($"Error:{errorMessage}");
            }

        }

        private async void btnForgotPassword_Click(object sender, EventArgs e)
        {

            await ForgotPassword();
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            tbEmail.Visible = true;
            tbCodeVerification.Visible = true;
            tbNewPassword.Visible = true;
            tbPasswordConfirmation.Visible = true;
            btnSave.Visible = true;
            //label1.Visible = false;
            //tbMailContent.Visible = false;
            //btnForgotPassword.Visible = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            await ResetPassword();
        }

        private void ForgotPasswordForm_Load(object sender, EventArgs e)
        {
            // label2.Visible = false;
            //label3.Visible = false;
            //label4.Visible = false;
            //label5.Visible = false;
            //tbEmail.Visible = false;
            //tbCodeVerification.Visible = false;
            //tbNewPassword.Visible = false;
            //tbPasswordConfirmation.Visible = false;
            //btnSave.Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
