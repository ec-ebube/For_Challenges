using System;
namespace For_Challenges
{
    public class EvenSum
    {
        /*Create a function that sums all even numbers
        within a specified range*/
        public static void For_evensum()
        {
            Console.WriteLine("Enter the starting number");
            int minNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the ending number");
            int maxNum = Convert.ToInt32(Console.ReadLine());
            int[] evenarr = new int[(maxNum - (minNum-1))];
            int theevensum = 0;
            int count = 0;
            for (int i = minNum-1; i <= maxNum; i++)
            {
                evenarr[count] = i;
                if (i % 2 == 0)
                {
                    theevensum += evenarr[count];
                }
                else
                {
                    continue;
                }
                count++;
            }
            Console.WriteLine(theevensum);

        }
    }
}