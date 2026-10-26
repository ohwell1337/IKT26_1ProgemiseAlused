namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta esimene number");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Vali tehe: +");
            string tehe = Console.ReadLine();

            Console.WriteLine("Sisesta teine number!");
            float number2 = float.Parse(Console.ReadLine());

            float tulemus = 0;
            bool korrektneTehe = true;

            switch (tehe)
            {
                case "+":
                    tulemus = number1 + number2;
                    break;

                default:
                    Console.WriteLine("Pole liitmine.");
                    korrektneTehe = false;
                    break;
            }

            if (korrektneTehe)
            {
                Console.WriteLine("jou");
                // -- ???????????????????????????????????????????
                Console.WriteLine("Meetodi esile kutsumiseks kirjuta ja");
                string method = Console.ReadLine();
                if (method == "ja")
                {
                    Skibidimethod();
                }
                else
                {
                    Console.WriteLine("Ise ei tahtnud");
                }
            }

            static void Skibidimethod()
            {
                Console.WriteLine("Auh");
            }
        }
    }

}