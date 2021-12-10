using System;

namespace task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //        2 dene 5 reqemli eded daxil et. 
        //I ededin reqemleri ceminin usutne II ededin reqemleri hasilini gel.
        //Neticenin axirina I ededin en axiinci reqemini artir.
        //12345 54321 
        l1:
            int a = ReadInteger("1ci 5 reqemli ededi daxil edin: ");
            int b = ReadInteger("2ci 5 reqemli ededi daxil edin: ");
            if (a >= 10000 && a < 100000 && b >= 10000 && b < 100000)
            {
                int d=SumOfDigits(a);
                b=MultiplyOfDigits(b);
                int c = ((d + b) * 10) + (a%10);
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
            catch (Exception)
            {
                Console.WriteLine("Yeniden cehd edin");
            }
            goto l1;

        }
        static int SumOfDigits(int n)
        {
            int m;
            int sum = 0;
            while (n > 0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            return sum;
        }
        static int MultiplyOfDigits(int n)
        {
            int m;
            int hasil = 1;
            while (n>0)
            {
                m = n % 10;
                hasil = hasil * m;
                n = n / 10;

            }
            return hasil;
        }
        
       

    }
}
