using System;
namespace For_Challenges
{
    public class Shapes
    {
        //Create a function that returns a shape with the number of side that
        //has earlier been stated by the user or software
        public static void Sidenum()
        {
            Random random = new Random();
            int num = random.Next(10);
            Console.WriteLine($"Shape with {num} side(s) is called");
            switch (num)
            {
                case 1:
                Console.WriteLine("Circle");
                break;
                
                case 2:
                Console.WriteLine("Semi-Circle");
                break;
                
                case 3:
                Console.WriteLine("Triangle");
                break;

                case 4:
                Console.WriteLine("Square");
                break;

                case 5:
                Console.WriteLine("Pentagon");
                break;

                case 6:
                Console.WriteLine("Hexagon");
                break;

                case 7:
                Console.WriteLine("Heptagon");
                break;

                case 8:
                Console.WriteLine("Octagon");
                break;

                case 9:
                Console.WriteLine("Nonagon");
                break;

                case 10:
                Console.WriteLine("Dacegon");
                break;

                default:
                Console.WriteLine("Invalid Shape");
                break;
            }
        }
    }
}