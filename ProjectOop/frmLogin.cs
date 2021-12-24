using ProjectOop.Helper;
using ProjectOop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectOop
{
    public partial class frmLogin : Form
    {
        
        static List<UsersModel> userList = new List<UsersModel>();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
            {
                conn.Open();
                string username = tbUsername.Text;
                string password = tbPassword.Text;

                UsersModel.UserName=username;

                string cmdStr = "SELECT * FROM [ProjectOop].[dbo].[Usres] WHERE Username = '" + username + "' AND Password = '" + password + "'";

                SqlDataReader dr = SQLHelper.ExecuteReader(conn, CommandType.Text, cmdStr, null);

                if (dr.HasRows)
                {

                    MessageBox.Show("Login Success");

                    this.Hide();
                    frmWelcome frmW = new frmWelcome();
                    frmW.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Faied");
                }
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegister frmRe = new frmRegister();
            frmRe.ShowDialog();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
