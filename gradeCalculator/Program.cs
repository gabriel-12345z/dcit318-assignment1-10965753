using System;

namespace GradeCalculator
{

    class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Please enter the mark ");
            y = Convert.ToInt32(Console.ReadLine());

            if (y >= 90)
            {
                Console.WriteLine("Your grade is A");
            }
            else if (y >= 80 && y <= 89)
            {
                Console.WriteLine("Your grade is B");
            }
            else if (y >= 70 && y <= 79)
            {
                Console.WriteLine("Your grade is C");
            }
            else if (y >= 60 && y <= 69)
            {
                Console.WriteLine("Your grade is D");
            }
            else if (y < 60)
            {
                Console.WriteLine("Your grade is F");
            }
        }
    }
}