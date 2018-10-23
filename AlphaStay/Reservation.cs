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
        public Reservation()
        {
            InitializeComponent();
               
        }
        
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
            Room r = new Room();
            r.Show();
            this.Hide();
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }
    }
}
