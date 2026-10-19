using System;

namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  -- kusime esimest numbrit ja parsime floadiga
            Console.WriteLine("Sisesta esimene number!");
            float number1 = float.Parse(Console.ReadLine());

            // -- kusime tehte symbolit
            Console.WriteLine("Vali tehe: *, /, +, -");
            string tehe = Console.ReadLine();

            // -- kusime teist numbrit ja kasutame floati
            Console.WriteLine("Sisesta teine number:");
            float number2 = float.Parse(Console.ReadLine());

            // 
            float tulemus = 0;
            bool korrektneTehe = true;

            // -- Nüüd tuleb teha switchi valik kas *, /, +, - 
            // -- Tuleb neli case kus toimub su tehe
            switch (tehe)
            {
                case "*":
                    tulemus = number1 * number2;
                    break;

                case "/":
                    // -- kontrollime et nulliga ei jagataks
                    if (number2 != 0)
                    {
                        tulemus = number1 / number2;
                    }
                    else
                    {
                        Console.WriteLine("viga: nulliga ei saa jagada");
                        korrektneTehe = false;
                    }
                    break;

                case "+":
                    tulemus = number1 + number2;
                    break;

                case "-":
                    tulemus = number1 - number2;
                    break;

                default:
                    Console.WriteLine("Tundmatu tehe!");
                    korrektneTehe = false;
                    break;
            }

            // -- peab näitama tehte tulemust, sp kasutame dollari asja 
            if (korrektneTehe)
            {
                Console.WriteLine($"Tulemus: {number1} {tehe} {number2} = {tulemus}");
            }
        }
    }
}