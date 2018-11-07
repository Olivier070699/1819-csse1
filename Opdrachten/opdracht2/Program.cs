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
            int stappen = 20;
            Console.WriteLine("Na " + stappen + " maal de regel van febonaci uit te voeren krijgen we volgende getallen:");
            for(int z=1; z <= stappen; z++){
                int fs = first+second;
                Console.WriteLine(fs);
                first = second;
                second = fs;
            }

            // faculteit
            int faculteit = 5;
            int ab = 1;
            for(int aa=1; aa<=faculteit; aa++){
                int product = ab*aa;
                ab = product;
            }
            Console.WriteLine("De faculteit van " + faculteit + " is gelijk aan " + ab);

            // tafels
            int start = 5;
            for(int zz=0; zz<=10; zz++){
                int vermeningvuldigen = 5*zz;
                Console.WriteLine(start + "x" + zz + "=" + vermeningvuldigen);
            }
        }
    }
}
