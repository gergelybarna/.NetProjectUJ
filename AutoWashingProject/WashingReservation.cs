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
    public partial class WashingReservation : Form
    {
        public WashingReservation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CenterPage f3 = new CenterPage();
            f3.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
