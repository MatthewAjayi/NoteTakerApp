using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NoteTakerApp
{
    public class currentUserName
    {
        private string username;
        public string userName { 
            get 
            { 
                return this.username; 
            } 
            set 
            { 
                this.username = value; 
            } 
        }
    }
}
