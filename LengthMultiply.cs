using System;
namespace For_Challenges
{
    public class LengthMultiply
    {
        /*Create a function that multiplies each number in an array
        by the length of the array*/
        public static void LengthMultiplication()
        {
            int[] mainarr = { 2, 4, 6, 8 };
            for (int i = 0; i < mainarr.Length; i++)
            {
                mainarr[i] = mainarr[i] * mainarr.Length; 
            }
            foreach (var item in mainarr)
            {
                Console.WriteLine(item);
            }
        }
    }
}