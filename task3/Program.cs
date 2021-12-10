using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //verilmihs 9 reqemli ededin duz ortaya dushen 3 reqeminin reqemleri cemi
            Console.Write("9 reqemli eded daxil edin: ");
            int a=Convert.ToInt32(Console.ReadLine());
            a = Ortayadusen3reqem(a);
            Console.WriteLine(Reqemlerincemi(a));
        }
        private static int Reqemlerincemi(int a)
        {
           

            int num = 0;
            int sum = 0;

            {
                while (a > 0)
                {
                    num = a % 10;
                    a = (a - num) / 10;
                    sum = sum + num;

                }

            }
            return sum;
        }
        private static int Ortayadusen3reqem(int a)
        {
            //123456789
            int orta3 = a / 1000;
            orta3 = orta3 % 1000;
            return orta3;
          
        }
    }
}
