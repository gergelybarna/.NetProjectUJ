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
        public User user;
        public ServiceReservation(User user)
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd - hh:mm";
            button1.Hide();
            this.user = user;
            fillComboBox();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check()) MessageBox.Show(dateTimePicker1.Value.ToString("yyyy-MM-dd") + " ez");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            button1.Show();
        }

        public void fillComboBox(){
            WorkingWithDatabase db = new WorkingWithDatabase();
            List<string> plates = new List<string>();
            plates = db.getMyPlates(user.Id);
            //MessageBox.Show(plates.Count()+"");
            foreach (string p in plates){
                comboBox1.Items.Add(p);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private bool Check() {
            if (textBox1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Kérem töltse ki a probléma mezőt!");
                return false;
            }
            return true;
        }
    }
}
