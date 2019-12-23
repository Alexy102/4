using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int sum(int x)
        {
            if (x > 9 && x < 100) //если число содержит 2 разряда
                return x / 10 + x % 10;
            if (x > 99 && (x < 1000)) //если число содержит 3 разряда
                return x / 100 + x / 10 % 10 + x % 10;
            return 0;
        }
        static void Main(string[] args)
        {
            bool t;
            for (int i = 10; i < 100; i++)
            {
                t = true;
                for (int j = 2; j < 10; j++)
                {
                    if (sum(i) != sum(i * j))
                    {
                        t = false;
                        break;
                    }
                }
                if (t)
                    Console.WriteLine(i);
            }
        }
    }
}
