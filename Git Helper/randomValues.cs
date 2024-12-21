using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCLX
{
    public partial class randomValues : Form
    {
        public randomValues()
        {
            InitializeComponent();
        }

        private void randomValues_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
          
            //check if the value is empty
            if (countValue.Text == "")
            {
                MessageBox.Show("Please enter a value");
                return;
            }
            //convert string to int
            hexValue.Text = RandomString(Convert.ToInt32(countValue.Text));
            bytesValue.Text = RandomBytes(Convert.ToInt32(countValue.Text));
            numberValues.Text = RandomNumber(Convert.ToInt32(countValue.Text));



        }

        private string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789aqwertyuiopasdfghjklzxcvbnm";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string RandomNumber(int length)
        {
            const string chars = "0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private string RandomBytes(int length)
        {
            const string chars = "0123456789ABCDEF";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
