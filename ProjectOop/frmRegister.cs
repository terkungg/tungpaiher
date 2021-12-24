using ProjectOop.Helper;
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
using ProjectOop.Models;

namespace ProjectOop
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            //remove the focus from the textboxes
            this.ActiveControl = label1;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
            {
                conn.Open();

                string cmdInsertStr = "INSERT INTO [ProjectOop].[dbo].[Usres] (Username, Password, Email, Phone) VALUES ('" + tbUsername.Text + "', '" + tbPassword.Text + "', '" + tbEmail.Text + "', '" + tbPhone.Text +"')";
                int query = SQLHelper.ExecuteNonQuery(conn, cmdInsertStr, null);

                if (query > 0)
                {
                    UsersModel.UserName = tbUsername.Text;

                    MessageBox.Show("Register Success!");
                    this.Hide();
                    frmLogin frmLogin = new frmLogin();
                    frmLogin.ShowDialog();

                    
                    
                }
                else
                {
                    MessageBox.Show("Register False");
                }
                conn.Close();
            }
        }

    }
}
