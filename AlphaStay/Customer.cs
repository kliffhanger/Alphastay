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
    public partial class Customer : Form
    {
        OracleConnection con1;
        OracleCommand cmd;
        OracleDataReader rdr;
        string query;
        string s1;

        public Customer()
        {
            InitializeComponent();
            con1 = new OracleConnection("Data Source=localhost;User ID=alphastay;password=alphastay ");
            textBox1.Enabled = false;
            string query2, ID;
            query2 = "Select max(customer_id) from booking";
            con1.Open();
            cmd = new OracleCommand(query2, con1);
            cmd.CommandText = query2;
            ID = Convert.ToString(cmd.ExecuteScalar());
            if (ID.Equals(""))
                textBox1.Text = Convert.ToString(1);
            else
            {
                int s;
                s = Convert.ToInt16(ID) + 1;
                textBox1.Text = Convert.ToString(s);
                s1=s.ToString();
            }
            con1.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLogin adminLogin = new AdminLogin();
            adminLogin.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int TEMP=0;
            textBox2.Focus();
            con1.Open();
            query = "Insert into booking values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            cmd = new OracleCommand(query, con1);
            try
            {
                 TEMP = cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }

            if (TEMP > 0)
            {
                MessageBox.Show(" RECORD ADDED SUCESSFULLY");
                Room r = new Room(s1);
                r.Show();
                this.Hide();
            }

                
            else
                MessageBox.Show("INSERT OPERATION FAILED ");
            con1.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


    

    private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
