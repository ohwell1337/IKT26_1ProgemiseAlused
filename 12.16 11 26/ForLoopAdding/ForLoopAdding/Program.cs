namespace ForLoopAdding
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Sisesta korduste arv");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("\n\n");

            int kordused = int.Parse(Console.ReadLine());

            for (int a = 0; a < kordused; a++) // -- esimene kill koll
            {
                for (int b = 0; b < 2; b++) // -- teine killadi koll
                {        
                    Console.WriteLine("kill - koll");
                }
                Console.WriteLine("killadi - koll");
            }
        }
    }
}
