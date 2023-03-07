using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class EmployeeDetailsDTO
    {
        public int ID { get; set; }
        public string Username { get { return Username; } set { Username = value; } }

        public string Password { get; set; }
    }
}
