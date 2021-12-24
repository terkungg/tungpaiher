using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOop.FolderQuick;
using ProjectOop.Models;

namespace ProjectOop
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();

            string tUsername = UsersModel.UserName.ToString();
            lblusername.Text = tUsername;
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 frm = new Frm1();
            frm.ShowDialog();
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLesson frm = new frmLesson();
            frm.ShowDialog();
        }
    }
}
