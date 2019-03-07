using System;


namespace interleave2arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 100; i++)
            {
                var val = chkprime(i);
                if (val)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

        }

        public static bool chkprime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
    }
}