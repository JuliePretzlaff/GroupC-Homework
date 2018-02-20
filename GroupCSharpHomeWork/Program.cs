using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupCSharpHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            BeachResult beachOne = new BeachResult();
            Hotel hotelOne = new Hotel();

            Console.WriteLine("Please enter your eye color as one of the following:  blue, green, brown.");
            string beach = (beachOne.NumberToBeach(beachOne.ColorToNumber(Console.ReadLine().ToLower())));
            Console.WriteLine(beach);

            Console.WriteLine("\nWhat is your shoe size?");
            double size = double.Parse(Console.ReadLine());
            Console.WriteLine(hotelOne.HotelChoice(beach, size));
        }
    }
}