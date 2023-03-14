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
using DAL.DTO;

namespace NoteTakerApp
{
    public partial class FrmEditNote : Form
    {
        public FrmEditNote()
        {
            InitializeComponent();
        }

        private void FrmEditNote_Load(object sender, EventArgs e)
        {
            txtTitle.Text = NoteStatic.noteTitle;
            txtNote.Text = NoteStatic.noteDescription;
        }

        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text.Trim() != "" && txtNote.Text.Trim() != "")
            {
                NotesBLL.UpdateNote(NoteStatic.noteID, txtTitle.Text.ToString(), txtNote.Text.ToString(), NoteStatic.UserID);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
