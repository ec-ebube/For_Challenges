using System;
namespace For_Challenges
{
    public class Stringstrength
    {
        public static void HigherString()
        {
            string firststring = "30";
            string secondstring = "54";
            int firstnum = Convert.ToInt32(firststring);
            int secondnum = Convert.ToInt32(secondstring);
            if (firstnum < secondnum)
            {
                Console.WriteLine($"{firststring} is smaller than {secondstring}");
            }
            else if (secondnum < firstnum)
            {
                Console.WriteLine($"{secondstring} is lower than {firststring}");
            }
            else
            {
                Console.WriteLine($"Both are equal");
            }

        }
    }
}