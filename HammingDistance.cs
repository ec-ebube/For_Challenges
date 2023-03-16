using System;
namespace For_Challenges
{
    public class HammingDistance
    {
        /*Hamming distance is the number of characters 
        that differ between two strings*/
        public static void HamDis()
        {
            string str1 = "abcbba";
            string str2 = "abcbda";

            List<int> items = new List<int>();

            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    items.Add(i);
                } else
                {
                    continue;
                }
            }
            foreach (var item in items)
            {
                Console.WriteLine(str1[item]+","+str2[item]);
                // Console.WriteLine(str2[item]);
            }
        }
    }
}