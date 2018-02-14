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

        public virtual int ColorToNumber(string color)
        {
            switch (color)
            {
                case "blue":
                    return 1;
                        break;

                case "green":
                    return 2;
                    break;

                case "brown":
                    return 3;
                    break;

                default:
                    return 4;
                    break;
            }
        }


    }
}
