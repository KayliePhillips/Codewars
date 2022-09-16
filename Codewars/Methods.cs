using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Methods
    {
        //EvenOrOdd
        public static string EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        //Return String
        public static string Greet(string name)
        {
            return ($"Hello, {name} how are you doing today?");
        }


        //Bartender, drink!
        public static string GetDrinkByProfession(string p)
        {
            switch (p.ToLower())
            {
                case "jabroni":
                    return "Patron Tequila";
                    break;
                case "school counselor":
                    return "Anything with Alcohol";
                    break;
                case "programmer":
                    return "Hipster Craft Beer";
                    break;
                case "bike gang member":
                    return "Moonshine";
                    break;
                case "politician":
                    return "Your tax dollars";
                    break;
                case "rapper":
                    return "Cristal";
                    break;
                default:
                    return "Beer";
                    break;
            }   
        }
    }
}
