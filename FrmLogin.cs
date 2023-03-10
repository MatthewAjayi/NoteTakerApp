using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DAL.DAO;
using DAL.DTO;

namespace NoteTakerApp
{
    public partial class FrmLogin : Form
    {
        public static string SetValueForText1 = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserame_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUserame_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = General.isNumber(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //FrmMain frm = new FrmMain();
            //this.Hide();
            //frm.ShowDialog();   
            if (txtUserame.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter Username and Password!");

            }

            else
            {
                List<User> userList = UserBLL.GetUsers(txtUserame.Text, txtPassword.Text);
                
                User user = new User();
                if (userList.Count == 0)
                    MessageBox.Show("No values in db  with that username or password");
                else
                { 
                    User loginUser = new User();
                    loginUser = userList.First();
                    UserStatic.UserID = loginUser.ID;
                    UserStatic.UserName = loginUser.Username;
                    FrmMain frm = new FrmMain();
                    this.Hide();    
                    frm.ShowDialog();   
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frm = new FrmRegister();
            this.Hide();
            frm.ShowDialog();   
            //this.Visible = true;    
        }
    }
}
