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
            Car carOne = new Car();
            Travel travelOne = new Travel();

            Console.WriteLine("Please enter your eye color as one of the following:  blue, green, brown.");
            string eyeColor = Console.ReadLine().ToLower();
            
            string eyeNumber = beachOne.ColorToNumber(eyeColor);

            int intNum = int.Parse(eyeNumber);

            //Console.WriteLine(eyeNumber);

            Console.WriteLine(beachOne.NumberToBeach(eyeNumber));
            
            Console.WriteLine(hotelOne.ColorToNumber(eyeColor));

            Console.WriteLine("Please tell me agian your shoe size?");

            double shoeNumber = double.Parse(Console.ReadLine());
            double total = carOne.Addition(intNum, shoeNumber);

            Console.WriteLine(travelOne.CarChoice(total));

        }
    }
}