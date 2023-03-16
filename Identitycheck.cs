using System;
namespace For_Challenges
{
    public class Identitycheck
    {
        //create a function that checks if a string of words
        //contain only same characters or not
        public static void stringcheck()
        {
            string word = "aaaaaa";
            for (int i = 0; i <= word.Length; i++)
            {
                if (word[i] == word[i+1] && word[i] < word.Length-2)
                {
                    continue;
                }else
                {
                    Console.WriteLine($"{word[i]} does not match the rest");
                }
            }
        }
    }
}