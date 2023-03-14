using DAL;
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
using DAL.DAO;

namespace NoteTakerApp
{
    public partial class FrmCreateNote : Form
    {
        public FrmCreateNote()
        {
            InitializeComponent();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text.Trim() != ""  && txtNote.Text.Trim() != "")
            {
                
                AllNote note = new AllNote();
                note.Title = txtTitle.Text;
                note.Description = txtNote.Text;
                note.UserID = UserStatic.UserID;
                NotesBLL.CreateNote(note);
                MessageBox.Show("New note added!");
            }

            else
            {
                MessageBox.Show("Please ensure you have a title and a description!");
            }
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            this.Hide();
            frmMain.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
