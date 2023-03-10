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
    public partial class FrmViewNotes : Form
    {
        public FrmViewNotes()
        {
            InitializeComponent();
        }

        private void dataViewNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        List<NewNote> list = new List<NewNote>();
        private void FrmViewNotes_Load(object sender, EventArgs e)
        {
            list = NotesBLL.GetNotes();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "Notes ID";
            dataGridView1.Columns[1].HeaderText = "Notes Title";
            dataGridView1.Columns[2].HeaderText = "Notes Description";
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
    }
}
