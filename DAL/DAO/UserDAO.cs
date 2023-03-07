using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class UserDAO : UserContext
    {
        public static void AddUser(User user)
        {
            try
            {
                db.Users.InsertOnSubmit(user);
                db.SubmitChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }


        public static List<User> GetUsers(string text1, string text2)
        {
            try
            {
                List<User> list = db.Users.Where(x => x.Username == text1 && x.Password == text2).ToList();
                return list;    
            }

            catch (Exception ex)
            {
                throw ex;   
            }
        }

        public static string GetUserName(string user)
        {
            db.Users.Where(x => x.Username == user);
            return user;
        }

        public static bool CheckUser(User user)
        {
            List<User> list = db.Users.Where(x => x.Username == user.Username).ToList();
            if (list.Count > 0)
            {
                return false;
            }

            else
            { 
                return true; 
            }  
        }
    }
}
