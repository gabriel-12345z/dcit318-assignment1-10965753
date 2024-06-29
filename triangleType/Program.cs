using System;

namespace TriangleTypeIdentifier
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int x,y,z;
            Console.WriteLine("Enter length of base ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter length of first side ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter length of second side ");
            z = Convert.ToInt32(Console.ReadLine());

            if(z == y && z == x){
                Console.WriteLine("this is an equilateral triangle");
            }
            else if(x == y && z != y && z != x){
                Console.WriteLine("this is an isoceles triangle");
            }
            else if(z == y && x != y && x != z){
                Console.WriteLine("this is an isoceles triangle");
            }
            else if(x == z && y != z && y != x){
                Console.WriteLine("this is an isoceles triangle");
            }
            else{
                Console.WriteLine("this is a scalene triangle");
            }
        }
    }
}