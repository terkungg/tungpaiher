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
using ProjectOop.FolderQuick;
using ProjectOop.Helper;
using ProjectOop.Models;

namespace ProjectOop
{
    public partial class frmFinal : Form
    {
        //List<UsersModel> UsersList;
        

        public frmFinal()
        {
            //int row=GetRowCount();
            InitializeComponent();
            string tSroce = UsersModel.sroce.ToString();
            lblSroce.Text = tSroce;
            string tUsername = UsersModel.UserName.ToString();
            lblUsername.Text = tUsername;

            //int UserId = frmLogin.usersId;
            //for(int i = 0; i < row; i++)
            //{
            //    MessageBox.Show(row.ToString());
            //    MessageBox.Show("userId"+UserId);
                
               
            //    if(UsersList[i].UserId == UserId)
            //    {
            //        lblFirstname.Text = UsersList[i].firstname;
            //    }
            //}


            //GetRowCount();

            


        }

        //private List<UsersModel> ConvertDataTableToList(DataTable dataTable)
        //{
        //    List<UsersModel> LessonList = new List<UsersModel>();
        //    for (int i = 0; i < dataTable.Rows.Count; i++)
        //    {
        //        UsersModel sqlUser = new UsersModel();
        //        sqlUser.UserId = Convert.ToInt32(dataTable.Rows[i]["UserID"]);
        //        sqlUser.firstname = dataTable.Rows[i]["Firstname"].ToString();
        //        sqlUser.lastname = dataTable.Rows[i]["Lastname"].ToString();

        //        LessonList.Add(sqlUser);
        //    }
        //    return LessonList;
        //}

        //private int GetRowCount()
        //{
        //    int rowCount = 0;
        //    using (SqlConnection conn = new SqlConnection(SQLHelper.ConnectionString))
        //    {
        //        conn.Open();
        //        string command = "SELECT * FROM [ProjectOop].[dbo].[Usres]";
        //        SqlDataAdapter ad = new SqlDataAdapter(command, conn);
        //        DataTable datatable = new DataTable();
        //        ad.Fill(datatable);

        //        rowCount = datatable.Rows.Count;
        //        UsersList = ConvertDataTableToList(datatable);
        //        conn.Close();

        //    }
        //    return rowCount;
        //}

    }
}
