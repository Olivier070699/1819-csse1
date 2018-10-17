using System;

namespace lesweek4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // //REKENMACHINE
            // int a = 100;
            // int b = 7;
            // int d = 3;
            // int f = 406;
            // int g = 7367;
            // int j = 5;
            // int i = 69;
            // int l = 73;
            // int m = 41;
            // int o = 39;
            // int r = 8;     
            // int t = 19;
            // int uitkomst = (a+b)*d+(j*((f+g)/i))+((l*m)-o)+((b*r)-t);
            
            // Console.WriteLine("Het resultaat is " + uitkomst);
            Console.WriteLine("Hello World!");
            
            
            int f = vermenigvuldig(som(100 , 7) , 3);
            int g = vermenigvuldig(delen(som(406, 7367),69),5);
            int h = verschil(vermenigvuldig(73,41) ,39);
            int i = verschil(vermenigvuldig(7,8) , 19);
            int resultaat = result(f,g,h,i);
            Console.WriteLine(resultaat);

            if(resultaat == 3872){
                Console.WriteLine("Het resultaat is perfect!");
            }else if(resultaat > 3872){
                Console.WriteLine("Het resultaat is te groot!");
            }else{
                Console.WriteLine("Het resultaat is te klein");
            }


            for(int getal = 0; getal < 11; getal++){
                for(int maal = 0; maal <11; maal++){
                    Console.WriteLine(getal + " maal " + maal + " is gelijk aan " + getal*maal);
                }
            }
        }
            static int som(int a , int b){
            return a + b;
            }
            static int verschil(int a , int b){
                return a-b;
            }
            static int vermenigvuldig(int a , int b){
                return a * b;
            }
            static int delen(int a , int b){
                return a/b;
            }
            static int result(int a , int b, int c, int d){
                return a+b+c+d;
            }
    }
}
