using System;

namespace Reverse_number
{
    internal class Reverse_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to reverse the number");
            int n=int.Parse(Console.ReadLine());
            int number = n;
            int sum = 0;
            while(number>0)
            {
                int rem=number%10;
                sum =(sum*10)+ rem;
                number=number/10;
                
            }
            Console.WriteLine($"Reverse number = {sum}");
        }
    }
}
