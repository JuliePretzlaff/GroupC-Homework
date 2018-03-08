using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupCSharpHomeWork
{
    public class Travel
    {
        public string PersonTravelling { get; set; }

        public virtual string ColorToNumber(string color)
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

        public virtual string CarChoice (double total)
        {
            if (total % 2 == 0)
            {
                return "You're driving a Tesla.";
            }
            else if (total %3 == 0)
                    {
                return "You're driving a motorcycle.";
            }
            else
            {
                return "You're driving a rickshaw.";
            }
        }
    }
}
