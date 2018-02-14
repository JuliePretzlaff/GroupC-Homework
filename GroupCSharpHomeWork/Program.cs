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

            Console.WriteLine("Please enter your eye color as one of the following:  blue, green, brown.");
            Console.WriteLine(beachOne.NumberToBeach(beachOne.ColorToNumber(Console.ReadLine().ToLower())));
        }
    }
}