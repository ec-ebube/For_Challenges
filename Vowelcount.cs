using System;
namespace For_Challenges
{
    public class Vowelcount
    {
        //create a function that returns the number of vowels in a string
        public static int Countingvowels()
        {
           List<char> vowels = new List<char>();
           vowels.Add('a');
           vowels.Add('e');
           vowels.Add('i');
           vowels.Add('o');
           vowels.Add('u');
           
           string word = "This is a sentence";
           int count = 0;
           for (int i = 0; i < word.Length; i++)
           {
              for (int j = 0; j < vowels.Count; j++)
              {
                if (word[i] == vowels[j])
                {
                    count++;
                }
              }
           }
            return count;
        }
    }
}