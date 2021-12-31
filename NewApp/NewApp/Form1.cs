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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CDBOJV\SQLEXPRESSNEW;Initial Catalog=data;Persist Security Info=True;User ID=sa;Password=admin123");
            SqlDataAdapter sda = new SqlDataAdapter(@"select *
              from login where Username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                this.Hide();
                main ss = new main();
                ss.Show();
            }
            else
            {
                MessageBox.Show("invalid UserName and Password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
