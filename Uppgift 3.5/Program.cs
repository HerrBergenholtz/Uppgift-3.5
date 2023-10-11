using System;

namespace Uppgift_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal såhär \"10 5\"");
            string tvåTal = Console.ReadLine();
            int mellanslagsindex = tvåTal.IndexOf(" ");
            int tal1 = int.Parse(tvåTal[..mellanslagsindex]);
            int tal2 = int.Parse(tvåTal[(mellanslagsindex + 1)..]);

            Console.WriteLine("Välj ditt favorit räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");

            string val = Console.ReadLine();

            switch (val)
            {
                case "1":
                    Console.WriteLine(tal1 + tal2);
                    break;
                case "2":
                    Console.WriteLine(tal1 - tal2);
                    break;
                case "3":
                    Console.WriteLine(tal1 * tal2);
                    break;
                case "4":
                    Console.WriteLine(tal1 / tal2);
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}