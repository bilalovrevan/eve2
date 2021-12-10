using System;

namespace task8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Verilmis ededdin axirdan 3-cu reqemi ile sonuncu reqeminin cemini tap
            //12345
            int a = ReadInteger("eded daxil edin: ");
            int b = 0;
            b = Axrincieded(a) + Axirdan3cueded(a);
            Console.WriteLine($"Cavab: {b}");

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
        static int Axirdan3cueded(int a)
        {
            int num = (a / 100)%10;
            return num;
        }
        static int Axrincieded(int a)
        {
            int num =a % 10;
            return num;
        }
    }
}
