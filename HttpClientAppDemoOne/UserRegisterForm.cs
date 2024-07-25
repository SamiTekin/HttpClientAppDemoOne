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

namespace HttpClientAppDemoOne;

public partial class UserRegisterForm : Form
{
    public UserRegisterForm()
    {
        InitializeComponent();
    }

    public async Task UserRegister()
    {
        if (string.IsNullOrWhiteSpace(tbName.Text) ||
            string.IsNullOrEmpty(tbsurname.Text) ||
                string.IsNullOrWhiteSpace(tbPassword.Text)||
                string.IsNullOrWhiteSpace(tbEmail.Text)||
                string.IsNullOrWhiteSpace(tbPhone.Text)||
                string.IsNullOrWhiteSpace(tbCountry.Text)||
                string.IsNullOrWhiteSpace(tbDistrict.Text)||
                string.IsNullOrWhiteSpace(tbStreet.Text)||
                string.IsNullOrWhiteSpace(tbCity.Text)||
                string.IsNullOrWhiteSpace(tbNeighborhood.Text)||
                string.IsNullOrWhiteSpace(tbPostalCode.Text))
        {
            MessageBox.Show("Alanlar boş bırakılamaz");
            return;
        }
        var userRegister = new UserRegister
        {
            identity_number = 18529299999,
            tax_number = 1,
            tax_office = "esenler",
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
        var json = JsonConvert.SerializeObject(userRegister);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        Debug.WriteLine("JSON Payload: " + json);

        var request = new HttpRequestMessage(HttpMethod.Post, "https://apidemo.eticaret.deha.dev/api/register")
        {
            Content = data
        };

        var response = await client.SendAsync(request);
        if (response.IsSuccessStatusCode)
        {
            MessageBox.Show(await response.Content.ReadAsStringAsync());
            LoginForm form2 = new LoginForm();
            form2.Show();
            this.Hide();
        }
        else
        {
            var errorMessage = await response.Content.ReadAsStringAsync();
            MessageBox.Show($"Error: {errorMessage}");


        }
    }

    private async void btnUserRegister_Click(object sender, EventArgs e)
    {
        await UserRegister();
        
    }

    private void btnBack_Click(object sender, EventArgs e)
    {
        LoginForm form2 = new LoginForm();
        form2.Show();
        this.Hide();
    }
}
