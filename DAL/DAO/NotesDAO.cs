using DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class NotesDAO : UserContext
    {
        public static void CreateNote(AllNote note)
        {
			try
			{      
                db.AllNotes.InsertOnSubmit(note);
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

        public static void DeleteNote(int noteID, int userID)
        {
            try
            {
                AllNote note = db.AllNotes.First(x => x.ID == noteID);
                db.AllNotes.DeleteOnSubmit(note);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<AllNote> GetNotes()
        {
            return db.AllNotes.ToList();
        }

        public static void UpdateNote(int noteID, string noteTitle, string noteDescription, int userID)
        {
            try
            {
                AllNote note = db.AllNotes.First(x => x.ID == noteID);
                note.Title = noteTitle; 
                note.Description = noteDescription;
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static List<ViewNotesDTO> userNotes(int currentUserID, string user)
        {
            try
            {
                var list = (from n in db.AllNotes
                            join u in db.Users on n.UserID equals u.ID where u.Username == user
                            select new
                            {
                                notesID = n.ID,
                                notesTitle = n.Title,
                                notesDescription = n.Description,
                                notesUserID = currentUserID
                            }).OrderBy(x => x.notesID).ToList();
                List <ViewNotesDTO> result = new List<ViewNotesDTO>();
                foreach (var item in list) 
                { 
                    ViewNotesDTO dto = new ViewNotesDTO();
                    dto.userID = item.notesUserID;
                    dto.noteID = item.notesID;
                    dto.title = item.notesTitle; 
                    dto.description = item.notesDescription;
                    dto.UserID = item.notesUserID;
                    result.Add(dto);
                }

                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
