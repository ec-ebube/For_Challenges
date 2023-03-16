using System;
namespace For_Challenges
{
    public class Dcount
    {
        //create a function that counts the number of d's in a sentence
        public static int CountingD()
        {
            string letter = "Do de drone ur'self";
            List<char> Ds = new List<char>();
            Ds.Add('D');
            Ds.Add('d');

            int count = 0;
            for (int i = 0; i < letter.Length; i++)
            {
                for (int j = 0; j < Ds.Count; j++)
                {
                    if (letter[i] == Ds[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}