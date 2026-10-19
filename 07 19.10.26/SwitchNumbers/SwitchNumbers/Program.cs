using System;

namespace SwitchNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tere immigrant");

            // -- numbri kusimine
            Console.Write("Sisesta palun number (10, 20, 30 voi 67): ");
            string sisend = Console.ReadLine();

            // -- tesiseldame taisarvuks ei tea kas on vajalik aga ok
            if (int.TryParse(sisend, out var number))
            {
                // -- caseid eh. numbrid 10-67 eni
                switch (number)
                {
                    case 10:
                        Console.WriteLine("Valisid koodi: (10)");
                        break;
                    case 20:
                        Console.WriteLine("Valisid koodi: (20)");
                        break;
                    case 30:
                        Console.WriteLine("Valisid koodi: (30)");
                        break;
                    case 67:
                        Console.WriteLine("Valisid koodi:  (67)");
                        break;
                    default:
                        Console.WriteLine($"Sisestasid numbri {number}, mis ei ole 10, 20, 30 ega 67.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("viga: sisestatud väärtus ei olnud korrektne number");
            }
        }
    }
}