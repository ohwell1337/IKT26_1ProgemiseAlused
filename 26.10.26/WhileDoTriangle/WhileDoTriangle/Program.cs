using System;

namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kuvatakse pealkiri ja küsitakse kasutajalt arvu
            Console.WriteLine("Kolmnurk");
            int n = Convert.ToInt32(Console.ReadLine());

            // Algväärtustame rea loenduri
            int rida = 1;

            // Välimine tsükkel: kordab tegevust seni, kuni pole jõutud soovitud ridade arvuni (n)
            while (rida <= n)
            {
                // Iga rea alguses alustame numbriga 1
                int veerg = 1;

                
                // Sisemine tsükkel: prindib numbreid ühele reale järjest juurde
                while (veerg <= rida)
                {
                    Console.Write(veerg + " "); // Prindib numbri ja tühiku ilma reavahetuseta
                    veerg++;                    // Suurendab veeru numbrit ühe võrra
                }

                Console.WriteLine(); // Kui rea numbrid on prinditud, tehakse reavahetus
                rida++;              // Liigutakse järgmise rea juurde
            }
        }
    }
}

/*
                 _____ ______ __  __ _____ _   _ _____ 
                / ____|  ____|  \/  |_   _| \ | |_   _|
               | |  __| |__  | \  / | | | |  \| | | |  
               | | |_ |  __| | |\/| | | | | . ` | | |  
               | |__| | |____| |  | |_| |_| |\  |_| |_ 
                \_____|______|_|  |_|_____|_| \_|_____|
            */