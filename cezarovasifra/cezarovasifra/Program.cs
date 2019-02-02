using System;

namespace cezarovasifra
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string s = "jonkojefrajerlebomaradmorskekonky";
            Console.WriteLine("Povodna sprava; {0}", s);
            string sprava = "";
            int posun = 1;

            foreach (char c in s)
            {
                int i = (int)c;
                i += posun;
                char znak = (char)i;
                sprava += znak;

            }
            Console.WriteLine("Zasifrovana sprava: {0}", sprava);
            Console.WriteLine("kubekjefrajer");
            Console.ReadKey();

        }
    }
}
