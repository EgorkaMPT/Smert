using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smertь
{
    internal class Tovar
    {
        static int sol = 2;
        static string[] solt = new string[3] {"Название", "Кол-во", "Цена"};

        public static void Info()
        {
            ConsoleKey Key;
            Console.Clear();
            int i = 2;
            while(true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Добро пожаловать в наш магазин");
                Console.WriteLine("Выбирите пожайлуста категорию товаров");
                sol = 2;
                foreach (string sl in Mg.solty)
                {
                    Console.SetCursorPosition(3, sol);
                    Console.WriteLine(sl);
                    sol++;
                }
                Key = Console.ReadKey().Key;
                Console.Clear();
                switch(Key)
                {
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.RightArrow:
                        if(i < Mg.solty.Count)
                        {
                            i++;
                        }
                        else
                        {
                            i = 2;
                        }
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine("-->");
                        break;
                    case ConsoleKey.UpArrow:
                    case ConsoleKey.LeftArrow:
                        if (i > 2)
                        {
                            i--;
                        }
                        else
                        {
                            i = Mg.solty.Count + 1;
                        }
                        Console.SetCursorPosition(0, i);
                        Console.WriteLine("-->");
                        break;
                    case ConsoleKey.Enter:
                        Pr();
                        break;
                    case ConsoleKey.Escape:
                        Console.WriteLine("Вы уходите без покупок, жалко, почему вы так(((((" +
                            "\nБудем рады вас снова увидеть" +
                            "\nВсего хорошего, досвидвния)");
                        break;
                }
            }
        }
        private static void Pr()
        {
            while(true)
            {
                Console.Clear();
                Console.SetCursorPosition(30, 0);
                Console.WriteLine(solt[2]);
                Console.SetCursorPosition(15, 0);
                Console.WriteLine(solt[1]);
                Console.SetCursorPosition(2, 0);
                Console.WriteLine(solt[0]);
                int i = 1; 
                    if (sol == 3)
                    {
                    Mg.Odnarazka();
                    }
                    else if (sol == 4)
                    {
                    Mg.Jaja();
                    }
                    else if (sol == 5)
                    {
                    Mg.Pod();
                    }
                ConsoleKey soll = Console.ReadKey().Key;
                switch(soll)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.Enter:
                        break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.UpArrow:
                        break;
                }
            }
        }
    }
}