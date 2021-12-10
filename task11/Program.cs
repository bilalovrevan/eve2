using System;

namespace task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 reqemli ededin reqemlerini iki -iki qruplashdir. 
            // Qruplarin cemini tap.Alinan cavabin axirina 99 artir.
            //Sonra cavabin ozunden onun 18 % ni cix;
            // 12345678 = 12 + 34 + 56 + 78 = 18099 - (18099 * 0.18)
            l1:
            int a = ReadInteger("8 reqemli eded daxil edin: ");
            if (a>=10000000 && a<100000000)
            {
                a = IkiIkiQruplasdirma(a);
                a = a * 100 + 99;
                double b=a-(a*0.18);
                Console.WriteLine($"Cavab: {b}");
            }
            
            goto l1;
        }
        static int ReadInteger(string caption)
        {
        l1:
            try
            {
                Console.Write(caption);
                int a =Convert.ToInt32( Console.ReadLine());
                return a;
            }
            catch (Exception)
            {
                Console.WriteLine("Yeniden cehd edin");
            }
            goto l1;
        }
        static int IkiIkiQruplasdirma(int a)
        {
            int num12, num34, num56, num78, b;
            num12 = a / 1000000;
            num34 = (a / 10000) % 100;
            num56 = (a / 100) % 100;
            num78 = a % 100;
            b=num12+ num34+num56+num78;
            return b;
        }

        
    }
}
