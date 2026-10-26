using System;

namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try-catch!");

            try
            {
                int nr = int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case 1:
                        Console.WriteLine("Valisid 1");
                        break;
                    case 2:
                        Console.WriteLine("Valisid 2");
                        break;
                }
            }
            // -- vormi viga
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta number");
            }
            // -- 
            catch
            {
                Console.WriteLine("Number on liiga suur");
            }
        }
    }
}