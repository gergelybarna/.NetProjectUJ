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
        public User user;
        WorkingWithDatabase db;

        public WashingReservation(User user)
        {
            InitializeComponent();
            db = new WorkingWithDatabase();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy/MM/dd - hh:mm";
            button1.Hide();
            this.user = user;
            fillComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            CenterPage f3 = new CenterPage(user);
            f3.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveReservation();
            CenterPage f3 = new CenterPage(user);
            f3.Show();
            this.Hide();
        }

        private void WashingReservation_Load(object sender, EventArgs e)
        {

        }

        public void fillComboBox(){
            List<string> plates = new List<string>();
            plates = db.getMyPlates(user.Id);
            //MessageBox.Show(plates.Count()+"");
            foreach (string p in plates){
                comboBox1.Items.Add(p);
            }
        }

        public void saveReservation()
        {
            Reservation res = new Reservation();
            string text = comboBox1.Text;
            int autoId = 0;

            if (text.Length != 0)
            {
                autoId = db.getAutoIdByPlate(text);
                res.AutoId = autoId;
                res.Date = dateTimePicker1.Value;
                res.Problem = "";
                res.ReservationType = 2;

                db.saveDate(res);

                MessageBox.Show("A foglalás sikeresen! Amennyiben vissza szeretné vonni, kérem jelezze telefonon!");
            }
            else
            {
                MessageBox.Show("Kérem válasszon ki egy rendszámot!");
            }
        }

        public bool checkIfIsFree(List<DateTime> dates) {
            bool isFree = true;
            DateTime dateSelected = dateTimePicker1.Value;
            foreach (DateTime d in dates){
                if (d.Day == dateSelected.Day && d.Year == dateSelected.Year
                    && d.Month == dateSelected.Month) {
                        if (d.Hour == dateSelected.Hour || d.Hour == (dateSelected.Hour - 1)) {
                            isFree = false;
                        }
                }
            }
            return isFree;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<DateTime> dates = db.getMyDates(2);
            if (checkIfIsFree(dates))
            {
                MessageBox.Show("Az időpont szabad!");
                button1.Show();
            }
            else
            {
                MessageBox.Show("Az időpont foglalt, kérem válasszon más időpontot!");
            }
        }
    }
    
}
