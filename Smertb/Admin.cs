using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smertь
{
    internal class Admin
    {
        static public void Adm()
        {
            var s = 0;
            while(true)
            {
                Console.WriteLine("Добро пожаловать, " + Program.a);
                Console.WriteLine("Список пользователей:");
                foreach (var user in Program.us)
                {
                    Console.WriteLine("   " + user.Lg);
                }
                Console.SetCursorPosition(0, 2 + s);
                Console.WriteLine("-->");
                switch(Console.ReadKey(true).Key)
                {
                    case ConsoleKey.DownArrow:
                        if (s < Program.us.Count - 1)
                            s++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (s > 0)
                            s--;
                        break;
                    case ConsoleKey.Enter: 
                        var sel = Program.us[s];
                        Console.WriteLine("Логин: " + sel.Lg + ", пароль: " + sel.Pass);
                        Console.ReadKey();
                        break;
                    case ConsoleKey.C: 
                        {
                            Console.Clear();
                            Console.WriteLine("Введите логин");
                            var log = Console.ReadLine();
                            Console.WriteLine("Введите пароль");
                            var pas = Console.ReadLine();
                            int mId = 1;
                            foreach (var user in Program.us)
                            {
                                if (mId < user.id)
                                {
                                    mId = user.id;
                                }
                            }
                            Program.us.Add(new Adm(mId + 1, log, pas, R.Adm));
                        }
                        break;
                    case ConsoleKey.E:
                        {
                            Console.Clear();
                            Console.WriteLine("Введите новый логин");
                            var log = Console.ReadLine();
                            Console.WriteLine("Введите новый пароль");
                            var pas = Console.ReadLine();
                            Program.us[s] = new Adm(Program.us[s].id, log, pas, R.Adm);
                        }
                        break;
                    case ConsoleKey.D:
                        if (Program.us.Count > 0)
                        {
                            Program.us.RemoveAt(s);
                            s = 0;
                        }
                        break;
                    case ConsoleKey.F:
                        Console.Clear();
                        Console.WriteLine("Выберите свойство для поиска");
                        Console.WriteLine("1 - логин, 2 - пароль");
                        var p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите значение");
                        var v = Console.ReadLine();
                        Console.WriteLine("Результаты поиска");
                        switch (p)
                        {
                            case 1:
                                foreach (var user in Program.us)
                                {
                                    if (user.Lg.Contains(v))
                                    {
                                        Console.WriteLine(user.Lg);
                                    }
                                }
                                break;
                            case 2:
                                foreach (var us in Program.us)
                                {
                                    if (us.Pass.Contains(v))
                                    {
                                        Console.WriteLine(us.Lg);
                                    }
                                }
                                break;
                        }
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Q: /*Сохранить и выйти*/
                        Program.Save(Program.a, Program.us);
                        return;
                }
            }
        }
    }
}
