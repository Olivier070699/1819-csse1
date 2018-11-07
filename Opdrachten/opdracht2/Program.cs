using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // febonaci
            int first = 0;
            int second = 1;
            Console.WriteLine("Hoeveel keer mag de regel van febonaci uigevoerd worden?");
            int stappen = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Na " + stappen + " maal de regel van febonaci uit te voeren krijgen we volgende getallen:");
            for(int z=1; z <= stappen; z++){
                int fs = first+second;
                Console.WriteLine(fs);
                first = second;
                second = fs;
            }

            // faculteit
            Console.WriteLine("Geef een getal om de faculteit van te bereken");
            int faculteit = Int32.Parse(Console.ReadLine());
            int ab = 1;
            for(int aa=1; aa<=faculteit; aa++){
                int product = ab*aa;
                ab = product;
            }
            Console.WriteLine("De faculteit van " + faculteit + " is gelijk aan " + ab);

            // ALLE TAFELS
            for (int x = 0; x <= 10; x++){
                Console.WriteLine("De tafel van " + x + ":");
                for (int y = 0; y <= 10; y++){
                    int uitkomst = y*x;
                    Console.WriteLine(y + " maal " + x + " is gelijk aan " + uitkomst);
                }
            }

            // VERMENIGVULDIGEN
            Console.WriteLine("Geef een specifiek getal om nog eens te vermenigvuldigen");
            int tafel = Int32.Parse(Console.ReadLine()); // GETAL OPVRAGEN
            for (int i = 0; i <= 10; i++)
            {
                int vermenigvuldiging = tafel*i;
                Console.WriteLine(tafel + " maal " + i + " is gelijk aan " + vermenigvuldiging);
            }
        }
    }
}
