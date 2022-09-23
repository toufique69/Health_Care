using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            PasstextBox.PasswordChar = '•';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = "toufique";
            int pass = 12345;
            if (user == this.UsertextBox.Text && pass == Convert.ToInt32(this.PasstextBox.Text))
            {
                MessageBox.Show("Login Successfull !!!!");
                this.Hide();
                Product f2 = new Product();
                f2.ShowDialog();
            }

            else if (user != this.UsertextBox.Text || pass != Convert.ToInt32(this.PasstextBox.Text))
            {
                MessageBox.Show("Wrong Username/Password !!!!");
                this.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developer: Md. Toufique Hasan\nId: 12-02-04-069\nInstitution: AUST");
        }

    }
}
