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
        private bool Cheks() {
            bool err=false;
             Regex regexObj = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (textBox1.Text.Trim().Length == 0)
                err = true;
            if ((textBox2.Text.Trim().Length == 0)&&(isValidEmail(textBox2.Text)==true))
                err = true;
            if (textBox3.Text.Trim().Length == 0)
                err = true;
            if ((textBox4.Text.Trim().Length == 0)&&(regexObj.IsMatch(textBox4.Text)))
                err = true;
            if (err == true)
            {
                MessageBox.Show("Kérem töltsön ki minden mezőt helyesen!");
                return false;
            }
            return true;
        }
        

           

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public bool IsValidPhoneNumber(string number)
        {
            Regex regexObj = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");

            if (regexObj.IsMatch(number))
                return true;
            return false;
        }
        public bool isValidEmail(string email)
        {
            if (email.Equals(""))
            {
                return false;
            }
            else
            {
                try
                {
                    MailAddress m = new MailAddress(email);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
