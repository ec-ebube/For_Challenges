using System;
namespace For_Challenges
{
    class For_Power
    {
        /*Create a function that provides the power or
        the exponential of a number*/
        public static void Powerof()
        {
            // int basenum = Convert.ToInt32(Console.ReadLine());
            // int powernum = Convert.ToInt32(Console.ReadLine());
            double basenum = 4;
            double powernum = 7;
            // int[] calExponent = { basenum, powernum };
            // int count = 1;
            // int sum = 0;
            double num = basenum;
            for (int i = 1; i <= powernum; i++)
            {
                basenum *= num;
            }
            Console.WriteLine(basenum);
            // int ccc = basenum ^ powernum;
            // Console.WriteLine(ccc);
            // foreach (var item in calExponent)
            // {
            //     Console.WriteLine(item);
            // }
        }
    }
}