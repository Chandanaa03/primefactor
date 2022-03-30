using System;

namespace primefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a, b;
            //Console.WriteLine("please enter integer ");
            //a = Convert.ToInt32(Console.ReadLine());

            //for (b = 2; b <= 1; b++)
            //{
            //    if (a % b == 0)
            //    {
            //        int x = 0;
            //        while(a%b==0)
            //        {
            //            a /= b;
            //            x++;
            //        }

            //        Console.WriteLine(b + "is a factor of " + a);
            //    }
            //}

            factor obj = new factor();
            obj.primefactors(50);






        }
    }
}