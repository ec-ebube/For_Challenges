using System;
namespace For_Challenges
{
    public class H4ck3rSp34k
    {
        public static string Codedsentence()
        {
            Dictionary<char, char> dic = new Dictionary<char, char>();
            dic.Add('a', '4');
            dic.Add('s', '5');
            dic.Add('z', '2');
            dic.Add('o', '0');
            dic.Add('i', '1');
            dic.Add('e', '3');
            string sentence = "This is a sentence";
            string str = "";
            char[] newsentence = sentence.ToArray();
            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < dic.Count; j++)
                {
                   if (newsentence[i] == dic.ElementAt(j).Key)
                   {
                        newsentence[i] = dic.ElementAt(j).Value;
                   } 
                }
            }
            foreach (var x in newsentence)
            {
                str = str + x;
            }
            return str;

        }
    }
}