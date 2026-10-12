namespace SwitchColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Sisesta värv (Red, Green, Blue, White, Orange): ");  // -- Värvide valik
            string varv = Console.ReadLine();  // -- loeb su inputi

            
            switch (varv)
            {
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red; // -- Punane
                    Console.Clear();
                    Console.WriteLine("Tekst on punane");
                    break;

                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green; // -- Roheline
                    Console.Clear();
                    Console.WriteLine("Tekst on roheline");
                    break;

                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue; // -- Sinine
                    Console.Clear();
                    Console.WriteLine("Tekst on sinine");
                    break;

                case "White":
                    Console.ForegroundColor = ConsoleColor.White; // -- Valge
                    Console.Clear();
                    Console.WriteLine("Tekst on valge");
                    break;

                case "Orange": 
                    Console.ForegroundColor = ConsoleColor.DarkYellow;  // -- Orants vms
                    Console.Clear();
                    Console.WriteLine("Tekst on orange");
                    break;

                default:
                    Console.ResetColor();
                    Console.WriteLine("Värv puudub");  // -- paha valik vist
                    break;
            }

            
            Console.ResetColor();
        }
    }
}