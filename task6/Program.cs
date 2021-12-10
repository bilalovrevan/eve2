using System;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmihs 8 reqemli ededin ilk I ve axirinci reqemlerini legv et 
            int a = ReadInteger("8 reqemli eded daxil edin: ");
            a=Firsdigitdelete(a);
            a=Lastdigitdelete(a);
            Console.WriteLine($"cavab: {a}");
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
        static int Firsdigitdelete(int a)
        {
            int num1 = 0;
            num1 = a / 10000000;
            a = a-(num1 * 10000000);
            return a;
        }
        static int Lastdigitdelete(int a)
        {
            int num1;
            num1 = a % 10;
            a =( a - num1)/10;
            return a;
        }
    }
}
