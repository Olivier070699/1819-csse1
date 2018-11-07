using System;

namespace opdracht3
{
    class Program
    {
        static void Main(string[] args)
        {      
        string[] lijst = new string[7];
        lijst[0] = "Plat Water";
        lijst[1] = "Cola 25 cl";
        lijst[2] = "Cola 33 cl";
        lijst[3] = "Witte Wijn";
        lijst[4] = "Pils";
        lijst[5] = "Toast";
        lijst[6] = "Kaasplank";

        string[] prijs = new string[7];
        prijs[0] = "1";
        prijs[1] = "1,50";
        prijs[2] = "2";
        prijs[3] = "3";
        prijs[4] = "2";
        prijs[5] = "5";
        prijs[6] = "4";
        
        for(int i = 0; i <= 6; i++){
            Console.WriteLine(lijst[i] + " kost " + prijs[i] + " euro.");
        }
        }
    }
}
