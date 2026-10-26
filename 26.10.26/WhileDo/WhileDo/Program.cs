namespace WhileDo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("While do");

            int nr = int.Parse(Console.ReadLine();
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
                Thread.Sleep(1000);

            } while (i <= nr);

        }
    }
}
