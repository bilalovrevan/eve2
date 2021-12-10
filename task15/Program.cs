using System;

namespace task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //       5 dene eded daxil et. Bunlarda 2 denesi 3 reqemli. 2 denesi 6 reqemli. 1 denesi 7 reqemli olsun.
            //3 reqemli ededlerin cemini tap ve cavabin axirdan 2 denesini kvadratini tap.
            //Sonra alinan cavabin ustune 3 reqemli ededlerin bir birine yapishdirilmasindan sonra alinan ededei gel.
            //Cavabdan 7 reqemli ededin son 5 reqemini cix. 
            //Alinan neticenin uzerine 6 reqemlilerin ceminden alinan cavabin axirinci 3 dene ededini gel.
            //Neticenin uzerine 7 reqemli ededin reqemleri ceminin tersine duzulmesinden alinan cavabi gel.
            //Cavabin axirina 11 artir.
            //Sonra 7 reqemli ededin tek yerde dayan reqemlerinde alinan ededi cix.
            //Cavabin axirdan II reqemi ile axirinci reqemin arasina 88 elave et.
            
            l1:
            int a = ReadInteger("1ci 3 reqemli ededi daxil edin: ");
            int b = ReadInteger("2ci 3 reqemli ededi daxil edin: ");
            int d = ReadInteger("1ci 6 reqemli ededi daxil edin: ");
            int e = ReadInteger("2ci 6 reqemli ededi daxil edin: ");
            int f = ReadInteger("1ci 7 reqemli ededi daxil edin: ");
            int num1=0, num2=0, num3=0, num4=0, num5=0,num6=0,num7=0,x=0;
            if (a>=100 && a<1000 && b>=100 && b<1000 && d>=100000 && d<1000000 && e>=100000 && e<1000000 && f>=1000000 && f<10000000)
            {
                 num1= (a+b) % 100;
                 num2 = num1 * num1;
                 num3 = num2 + ((a * 1000) + b);
                 num4 = num3 - (a % 100000);
                 num5 = num4 + ((a + b) % 1000);
                 num6 =((num5+Tersineduzme(f))*100)+11;
                 num7 = num6 - Tekyerdedayanan(f);
                 x = ((((num7 / 10) * 100) + 88)*10) + (num7 % 10);
                Console.WriteLine($"Cavab: {x}");
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
       
     
        
      
        static int Tersineduzme(int a)
        {
            //1234567  =  28 82
            int num1, num2,num3,num4,num5,num6,num7,num8,num9,b;
            num1 = a / 1000000;
            num2 =( a / 100000)%10;
            num3 = (a / 10000) % 10;
            num4 = (a / 1000) % 10;
            num5 = (a / 100) % 10;
            num6 = (a / 10) % 10;
            num7 = a % 10;
            b = num1+num2+num3+num4+num5+num6+num7;
            num8 = b / 10;
            num9 = b % 10;
            b = (num9 * 10) + num8;
            return b;
        }
        static int Tekyerdedayanan(int a)
        {
            int num1, num3, num5, num7, b;
            num1 = a / 1000000;
            num3 = (a / 10000) % 10;
            num5= (a / 100) % 10;
            num7 = a % 10;
            b = (num1 * 1000) + (num3 * 100) + (num5 * 10) + num7;
            return b;
        }
    }
}
