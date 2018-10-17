using System;

namespace lesweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // REKENMACHINE

            int c, d;
            int a = 5;
            int b = 6;
            int resultaat1 = optellen(int a, int b);
            int resultaat2 = deling(int a, int b);
            int resultaat3 = verhogen(int a);
        }

        static int optellen(int a, int b){
            return a + b;
        }

        static int verhogen(int a){
            return a++;
        }

        static int deling(int a, int b){
            return a/b;
        }
    }
};
