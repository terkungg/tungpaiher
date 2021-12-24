using ProjectOop.FolderQuick;
using System;
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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm4 frm = new frm4();
            frm.ShowDialog();
        }


        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
