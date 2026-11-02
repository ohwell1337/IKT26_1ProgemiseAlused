using System;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number:");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: :");
            string tehe = Console.ReadLine();

            Console.WriteLine("Sisesta teine number:");
            float number2 = float.Parse(Console.ReadLine());

            float tulemus = 0
            string kodulinn = "";

            for (int samm = 1; samm <= 3; samm++)
            {
                switch (samm)
                {
                    case 1:
                        // Lubatud on ainult jagamine.
                        if (tehe != "/") // -- ?? : voi / 
                        {
                            Console.WriteLine("Pole Jagamine.");
                            return;
                        }

                        tulemus = number1 / number2;
                        break;

                    case 2:
                        Console.WriteLine("Mis on sinu kodulinn?");
                        kodulinn = Console.ReadLine();
                        break;

                    case 3:
                        Console.WriteLine(string kodulinn)