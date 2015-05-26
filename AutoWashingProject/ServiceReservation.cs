﻿using System;
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
        WorkingWithDatabase db;

        public ServiceReservation(User user)
        {
            InitializeComponent();
            db = new WorkingWithDatabase();
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
            CenterPage f3 = new CenterPage(user);
            f3.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (Check()) MessageBox.Show(dateTimePicker1.Value.ToString("yyyy-MM-dd") + " ez");
=======
            saveReservation();
            CenterPage f3 = new CenterPage(user);
            f3.Show();
            this.Hide();
            //MessageBox.Show("");
>>>>>>> 744ea4418a16328254c171da129f66c2f19bf093
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            List<DateTime> dates = db.getMyDates(1);
            if (checkIfIsFree(dates))
            {
                MessageBox.Show("Az időpont szabad!");
                button1.Show();
            }
            else {
                MessageBox.Show("Az időpont foglalt, kérem válasszon más időpontot!");
            }

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
                res.Problem = textBoxProblem.Text.ToString();
                res.ReservationType = 1;

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
