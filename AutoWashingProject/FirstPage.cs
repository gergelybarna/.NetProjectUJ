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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f1 = new Login();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration f2 = new Registration();
            f2.Show();
        }
    }
}
