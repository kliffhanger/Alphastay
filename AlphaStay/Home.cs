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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Customer op = new Customer();
                op.Show();
                Hide();
            }


            if (radioButton2.Checked == true)
            {
                search_customer ser = new search_customer();
                ser.Show();
                Hide();
            }
            if (radioButton3.Checked == true)
            {
              //  Reservation op = new Reservation();
               // op.Show();
               // Hide();
            }

            if (radioButton4.Checked == true)
            {
                Bill op = new Bill();
                op.Show();
                Hide();
            }

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin op = new AdminLogin();
            op.Show();
            Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
