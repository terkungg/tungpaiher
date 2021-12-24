using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOop;
using ProjectOop.FolderQuiz;
using ProjectOop.Models;

namespace ProjectOop.FolderQuick
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            if (rbtnA.Checked)
            {
                UsersModel.sroce += 1;
            }

            this.Hide();
            frm3 frm = new frm3();
            frm.ShowDialog();

            
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
