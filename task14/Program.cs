using System;

namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //         4 dene eded daxil et. Bunlardan 3 denesi 6 reqemli bir denesi ise 7 reqemli olsun.
            // 6 reqemli ededlerin her birinin ilk 3 reqeminden alinan ededleri topla.
            // Neticenin uzerine 7 reqemli ededin son 4 reqeminden alinan ededi gel
            // Alinan cavabdan cix 7 reqemli ededdin ilk 3 dene reqeminin bir birine vurulmasindan alinan cavabi.
            // Neticenin 60 % tap.Cavabin axirina 60 artir.
            //Neticeden 18 % cix.
            int a;
            int b;
            int c;
            int d;

            l1:
            a = ReadInteger("1ci 6 reqemli ededi daxil edin: ");
            b = ReadInteger("2ci 6 reqemli ededi daxil edin: ");
            c = ReadInteger("3cu 6 reqemli ededi daxil edin: ");
            d = ReadInteger("1ci 7 reqemli ededi daxil edin: ");
            if (a>=100000 && a<1000000 && c >= 100000 && c < 1000000 && b >= 100000 && b < 1000000 && d>=1000000 && d<10000000)
            { 
               int e = ((Ilk3reqemi(a) + Ilk3reqemi(b) + Ilk3reqemi(c)) + Son3reqemi(d)) - Ilk3reqeminhasili(d);
               int f = ((e * 60)/100)  + 60;
               double g = f - (f * 0.18);
                Console.WriteLine($"Cavab: {g}");
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
        static int Ilk3reqemi(int a)
        {
            
           a = a / 1000;
            return a;

        }
        static int Son3reqemi(int a)
        {
            a = a % 10000;
            return a;
        }
        static int Ilk3reqeminhasili(int a)
        {
            int num1, num2, num3, b;
            num1 = (a / 1000000) % 10;
            num2 = (a / 100000) % 10;
            num3 = (a / 10000) % 10;
            b = num1 * num2 * num3;
            return b;
        }
    }
}
