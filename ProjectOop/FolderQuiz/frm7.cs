﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOop.FolderQuiz
{
    public partial class frm7 : Form
    {
        public frm7()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm8 frm = new frm8();
            frm.ShowDialog();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
