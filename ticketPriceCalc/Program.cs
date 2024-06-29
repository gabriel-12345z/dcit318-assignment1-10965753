using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            Console.WriteLine("Enter age: ");
            y = Convert.ToInt32(Console.ReadLine());

            if(y >= 65 || y <= 12){
                Console.WriteLine("Your ticket price is GHC7");
            }
            else{
                Console.WriteLine("Your ticket price is GHC10");
            }
        }
    }

}