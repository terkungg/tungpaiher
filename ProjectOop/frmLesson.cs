using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectOop.FolderQuick;

namespace ProjectOop
{
    public partial class frmLesson : Form
    {
        public frmLesson()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            string addVideo = System.IO.Directory.GetParent(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + @"\video\test.mp4";
            //MessageBox.Show(addVideo);
            axWindowsMediaPlayer1.URL = addVideo;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnQuick_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm1 frm = new Frm1();
            frm.ShowDialog();
        }
    }
}
