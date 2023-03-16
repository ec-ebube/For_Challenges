using System;
namespace For_Challenges
{
    public class AlphaPrint
    {
        //Create a function that prints all the english alphabets
        public static void Printing_Alphabets()
        {
            int x = 65;
            int y = 97;
            for (int i = x; i <= 90; i++)
            {
                Console.WriteLine(Convert.ToChar(i));

            }
            for (int j = y; j <= 122; j++)
            {
                Console.WriteLine(Convert.ToChar(j));
                
            }
        }
    }
}