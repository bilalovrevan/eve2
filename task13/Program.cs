using System;

namespace task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        3 dene 5 reqemli eded var.
            //Her bir  ededin ilk ve son reqemlerininden 1 eded duzlet. Alinan neticeleri topla
            //Yekunda alian cavabin 50 % -ni hemin ededin uzerine gel.
            l1:
            int a = ReadInteger("1ci 5 reqemli ededi daxil edin: ");
            int b = ReadInteger("2ci 5 reqemli ededi daxil edin: ");
            int c = ReadInteger("3cu 5 reqemli ededi daxil edin: ");
            if (a>=10000 && a<100000 && b >= 10000 && b < 100000 &&  c >= 10000 && c < 100000)
            {
                a = Bunlardanduzeleneded(Ilkreqem(a), Sonuncureqem(a));
                b = Bunlardanduzeleneded(Ilkreqem(b), Sonuncureqem(b));
                c = Bunlardanduzeleneded(Ilkreqem(c), Sonuncureqem(c));
                int d = a + b + c;
                d = d + (d * 50) / 100;
                Console.WriteLine($"Cavab: {d}");
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
        static int Ilkreqem(int a)
        {
            a = a / 10000;
            return a;
        }
        static int Sonuncureqem(int a)
        {
            a = a %10;
            return a;
        }
        static int Bunlardanduzeleneded(int a,int b)
        {
            int c = (a * 10) + b;
            return c;
        }
        
        
    }
}
