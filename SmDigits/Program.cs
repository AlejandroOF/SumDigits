using System;

namespace SmDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e, f;

            Console.WriteLine("Enter number");
            int num = Int32.Parse(Console.ReadLine());

            if (num < 100)
            {
                a = num / 10;
                b = num % 10;
                Console.WriteLine(a + b);
            }

            if (num < 1000)
            {
                a = num / 100;
                b = (num % 100) / 10;
                c = (num % 100) % 10;
                Console.WriteLine(a + b + c);
            }

            if (num < 10000)
            {
                a = num / 1000;
                b = (num % 1000) / 100;
                c = ((num % 1000) % 100) / 10;
                d = ((num % 1000) % 100) % 10;


                Console.WriteLine(a + b + c + d);
            }

            if (num < 100000)
            {
                a = num / 10000;
                b = (num % 10000) / 1000;
                c = ((num % 10000) % 1000) / 100;
                d = (((num % 10000) % 1000) % 100) / 10;
                e = (((num % 10000) % 1000) % 100) % 10;

                Console.WriteLine(e);
            }


            if (num < 1000000)
            {
                a = num / 100000;
                b = (num % 100000) / 10000;
                c = ((num % 100000) % 10000) / 1000;
                d = (((num % 100000) % 10000) % 1000) / 100;
                e = ((((num % 100000) % 10000) % 1000) % 100)/10;
                f = (((num % 100000) % 10000) % 1000) % 10;

                Console.WriteLine(a+b+c+d+e+f);
            }

            if( num < 1000000)
            {
                Console.WriteLine("Error perro");
            }


            Console.ReadKey();
        }
    }
}
