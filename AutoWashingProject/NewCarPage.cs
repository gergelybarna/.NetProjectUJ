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
    public partial class NewCarPage : Form
    {
        public User user;

        public NewCarPage()
        {
            InitializeComponent();
        }

        public NewCarPage(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           CenterPage f3 = new CenterPage(user);
           f3.Show();
           this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CenterPage f3 = new CenterPage(user);
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WorkingWithDatabase wdb = new WorkingWithDatabase();

            Auto auto = new Auto();
            auto.UserId = user.Id;  
            auto.Plate = textBoxPlate.Text.ToString().Trim();
            auto.Brand = textBoxBrand.Text.ToString();
            auto.Type = textBoxType.Text.ToString();

           
            if (!wdb.isPlateRegistered(textBoxPlate.Text.ToString(), user.Id))
            {
                if (wdb.saveAuto(auto))
                {
                    this.Hide();
                    CenterPage f3 = new CenterPage(user);
                    f3.Show();
                }
                else
                {
                    MessageBox.Show("Nem sikerült a mentés!");
                }
            }
            else
            {
                MessageBox.Show("Már regisztrált rendszám!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewCarPage_Load(object sender, EventArgs e)
        {

        }
    }
}
