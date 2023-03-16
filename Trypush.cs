using System;
namespace For_Challenges
{
    public class Trypush
    {
        /*Try creating a function that can push a 
        number into an array*/
        public static void For_arraypush()
        {
            int one = 1;
            int ten = 10;
            int[] myarr = new int[(ten-one)+1];
            // int adder = ten-one;
            int sum = 0;
            for (int i = 1; i <= 9; i++)
            {
                myarr[i] = i;
                sum += myarr[i];
                // adder--;
            }
            Console.WriteLine(myarr.Length);
                Console.WriteLine(sum);
        }
    }
}