using System;
namespace For_Challenges
{
    public class RCount
    {
        //Create a function that increases the number of R's within a particular
        //string.
        public static void R_Increase()
        {
            int Rnumbers = 8;
            string res = "Bu";
            for (int i = 0; i < Rnumbers; i++)
            {
                res += "r";
            }
            res += "p";
            Console.WriteLine(res);
        }
    }
}