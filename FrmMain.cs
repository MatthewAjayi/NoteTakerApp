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
using DAL.DTO;

namespace NoteTakerApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblWelcomeUser.Text = UserStatic.UserName.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //lblWelcomeUser.Text = FrmLogin.SetValueForText1;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frm = new FrmLogin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnCreateNote_Click(object sender, EventArgs e)
        {
            FrmCreateNote frm = new FrmCreateNote();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnViewNote_Click(object sender, EventArgs e)
        {
            FrmViewNotes frm = new FrmViewNotes(); 
            this.Hide();
            frm.ShowDialog();   
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
