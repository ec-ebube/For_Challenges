using System;
namespace For_Challenges
{
    public class MultiTable
    {
        /*create a function that prints the 
        multiplication of a given number*/
        public static void ForMultiplication()
        {
            double num = Convert.ToDouble(Console.ReadLine());
            double multians;
            for (double i = 1; i <= 12; i++)
            {
                multians = num * i;
                Console.WriteLine(multians);
            }
        }
    }
}