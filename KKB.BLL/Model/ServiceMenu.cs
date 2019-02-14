using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BLL.Model
{
    public class ServiceMenu
    {
        public void MainMenu(User user)
        {
            Console.WriteLine("Приветствую Вас, {0}", user.fullname);
            Console.WriteLine("1. Вывод баланса");
            Console.WriteLine("2. Пополнение баланса");
            Console.WriteLine("3. Cнять деньги");
            Console.WriteLine("4. Выход");
        }
    }
}
