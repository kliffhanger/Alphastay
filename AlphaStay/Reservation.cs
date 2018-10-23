using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaStay
{
    public partial class Reservation : Form
    {
        public Reservation(string s1)
        {
            InitializeComponent();
               this.s = s1;
            textBox1.Text = s.ToString();
            textBox1.Enabled = false;
        }
          public string s { get; set; }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill();
            bill.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Room room = new Room(s);
            room.Show();
            this.Hide();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }
    }
}
