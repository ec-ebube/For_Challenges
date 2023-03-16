using System;
namespace For_Challenges
{
    public class Factorial
    {
        //Create a function that returns a factorial of any given number
        public static void Numfactorial()
        {
            double digit = 5;
            double sum = 1;
            for (double i = digit; i > 0; i--)
            {
                sum =sum*i;
            }
            Console.WriteLine(sum);
        }

    }
}