using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser.NewFolder1;
using RandomUser;

namespace KKB.BLL.Model
{
    class ServiceUser
    {
        public bool LogOn( User user, out string message)
        {
            if(user.login=="admin" && user.password.Equals("admin"))
            {
                results results=GenerateUser.GetUser();
                user.fullname = 
                    string.Format("{0} {1} {2}", results.name.title, results.name.first ,results.name.last);
                user.accounts = ServiceAccount.getAccounts();
                message = "OK";
               // message = string.Format("Добро пожаловать, {0}", user.fullname);
                return true;
            }

            else
            {
                message = "Неправильный логин или пароль";
                return false;
            }
        }
    }
}
