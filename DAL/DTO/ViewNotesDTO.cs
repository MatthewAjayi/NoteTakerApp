using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class ViewNotesDTO:AllNote
    {
        public int noteID { get; set; }
        //public string username { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int userID { get; set; }

    }
}
