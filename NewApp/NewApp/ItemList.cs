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
    public partial class ItemList : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CDBOJV\SQLEXPRESSNEW;Initial Catalog=data;Persist Security Info=True;User ID=sa;Password=admin123");
        SqlCommand cmd = new SqlCommand();

        public ItemList()
        {
            InitializeComponent();
            loaddata();
        }


        public void loaddata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CDBOJV\SQLEXPRESSNEW;Initial Catalog=data;Persist Security Info=True;User ID=sa;Password=admin123");
            // reading data


            SqlDataAdapter sda = new SqlDataAdapter("select * from [data].[dbo].[productlist]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2CDBOJV\SQLEXPRESSNEW;Initial Catalog=data;Persist Security Info=True;User ID=sa;Password=admin123");
            // reading data


            SqlDataAdapter sda = new SqlDataAdapter("select * from [data].[dbo].[productlist]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            edit e1 = new edit();
            e1.textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            e1.textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            e1.textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            e1.textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            e1.textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            e1.textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            e1.textBox7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            e1.ShowDialog();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select * from productlist where itemcode='" + textBox1.Text + "'");
            cmd.CommandText = ("select * from productlist where barcode='" + textBox1.Text + "'");
            cmd.CommandText = ("select * from productlist where productname='" + textBox1.Text + "'");
            cmd.CommandText = ("select * from productlist where brand='" + textBox1.Text + "'");
            cmd.CommandText = ("select * from productlist where model='" + textBox1.Text + "'");
            cmd.CommandText = ("select * from productlist where rsp='" + textBox1.Text + "'");
            cmd.CommandText = ("select * from productlist where barcode='" + textBox1.Text + "'");
            cmd.ExecuteNonQuery();
            con.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            edit e1 = new edit();
            e1.textBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            e1.textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            e1.textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            e1.textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            e1.textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            e1.textBox6.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            e1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView1.CurrentCell.RowIndex;
            DialogResult dialogResult = MessageBox.Show("Are you delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(RowIndex);
            }
            else if (dialogResult == DialogResult.No)
            {
                //nothing
            }
           
            
        }


    }
}
           

       
    

