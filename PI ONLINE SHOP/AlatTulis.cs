﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_ONLINE_SHOP
{
    public partial class AlatTulis : Form
    {
        public AlatTulis()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Success success = new Success();
            success.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Success success = new Success();
            success.Show();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Success success = new Success();
            success.Show();
 
        }
    }
}
