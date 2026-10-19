using System;

namespace SwitchBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sisesta number: ");
            string sisestus = Console.ReadLine();

            // -- taisarvu teiseldamine
            if (int.TryParse(sisestus, out int number))
            {
                // -- kasutame switchi konstruktsiooni vahede kontrollimiseks
                switch (number)
                {
                    case >= 0 and <= 100:  // -- naide switchi konstruktsioonist lel
                        Console.WriteLine("number on vahemikus 0 kuni 100 vist");
                        break;

                    case >= 101 and <= 200:
                        Console.WriteLine("number on vahemikus 101 kuni 200 vist");
                        break;

                    case >= 201 and <= 300:
                        Console.WriteLine("number on vahemikus 201 kuni 300 vist");
                        break;

                    default:
                        Console.WriteLine("number on väljaspool oodatd vahemiku voi negatiivne");
                        break;
                }
            }
            else
            {
                Console.WriteLine("err: input text pole oige number");
            }
        }
    }
}