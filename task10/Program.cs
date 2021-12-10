using System;

namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //9 reqemli ededdi tek yerde dayananlardan bir eded duzlet, sonra cut yerde dayanlarinda bir eded duzlet,sonra onlari topla
            l1:
            int a = ReadInteger("9 reqemli eded daxil edin: ");
            if (a >= 100000000 && a < 1000000000)
            {
                a = Tekyerdedayananlar(a) + Cutyerdedayananlar(a);
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
        static int Tekyerdedayananlar(int a)
        {

            int num1, num3, num5, num7, num9, b;
            num1 = a / 100000000;
            num3 = (a / 1000000) % 10;
            num5 = (a / 10000) % 10;
            num7 = (a / 100) % 10;
            num9 = a % 10;
            b = (num1 * 10000) + (num3 * 1000) + (num5 * 100) + (num7 * 10) + num9;


            return b;
        }
        static int Cutyerdedayananlar(int a)
        {

            int num2, num4, num6, num8, b;
            num2 = (a / 10000000)%10;
            num4 = (a / 100000) % 10;
            num6 = (a / 1000) % 10;
            num8 = (a / 10) % 10;
            b = (num2 * 1000) + (num4 * 100) + (num6 * 10) + num8;


            return b;
        }
    }
}
