using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace AutoWashingProject
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();

            bool ck = Cheks();
            if (ck == true)
            {
                user.Name = textBox1.Text.ToString();
                user.Email = textBox3.Text.ToString();
                user.Password = textBox2.Text.ToString();
                user.Phone = textBox4.Text.ToString();

                WorkingWithDatabase db = new WorkingWithDatabase();
                if (db.SaveUser(user))
                {
                    MessageBox.Show("Sikeres mentés!");
                    Login f1 = new Login();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sikertelen mentés!");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private bool Cheks()
        {
            if ((textBox1.Text.Trim().Length == 0) && (textBox2.Text.Trim().Length == 0) && (textBox3.Text.Trim().Length == 0)
              && (textBox4.Text.Trim().Length == 0))
            {
                MessageBox.Show("Kérem töltsön ki minden mezőt!");
                return false;
            }
            if (textBox4.Text.Trim().Length < 10)
                return false;
            else
            {
                string tString = textBox4.Text;
                for (int i = 0; i < tString.Length; i++)
                {
                    if (!char.IsNumber(tString[i]))
                    {
                        MessageBox.Show("Helytelen Telefonszám!");
                        textBox4.Text = "";
                        return false;
                    }

                }
            }
            if (!textBox2.Text.Trim().Equals("@"))
            {
                MessageBox.Show("Helytelen E-mailcim!");
                return false;
            }
        return true;
        }




        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
