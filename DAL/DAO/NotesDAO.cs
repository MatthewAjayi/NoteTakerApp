using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class NotesDAO : UserContext
    {
        public static void CreateNote(NewNote note)
        {
			try
			{      
                db.NewNotes.InsertOnSubmit(note);
                Console.WriteLine(note.UserID);
                Console.WriteLine(note.ID);
                db.SubmitChanges();
            }
			catch (Exception ex)
			{
                Console.WriteLine(note.UserID);
                Console.WriteLine(note.ID);
                throw ex;
			}
        }

        public static List<NewNote> GetNotes()
        {
            return db.NewNotes.ToList();
        }
    }
}
