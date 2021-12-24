using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOop.Models;

namespace ProjectOop.FolderQuick
{
    public partial class Frm1 : Form
    {
        public Frm1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            if (rbtnA.Checked)
            {
                UsersModel.sroce = +1;
                UsersModel.select = "select";
            }

            if (rbtnB.Checked)
            {
                UsersModel.select = "select";
            }

            if (rbtnC.Checked)
            {
                UsersModel.select = "select";
            }

            if (rbtnD.Checked)
            {
                UsersModel.select = "select";
            }
     
            //==============================================================================

            if (UsersModel.select != "select")
            {
                MessageBox.Show("เลือกคำตอบด้วยน้าาา");
            }
            else
            {
                this.Hide();
                frm2 frm = new frm2();
                frm.ShowDialog();
            }

        }

    }

}
