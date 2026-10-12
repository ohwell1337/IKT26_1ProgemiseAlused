namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerib numbreid ühest kuni kuueni");

            int randomNumber = new Random().Next(1, 7);

            switch (randomNumber)
            {
                case 1:
                    Console.WriteLine("Veeres number 1!"); // -- 1 veeretamine
                    break;

                case 2:
                    Console.WriteLine("Veeres number 2!"); // -- 2 veeretamine
                    break;

                case 3:
                    Console.WriteLine("Veeres number 3!"); // -- 3 veeretamine
                    break;

                case 4:
                    Console.WriteLine("Veeres number 4!"); // -- 4 veeretamine
                    break;

                case 5:
                    Console.WriteLine("Veeres number 5!"); // -- 5 veeretamine
                    break;

                case 6:
                    Console.WriteLine("Veeres number 6!"); // -- 6 veeretamine
                    break;

                default:
                    Console.WriteLine("ei tea mis number tuli"); // -- ?????????
                    break;
            }
        }
    }
}
