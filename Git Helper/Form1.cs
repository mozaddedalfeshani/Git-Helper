using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KeyAuth;

namespace Git_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyAuthApp.init();
        }

        public static api KeyAuthApp = new api(
            name: "Imurad12's Application", // App name
            ownerid: "PR8S8Ge7ms", // Account ID
            secret: "885e60b02bc988dad8e5acc8a22e3df8b29580ccb5f444b458c1cf2e6de7032e", // Secret
            version: "1.0"
        );
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                MessageBox.Show("Logged in!");
                timer1.Start();
                
            }
            else
            {
                MessageBox.Show("Failed to login!");
                timer1.Stop();
            }

        }

        private void labelInfo_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void discord_Click(object sender, EventArgs e)
        {
            // click to redirect to discord with my discord server my server link https://discord.gg/EZTx8AvjR9
            System.Diagnostics.Process.Start("https://discord.gg/EZTx8AvjR9");
        }

        private void whatsapp_Click(object sender, EventArgs e)
        {
            // here click to redirect to whatsapp with my whatsapp number +8801755267077
            System.Diagnostics.Process.Start("https://wa.me/+8801755267077");
        }
    }
}
