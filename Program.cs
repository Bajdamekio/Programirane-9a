using System;

namespace _26._03._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] money = new double[7];
            double s = 0;
            for(int i = 0;i<7;i++)
            {
                Console.WriteLine("vavedi kolko pari sa vnesli klientite");
                money[i] = double.Parse(Console.ReadLine());
            }
            for(int i =0;i<7;i++)
            {
                Console.WriteLine(money[i]);
            }
            Console.WriteLine("sumata e {0:c2} " , s );
            double max = double.MinValue;
            for(int i =0;i<7;i++)
                if(max<money[i])
                {
                    max = money[i];
                }
            Console.WriteLine("maksimalnata stoynost e " + max);
            double min = double.MaxValue;
            for(int i =0;i<7;i++)
                if(min>money[i])
                {
                    min = money[i];
                }
            Console.WriteLine("minimalnata stoynost e " + min );
        }
    }
}
