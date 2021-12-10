using System;

namespace eve2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1:
            Console.WriteLine("4 reqemli eded daxil edin: ");
            int a = (Convert.ToInt32(Console.ReadLine()));
            if (a>=1000 && a<10000)
            {
                Console.WriteLine(Reqemlerincemi(a));
            }
            goto l1;
        }
       private static int Reqemlerincemi(int a)
        {
            //2048

            int num = 0;
            int sum = 0;
            
            {
                while (a>0)
                {
                    num =a%10;
                    a = (a-num)/10;
                    sum = sum + num;

                }
                
            }
            return sum;
        }
    }
}
