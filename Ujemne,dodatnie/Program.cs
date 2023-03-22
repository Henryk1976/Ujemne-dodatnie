using System;

namespace Ujemne_dodatnie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");

            string liczba = Console.ReadLine();

            Console.WriteLine("Twoja liczba " + liczba);

            int a = int.Parse(liczba);


            if (a > 0)
            {
                Console.WriteLine(liczba + " jest liczbą dodatnią");



            }
            else Console.WriteLine(liczba + " jest liczbą ujemną");


        }
    }
}
