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
    public partial class Bill : Form
    {
        OracleConnection con1;
        OracleCommand cmd;
        string query;
        int temp, I;
        OracleDataReader reader2;


        public Bill()
        {
            InitializeComponent();
            Random generator = new Random();
            int r = generator.Next(100000, 1000000);
            textBox2.Text = Convert.ToString(r);
            textBox2.Enabled = false;
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         /*   DateTime inn, outt;
                int tdays;
            
            string search = " ",rtype;
            int flag = 0,amt=0;
            con1 = new OracleConnection("Data Source=localhost;User ID=alphastay;password=alphastay");
            search = "select * from RESERVATION where CUSTOMER_ID='" + textBox1.Text + "' ";
            cmd = new OracleCommand(search, con1);
            con1.Open();
            reader2 = cmd.ExecuteReader();


           



             while (reader2.Read())
               {
                   Random generator = new Random();
                   String r = generator.Next(0, 999999).ToString("textBox2");
                   inn = Convert.ToDateTime(reader2["CHECK_IN"]);
                   outt = Convert.ToDateTime(reader2["CHECK_OUT"]);
                   tdays = Convert.ToInt16(outt - inn);
                   rtype= Convert.ToString(reader2["ROOM_TYPE"]);
                   if (rtype=="simple")
                   {
                       amt = 500 * tdays;
                   }
                   else
                   {
                       amt = 1000 * tdays;
                   }

                   textBox3.Text = Convert.ToString(reader2["amt"]);



                   flag = 1;
               }
               if (flag == 0)
               {
                   MessageBox.Show(" Record not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


               }
               reader2.Close();
               con1.Close();    */


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
