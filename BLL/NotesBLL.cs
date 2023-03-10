using DAL;
using DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NotesBLL
    {
        public static void CreateNote(NewNote note)
        {
            NotesDAO.CreateNote(note);
        }

        public static List<NewNote> GetNotes()
        {
            return NotesDAO.GetNotes();
        }
    }
}
