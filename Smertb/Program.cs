using System.Text.Json;

namespace Smertь
{
    internal class Program
    {
        public const string sav = "\"C:\\Users\\Home\\OneDrive\\Рабочий стол\\Save.Json\"";
        public static string a = null;
        public static List<Adm> us;
        static void Main(string[] args)
        {
            if (File.Exists(sav))
            {
                us = L(sav);
            }
            else 
            {
                us = new List<Adm> { new Adm(1, "admin", "1111", R.Adm), new Adm(2, "user", "1234", R.Adm)};
            }
            while (true)
            {
                Console.WriteLine("Введите логин");
                var log = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                var pass = "";
                while (true)
                {
                    var info = Console.ReadKey(true);
                    if (info.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                    pass += info.KeyChar;
                    Console.Write('*');
                }
                Console.WriteLine();
                foreach (var user in us)
                {
                    if(log == user.Lg && pass == user.Pass)
                    {
                        a = log;
                    }
                }
                if (a != null)
                {
                    break;
                }
                Console.Clear();
                Console.WriteLine("Вы ввели неправильные данные");
            }
            if (a == "admin")
            {
                Admin.Adm();
            }
            else if (a == "user")
            {
                Tovar.Info();
            }
        }
        private static List<Adm> L(string sav)
        {
            return JsonSerializer.Deserialize<List<Adm>>(File.ReadAllText(sav));
        }
        public static void Save(string sav, List<Adm> us)
        {
            File.WriteAllText(sav, JsonSerializer.Serialize(us));
        }
    }
}