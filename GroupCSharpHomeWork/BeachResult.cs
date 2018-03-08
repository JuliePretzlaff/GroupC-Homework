using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupCSharpHomeWork
{
    public class BeachResult :Travel
    {
        public override string ColorToNumber(string color)
        {
            switch (color)
            {
                case "blue":
                    return "1";
                    break;

                case "green":
                    return "2";
                    break;

                case "brown":
                    return "3";
                    break;

                default:
                    return "4";
                    break;
            }

        }

        public string NumberToBeach(string number)
        {
            switch (number)
            {
                case "1":
                    return "You're going to Tahiti!";
                    break;
                case "2":
                    return "You're going to Zanzibar!";
                    break;

                case "3":
                    return "You're going to California!";
                    break;

                default:
                    return "You have a weird eye color.";
                    break;
            }
        }
    }
}
