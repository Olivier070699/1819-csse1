using System;

namespace opdracht2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 0;
            int second = 1;
            int stappen = 20;
            Console.WriteLine("Na " + stappen + " maal de regel van febonaci uit te voeren krijgen we volgende getallen:");
            for(int z=1; z <= stappen; z++){
                int fs = first+second;
                Console.WriteLine(fs);
                first = second;
                second = fs;
            }

            // faculteit
            int faculteit = 19;
            int ab = 1;
            for(int aa=1; aa<=faculteit; aa++){
                int product = ab*aa;
                ab = product;
            }
            Console.WriteLine("De faculteit van " + faculteit + " is gelijk aan " + ab);
        }
    }
}
