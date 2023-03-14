using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;

namespace BLL
{
    public class UserBLL
    {
        public static void AddUser(User user)
        {
            UserDAO.AddUser(user);
        }

        public static bool CheckUser(User user)
        {
            return UserDAO.CheckUser(user);
        }

        public static void DeleteUser(int userID)
        {
            UserDAO.DeleteUser(userID);
        }

        public static string GetUserName(string user)
        {
            return UserDAO.GetUserName(user);
        }

        public static List<User> GetUsers(string text1, string text2)
        {
            return UserDAO.GetUsers(text1, text2);
        }
    }
}
