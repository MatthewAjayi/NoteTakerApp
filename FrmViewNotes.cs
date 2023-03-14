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
    public partial class FrmViewNotes : Form
    {
        public FrmViewNotes()
        {
            InitializeComponent();
        }

        private void dataViewNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        List<AllNote> list = new List<AllNote>();
        List<ViewNotesDTO> viewNotesDTOs = new List<ViewNotesDTO>();   
        private void FrmViewNotes_Load(object sender, EventArgs e)
        {
            //list = NotesBLL.GetNotes();
            //dataGridView1.DataSource = list;
            

            viewNotesDTOs = NotesBLL.userNotes(UserStatic.UserID, UserStatic.UserName);
            //Console.WriteLine(viewNotesDTOs);
           
            dataGridView1.DataSource = viewNotesDTOs;
            dataGridView1.Columns[0].HeaderText = "Notes ID";
            dataGridView1.Columns[1].HeaderText = "Notes Title";
            dataGridView1.Columns[2].HeaderText = "Notes Description";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FrmMain frm = new FrmMain();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        int selectedRow;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[selectedRow];
            
            if (btnEditWasClicked)
            {
                NoteStatic.noteID = Convert.ToInt32(row.Cells[0].Value.ToString());
                NoteStatic.noteTitle = row.Cells[1].Value.ToString();
                NoteStatic.noteDescription = row.Cells[2].Value.ToString();
                NoteStatic.UserID = Convert.ToInt32(row.Cells[3].Value.ToString());
                FrmEditNote frm = new FrmEditNote();
                btnEditWasClicked = false;
                frm.ShowDialog();
            }

            if(btnDeleteWasClicked)
            {
                NoteStatic.noteID = Convert.ToInt32(row.Cells[0].Value.ToString());
                NoteStatic.noteTitle = row.Cells[1].Value.ToString();
                NoteStatic.noteDescription = row.Cells[2].Value.ToString();
                NoteStatic.UserID = Convert.ToInt32(row.Cells[3].Value.ToString());
 
                NotesBLL.DeleteNote(NoteStatic.noteID, NoteStatic.UserID);
                
                MessageBox.Show("Note was deleted");
                btnRefresh_Click(sender, e);
            }

        }

        private bool btnEditWasClicked = false;
        private bool btnDeleteWasClicked = false;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnEditWasClicked = true;
            MessageBox.Show("Select a cell to edit");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FrmViewNotes_Load(sender, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this note", "Warning!!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //NotesBLL.DeleteNote(NoteStatic.noteID, NoteStatic.UserID);
                btnDeleteWasClicked = true;
            }
        }
    }
}
