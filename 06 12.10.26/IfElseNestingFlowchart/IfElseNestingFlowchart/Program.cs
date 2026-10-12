namespace IfElseNestingFlowchart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If ja else nesting");

            string input = Console.ReadLine();

            if  (input == "auto")
            {
                Console.WriteLine("Sisesta auto suurus");
                string size = Console.ReadLine();
                if (size == "sedaan")
                {
                    Console.WriteLine("Valisid sedaani");
                }
                else if (size == "kabriolet")
                {
                    Console.WriteLine("Valisid kabrioleti");
                }
                else
                {
                    Console.WriteLine("Valisid muu auto");
                }
            }
            else
            {
                Console.WriteLine("Valisid muu sõiduki");
            }
        }
    }
}