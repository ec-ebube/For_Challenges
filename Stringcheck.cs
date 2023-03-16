using System;
namespace For_Challenges
{
    public class Stringcheck
    {
        //Craete a function that returns true if all letters in a string are
        //Uppercase and false if all letters are lowercase
        public static bool Stringcase()
        {
            string word = "HELLO";
            List<int> letters = new List<int>();
            for (int i = 0; i <= word.Length-1; i++)
            {
                int alphaalt = Convert.ToInt32(word[i]);
                letters.Add(alphaalt);
            }
            for (int j = 0; j < letters.Count; j++)
            {
                if (letters[j] >= 65 && letters[j] <= 90)
                {
                    continue;
                } else if (letters[j] >= 97 && letters[j] <= 122)
                {
                    return false;
                } else
                {
                    Console.WriteLine("A character was found");
                }
            }
            
            
            // foreach (var item in letters)
            // {
            //     Console.WriteLine(item);
            // }
            return true;
        }
    }
}