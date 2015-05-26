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

            if (checkIfEmpty())
            {
                if (IsValidEmail(textBoxEmail.Text.ToString().Trim()))
                {
                    if (PhoneCheck(textBoxPhone.Text.Trim().ToString())){
                    user.Name = textBoxName.Text.ToString();
                    user.Email = textBoxEmail.Text.ToString();
                    user.Password = textBoxPassword.Text.ToString();
                    user.Phone = textBoxPhone.Text.ToString();

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
                    }else{
                        MessageBox.Show("Helytelen Telefonszám!");
                        textBoxPhone.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Helytelen e-mail cím!");
                    textBoxEmail.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Kérem töltsön ki minden mezőt!");
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
      
        public bool checkIfEmpty()
        {
            bool isEmpty = true;
            if (textBoxName.Text.Trim().Length == 0)
            {
                isEmpty = false;
            }

            if (textBoxEmail.Text.Trim().Length == 0)
            {
                isEmpty = false;

            }
            if (textBoxPassword.Text.Trim().Length == 0)
            {
                isEmpty = false;

            }

            if (textBoxPhone.Text.Trim().Length == 0)
            {
                isEmpty = false;
            }

            return isEmpty;
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }


        private bool PhoneCheck(string tString)
        {
            bool isok = true;
            if (tString.Length < 10) isok = false;

            for (int i = 0; i < tString.Length; i++)
            {
                if (!char.IsNumber(tString[i]))
                {
                  
                    isok = false;
                }

            }
            return isok;
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
