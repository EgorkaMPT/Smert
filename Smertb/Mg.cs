using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smertь
{
    internal class Mg
    {
        public string nam;
        public int kolvo;
        public int prise;
        public static List<Mg> sale;
        public static List<string> solty = new() { "Однаразка", "Жижа", "Под", "Закончить" };
        
        public Mg(string Nam, int Kolvo, int Prise)
        {
            this.nam = Nam;
            this.kolvo = Kolvo;
            this.prise = Prise;
        }

        public Mg() { }

        public static void Odnarazka()
        {
            sale = new() { new Mg("HqD - 350 тяг", 40, 299), new Mg("HqD - 600 тяг", 45, 599), new Mg("HqD - 1200 тяг", 50, 899), new Mg("HqD - 2500 тяг", 80, 1190) };
            foreach (var it in sale) 
            {
                for (int i = 1; i < sale.Count; i++)
                {
                    Console.SetCursorPosition(3, i);
                    Console.WriteLine(it.nam);
                    Console.SetCursorPosition(15, i);
                    Console.WriteLine(it.kolvo);
                    Console.SetCursorPosition(27, i);
                    Console.WriteLine(it.prise);
                }
            }
        }
        public static void Jaja()
        {
            sale = new() { new Mg("Brusko - 50 мг, 30мл", 110, 449), new Mg("HqD - 50 мг, 50 мл", 145, 499), new Mg("HqD - 20 мг, 50 мл", 150, 399), new Mg("Brusko - 20 мг, 30 мл", 150, 349) };
            foreach (var it in sale)
            {
                for (int i = 1; i < sale.Count; i++)
                {
                    Console.SetCursorPosition(3, i);
                    Console.WriteLine(it.nam);
                    Console.SetCursorPosition(15, i);
                    Console.WriteLine(it.kolvo);
                    Console.SetCursorPosition(27, i);
                    Console.WriteLine(it.prise);
                }
            }
        }
        public static void Pod()
        {
            sale = new() { new Mg("SMOK Nova 2", 100, 1599), new Mg("vooPoo Drag S Pod 60W", 130, 2799), new Mg("Smoant Pasito", 150, 2399), new Mg("Smoant Charon Baby", 100, 1490) };
            foreach (var it in sale)
            {
                for (int i = 1; i < sale.Count; i++)
                {
                    Console.SetCursorPosition(3, i);
                    Console.WriteLine(it.nam);
                    Console.SetCursorPosition(15, i);
                    Console.WriteLine(it.kolvo);
                    Console.SetCursorPosition(27, i);
                    Console.WriteLine(it.prise);
                }
            }
        }
    }
}
