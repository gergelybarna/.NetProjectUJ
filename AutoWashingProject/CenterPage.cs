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
    public partial class CenterPage : Form
    {
        public User user;

        public CenterPage()
        {
            InitializeComponent();
        }

        public CenterPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login f1= new Login();
            f1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCarPage f4 = new NewCarPage(user);
            f4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f5 = new WashingReservation();
            f5.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReservation f6 = new ServiceReservation(user);
            f6.Show();
            this.Hide();
        }
    }
}
