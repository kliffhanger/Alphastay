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
    public partial class search_customer : Form
    {
        OracleConnection con1;
        OracleCommand cmd;
        string id,query;
        //int temp, I;
      //  OPTIONFRM op;
        OracleDataReader reader2;

        public search_customer()
        {
            InitializeComponent();
            NSEARCH();
            textBox1.Focus();

        }
        public search_customer(string str1)    //constructor 2 of search frm
        {
            InitializeComponent();
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox1.Text = str1;
            string search = " ";
        int flag = 0;
        con1 = new OracleConnection("Data Source=localhost;User ID=alphastay;password=alphastay");
        search = "select * from BOOKING where NAME='" + textBox1.Text + "' ";
            cmd = new OracleCommand(search, con1);
        con1.Open();
            reader2 = cmd.ExecuteReader();

            while (reader2.Read())
            {
                id = Convert.ToString(reader2["CUSTOMER_ID"]);
                textBox2.Text = Convert.ToString(reader2["CUSTOMER_ID"]);
                textBox3.Text = Convert.ToString(reader2["CONTACT_NO"]);
                textBox4.Text = Convert.ToString(reader2["ADDRESS"]);
                textBox5.Text = Convert.ToString(reader2["EMAIL_ID"]);
                flag = 1;
            }
            if (flag == 0)
            {
                MessageBox.Show(" Record not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NSEARCH();

}
reader2.Close();
            con1.Close();
           // textBox1.Text = " ";
            textBox1.Focus();
        }

        private void NSEARCH()
{
    //textBox1.Visible = false;
    textBox2.Visible = false;
    textBox3.Visible = false;
    textBox4.Visible = false;
    textBox5.Visible = false;
}


private void Search_Click(object sender, EventArgs e)
        {
            search_customer sbar;
            if (textBox1.Text == "" || textBox1.Text == " ")
                MessageBox.Show("ENTER THE ID TO BE SEARCHED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else
            {
                sbar= new search_customer(textBox1.Text); //uses constructor 2 of searchbar frm
                sbar.Show();
                Hide();
            }

        }

        private void search_customer_Load(object sender, EventArgs e)
        {

        }

        private void book_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox1.Text == " ")
                MessageBox.Show("ENTER THE ID TO BE SEARCHED", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string entry_point = "";
                Room rm = new Room(id, entry_point);
                rm.Show();
                Hide();
            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Home bk_home = new Home();
            bk_home.Show();
            Hide();
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            if (textBox2.Visible == false)

                MessageBox.Show("SEARCH THE RECORD", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                DialogResult dr;
                dr = MessageBox.Show("ARE YOU SURE YOU WANT TO MODIFY THE RECORD?", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    query = "Update BOOKING Set CONTACT_NO='" + textBox3.Text + "',ADDRESS='" + textBox4.Text.ToUpper() + "',EMAIL_ID='" + textBox5.Text + "'";

                    cmd = new OracleCommand(query, con1);
                    cmd.CommandType = CommandType.Text;
                    try
                    {
                        con1.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record updated successfully", "MESSAGE");
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message);
                    }

                    finally
                    {
                        con1.Close();

                    }
                }
                con1.Close();

            }

        }

    }
}

