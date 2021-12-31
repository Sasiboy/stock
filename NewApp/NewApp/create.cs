using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Data.SqlClient;

namespace NewApp
{
    public partial class create : Form
    {
        public create()
        {
            InitializeComponent();
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CDBOJV\SQLEXPRESSNEW;Initial Catalog=data;Persist Security Info=True;User ID=sa;Password=admin123");

            // insert logic
            con.Open();
            bool status = false;
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [data].[dbo].[productlist]
           ([Barcode]
           ,[ProductName]
           ,[Brand]
           ,[Model]
           ,[Rsp]
           ,[Mrp]
           ,[deactivate])
     VALUES
           ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + cbox.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();


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
        public bool keypreview { get; set; }

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
       
        }   

        
    }

