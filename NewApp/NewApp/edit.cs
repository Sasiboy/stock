using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NewApp
{
    public partial class edit : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CDBOJV\SQLEXPRESSNEW;Initial Catalog=data;Persist Security Info=True;User ID=sa;Password=admin123");
        SqlCommand cmd;

        public edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("update productlist set Barcode=@Barcode,ProductName=@ProductName,Brand=@Brand,Model=@Model,Rsp=@Rsp,Mrp=@Mrp where itemcode=@itemcode", con);
            cmd.Parameters.AddWithValue("@Itemcode", int.Parse(textBox7.Text));
            cmd.Parameters.AddWithValue("@Barcode", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@ProductName", textBox2.Text);
            cmd.Parameters.AddWithValue("@Brand", textBox3.Text);
            cmd.Parameters.AddWithValue("@Model", textBox4.Text);
            cmd.Parameters.AddWithValue("@Rsp", textBox5.Text);
            cmd.Parameters.AddWithValue("@Mrp", textBox6.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated Sucessfully");
            this.Hide();

        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox6.Focus();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox3.Focus();
            }
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                textBox6.Clear();
                textBox2.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox4.Focus();
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                textBox3.Clear();
                textBox6.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox5.Focus();
            }
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                textBox4.Clear();
                textBox3.Focus();
            }
        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                textBox5.Clear();
                textBox4.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you cancel?", "cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing
            }

        }
    }
}

       

        

        
    

