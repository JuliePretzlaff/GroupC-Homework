using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupCSharpHomeWork
{
    public class Hotel
    {
       
        public string HotelChoice(string beach, double shoes)
        {
            if (beach == "You're going to Tahiti!")
            {
                switch (shoes)
                {
                    case 6.5:
                        return "You're staying at Days Inn.";
                        break;

                    case 10.5:
                        return "You're staying at the Ritz.";
                        break;

                    default:
                        return "You have an abnormal shoes size.";
                        break;
                }
            }
            else if (beach == "You're going to Zanzibar!")
            {
                switch (shoes)
                {
                    case 6.5:
                        return "You're staying at the Beach Shell Inn.";
                        break;

                    case 10.5:
                        return "You're staying at the Stonetown Hotel.";
                        break;

                    default:
                        return "You have an abnormal shoes size.";
                        break;
                }
            }
           else if (beach == "You're going to California!")
            {
                switch (shoes)
                {
                    case 6.5:
                        return "You're staying at the Pink Motel.";
                        break;

                    case 10.5:
                        return "You're staying at the Hotel California.";
                        break;

                    default:
                        return "You have an abnormal shoes size.";
                        break;
                }
            }
            else
            {
                return "You have an abnormal shoe size.";
            }


        }
    }
}
