using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace AlphaStay
{
 

    public partial class AdminLogin : Form
    {
        // make common variables global
        OracleConnection con1;
        OracleCommand cmd;
        OracleDataReader rdr;
        string query;

        void clearform()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        public AdminLogin()
        {
            InitializeComponent();
            con1 = new OracleConnection("Data Source=localhost;User ID=alphastay;password=alphastay ");
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == " ") || (textBox2.Text == ""))
            {
                MessageBox.Show("Enter the username and password");
            }
            else
            {
                int FLAG = 0;
                string STR = "";

                query = "select * from login where username ='" + textBox1.Text + "' ";
                cmd = new OracleCommand(query, con1);

                con1.Open();
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    STR = (string)rdr["password"];
                    FLAG = 1;
                }
                rdr.Close();

                con1.Close();
                if (FLAG == 0)
                {
                    MessageBox.Show(" username doesnt exist");
                    clearform();

                }
                else if (textBox2.Text == STR)
                {
                    Home op = new Home();
                    op.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username and Password doesnt match. Please enter correct username and Password");
                    textBox2.Text = " ";
                    textBox2.Focus();
                }

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
