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
    public partial class StartForm : Form
    {
        int i = 0;
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i != 100)
            {
                i++;
            }
            else
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
