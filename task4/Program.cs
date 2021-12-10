using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            l1:
            //verilmihs 5 reqemli ilk ve son reqemlerinin ceminin kvadrati
            //12345
           int a=ReadInteger("5 reqemli ede daxil edin: ");
            if (a>=10000 && a<100000)
            {
                int num1 = a % 10;
                int num2 = a / 10000;
                int c = (num1 + num2) * (num1 + num2);
                Console.WriteLine($"Cavab: {c}");
            }
            goto l1;
        }
         static int ReadInteger(string caption)
        {
            l1:
            try
            {
                Console.Write(caption);
                int a = Convert.ToInt32(Console.ReadLine());
                return a;
            }
            catch (Exception )
            {
                Console.WriteLine("Yeniden cehd edin");
            }
            goto l1;
        }
         static int Reqemlerincemi(int a)
        {


            int num = 0;
            int sum = 0;

            {
                while (a > 0)
                {
                    num = a % 10;
                    a = (a - num) / 10;
                    sum = sum + num;

                }

            }
            return sum;
        }
    }
}
