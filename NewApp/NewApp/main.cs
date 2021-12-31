using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NewApp
{
    public partial class main : Form
    {
        private int childFormNumber = 0;

        public main()
        {
            InitializeComponent();
        }
          
        private void itemCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        create crt = new create();
        crt.MdiParent = this ;
        crt.Show();
        }

        private void main_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            ItemList list = new ItemList();
            list.MdiParent = this;
            list.Show();
        }

        }
    }
