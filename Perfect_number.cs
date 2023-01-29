using System;


namespace Perfect_number
{
    internal class Perfect_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int n=int.Parse(Console.ReadLine());
            int number = n;
            int factor = 1;
            for(int i=2; i<=n/2; i++)
            {
                if (number % i == 0)
                {
                    factor += i;
                }
            }
            if (factor == n)
            {
                Console.WriteLine($"{n} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{n} is  not a perfect number");
            }
        }
    }
}
