namespace TriangleFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest kolmurk, täisnurkne kolmnurk");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("\n\n");

            Console.WriteLine("Sisesta ridade arv");
            int i, j, rows;
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}