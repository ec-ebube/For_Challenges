using System;
namespace For_Challenges
{
    internal class Numcount
    {
        //create a funtion that uses recursion instead of for loop
        public static int counting(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            return num + counting(num-1);
        }
    }
}