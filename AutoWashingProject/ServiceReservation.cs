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
    public partial class ServiceReservation : Form
    {
        public ServiceReservation()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CenterPage f3 = new CenterPage();
            f3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
