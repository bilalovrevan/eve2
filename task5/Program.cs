using System;

namespace task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 6 reqemli ededin 1 ci reqemini hemin ededin axirina at.
            //123456
            l1:
            int a = ReadInteger("6 reqemli eded daxil edin: ");
            if (a>=100000 && a<1000000)
            {

                a = Firstdigittolast(a);
                Console.WriteLine($"Cavab: {a}");
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
            catch (Exception)
            {
                Console.WriteLine("Yeniden cehd edin");
            }
            goto l1;
        }
        static int Firstdigittolast(int b)
        {
            if (b >= 100000 && b < 1000000)
            {
                int num1 = b / 100000;
                b = b - (num1 * 100000);
                b = ((b * 10) + num1);
                
            }
            return b;

        }
    }
}
