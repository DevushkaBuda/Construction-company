using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Unit_TestAuth
{
    public class AuthClass
    {
        public static constructionCompanyEntities db = new constructionCompanyEntities();
        public static string Auto(string login, string password)
        {
            var currentUser = db.Entrance.FirstOrDefault(p => p.Login == login && p.Password == password);
            if (currentUser !=null)
            {
                switch (currentUser.idEntrance)
                {
                    case 1: return "Сотрудник";
                    
                 
                }
            }
            return "Такого пользователя нет";
        }
    }
}
