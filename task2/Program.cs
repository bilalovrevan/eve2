using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // verilmihs 6 reqemli ededin ilk 3 denesinin reqemleri cemi tap: example: 123600 = 1 + 2 + 3
            l1:
            Console.WriteLine("6 reqemli eded daxil edin: ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=100000 && a<=1000000)
            {
                a = Ilk3reqemi(a);
                Console.WriteLine(Reqemlerincemi(a));
            }
            goto l1;
        }
        //123456
        private static int Ilk3reqemi(int a)
        {
            int ilk = a/1000;

            return ilk;
        }
        private static int Reqemlerincemi(int a)
        {
            //2048

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
    }
}

