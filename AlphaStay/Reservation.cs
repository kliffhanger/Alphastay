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
        public Reservation(string c_id,string c_entry)
        {
            InitializeComponent();
            s1 = c_id;
            s2 = c_entry;
            textBox1.Text = s1.ToString();
            textBox1.Enabled = false;
        }
        public string s1 { get; set; }
        public string s2 { get; set; }
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
            Room r = new Room(s1,s2);
            r.Show();
            this.Hide();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }
    }
}
