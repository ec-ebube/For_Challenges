using System;
namespace For_Challenges
{
    public class Casecheck
    {
        /*create a function that checks if a letter is 
        in upper case or not*/
        public static void For_casecheck()
        {
            Console.WriteLine("Input a string to checkif it's an upper or lower case letter");
            string? destring = Console.ReadLine();
            char letter = (char) destring![0];
            int thenum = Convert.ToChar(letter);
            if (thenum >= 65 && thenum <= 90)
            {
                Console.WriteLine($"{letter} is an uppercase letter");
            } else if (thenum >= 97 && thenum <= 122)
            {
                Console.WriteLine($"{letter} ia a lowercase letter");
            } else
            {
                Console.WriteLine($"{letter} is not an english alphabet");
            }
            // for (int i = 65; i <= 90; i++)
            // {

            // }
        }

    }
}