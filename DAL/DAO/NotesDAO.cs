using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class NotesDAO : UserContext
    {
        public static void CreateNote(Note note)
        {
			try
			{      
                db.Notes.InsertOnSubmit(note);
                db.SubmitChanges();
            }
			catch (Exception ex)
			{
				throw ex;
			}
        }
    }
}
