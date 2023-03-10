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
namespace NoteTakerApp
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            User user = new User(); 
            user.Username = txtUserame.Text;
            user.Password = txtPassword.Text;
            if(user.Password == txtRePassword.Text )
            {
                bool check;
                check = BLL.UserBLL.CheckUser(user);
                if(check == true)
                {
                    
                    UserStatic.UserID = user.ID;
                    UserStatic.UserName = user.Username;
                    BLL.UserBLL.AddUser(user);
                    MessageBox.Show("You have successfully created a new user!");
                    FrmMain frm = new FrmMain();
                    this.Hide();
                    frm.ShowDialog();
                }

                else
                {
                    MessageBox.Show("User already exists!");
                }
                
            }

            else
            {
                MessageBox.Show("Passwords do not match please ensure your passwords match");
            }
            
        }
    }
}
