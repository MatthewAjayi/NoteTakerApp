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
            Note note = new Note();
            note.Title = txtTitle.Text;
            note.Description = txtNote.Text;
            NotesBLL.CreateNote(note);
        }
    }
}
