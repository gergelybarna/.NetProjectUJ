using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoWashingProject
{
    public partial class Login : Form
    {
        public User newUser;
        public CenterPage f3;

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Registration_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration f2 = new Registration();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Email = textBox1.Text.Trim();
            user.Password = textBox2.Text.Trim();

            bool ck = Cheks();

            WorkingWithDatabase wdb = new WorkingWithDatabase();
            User newUser = new User();
            newUser = wdb.getUserByEmailAndPass(user);

            if (ck == true)
            {
                if (newUser.Id != 0)
                {
                    CenterPage f3 = new CenterPage(user);
                    f3.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Helytelen e-mail cím vagy jelszó!");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private bool Cheks()
        {
            bool err = false;
            if (textBox1.Text.Trim().Length == 0)
                err = true;
            if (textBox2.Text.Trim().Length == 0) 
                err = true;
            if (err == true)
            {
                MessageBox.Show("Kérem töltsön ki minden mezőt helyesen!");
                return false;
            }
            return true;
        }
        
    }
}
