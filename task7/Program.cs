using System;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //verilmihs 4 reqemli ededin tersine duzub axirina ve evveline 8 artir
        //1234
        l1:
            int a = ReadInteger("4 reqemli eded daxil edin: ");

            if (a>=1000 && a<10000)
            {

                a = Tersindeduzme(a);
                a = Evveline8(a);
                a = Sonuna8(a);
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
        static int Tersindeduzme(int a)
        {
            int b = 0;
            int num1, num2, num3, num4;
            num4 = a % 10;
            a = a /10;
            num3 = a % 10;
            a=a/10;
            num2 = a % 10;
            a = a /10; 
            num1 = a % 10;
            
           
            b=(num4*1000)+(num3*100)+(num2*10)+num1;
            return b;

        }
        static int Evveline8(int a)
        {
            a = a + 80000;
            return a;
        }
        static int Sonuna8(int a)
        {
            a = (a*10) + 8;
            return a;
        }
    }
}
