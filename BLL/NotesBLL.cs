using DAL;
using DAL.DAO;
using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NotesBLL
    {
        public static void CreateNote(AllNote note)
        {
            NotesDAO.CreateNote(note);
        }

        public static void DeleteNote(int noteID, int userID)
        {
            NotesDAO.DeleteNote(noteID, userID);
        }

        public static List<AllNote> GetNotes()
        {
            return NotesDAO.GetNotes();
        }

        public static void UpdateNote(int noteID, string noteTitle, string noteDescription, int userID)
        {
            NotesDAO.UpdateNote(noteID, noteTitle, noteDescription, userID);
        }

        public static List<ViewNotesDTO> userNotes(int currentUserID, string user)
        {
            return NotesDAO.userNotes(currentUserID, user);
        }
    }
}
