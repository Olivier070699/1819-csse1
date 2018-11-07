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
        
        Console.WriteLine("De kaart bevat volgende zaken:");
        for(int i = 0; i <= 6; i++){
            Console.WriteLine(lijst[i] + " kost " + prijs[i] + " euro.");
        }

        Console.WriteLine("Wenst u te selecteren op naam, toets 1, of op volgnummer, toets 2?");
        int antw = Int32.Parse(Console.ReadLine());
            if(antw == 1){
                Console.WriteLine("Geef de naam op van het gene dat u wenst.");
                int name_antw = Int32.Parse(Console.ReadLine());
                for (int a = 0; a <= lijst.Length; a++)
                {
                    if(name_antw = lijst[a]){
                        Console.WriteLine("U had graag " + lijst[a] + " gehad? Dat is dan " + prijs[a] + "euro");
                    }else{
                        Console.WriteLine("U heeft een foutieve naam opgegeven");
                    }
                }
            }else if(antw == 2){
                Console.WriteLine("Geef het volgnummer van het gene dat u wenst.");
                int number_antw = Int32.Parse(Console.ReadLine());
                int correct_number = number_antw - 1;
                if(correct_number <= 6 && correct_number>=0){
                    Console.WriteLine("U had graag een " + lijst[correct_number] + " gehad? Dat is dan " + prijs[correct_number] + " euro");
                }else{
                    Console.WriteLine("U heeft een onheldig nummer ingegeven.");
                }
            }
        }
    }
}
