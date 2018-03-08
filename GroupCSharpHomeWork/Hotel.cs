using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupCSharpHomeWork
{
    public class Hotel:Travel
    {
        public override string ColorToNumber(string color)
        {
            string number = base.ColorToNumber(color);

            Console.WriteLine("\nWhat is your shoe size?");
            double size = double.Parse(Console.ReadLine());

            if (number == "1")
            {
                switch (size)
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
            else if (number == "2")
            {
                switch (size)
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
            else if (number == "3")
            {
                switch (size)
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



        //public string HotelChoice(string beach, double shoes)
        //{
        //    if (beach == "You're going to Tahiti!")
        //    {
        //        switch (shoes)
        //        {
        //            case 6.5:
        //                return "You're staying at Days Inn.";
        //                break;

        //            case 10.5:
        //                return "You're staying at the Ritz.";
        //                break;

        //            default:
        //                return "You have an abnormal shoes size.";
        //                break;
        //        }
        //    }
        //    else if (beach == "You're going to Zanzibar!")
        //    {
        //        switch (shoes)
        //        {
        //            case 6.5:
        //                return "You're staying at the Beach Shell Inn.";
        //                break;

        //            case 10.5:
        //                return "You're staying at the Stonetown Hotel.";
        //                break;

        //            default:
        //                return "You have an abnormal shoes size.";
        //                break;
        //        }
        //    }
        //   else if (beach == "You're going to California!")
        //    {
        //        switch (shoes)
        //        {
        //            case 6.5:
        //                return "You're staying at the Pink Motel.";
        //                break;

        //            case 10.5:
        //                return "You're staying at the Hotel California.";
        //                break;

        //            default:
        //                return "You have an abnormal shoes size.";
        //                break;
        //        }
        //    }
        //    else
        //    {
        //        return "You have an abnormal shoe size.";
        //    }


        //}
    }
}
