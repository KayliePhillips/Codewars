using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class Methods
    {
        #region All Completed Codewars Methods
        #region Codewars: Even Or Odd - Given input it returns if the number is even or odd.
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
        #endregion

        #region Codewars: Returning Strings - Given an input it returns the input in a written message.  
        public static string Greet(string name)
        {
            return ($"Hello, {name} how are you doing today?");
        }
        #endregion

        #region Codewars: L1:Bartender, drink! - Switch that reads a name and returns what drink that person likes
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
        #endregion

        #region Codewars: Basic Mathematical Operations - reads input of an operator, two values and then completes the equations with the input
        public static double basicOp(char op, double val1, double val2)
        { 
            switch (op)
            { 
                case '+': return val1 + val2;
                case '-': return val1 - val2;
                case '*': return val1 * val2;
                case '/': return val1 / val2;
                default:
                    throw new System.ArgumentException("Unknown operation!", op.ToString());
            }
        }
        #endregion

        #region Codewars: Opposite Number - Return Opposite Number.  Ex. Give 1, return -1
        public static int Opposite(int number)
        {
            return -number;
        }
        #endregion

        #region Codewars: Make Upper Case - Given a string, return it in All Uper Case Ex. Given John, return JOHN
        public static string MakeUpperCase(string str)
        {
            return str.ToUpper();
        }
        #endregion

        #region Codewars: Find the remainder
        public static int Remainder(int a, int b)
        {
            if (a > b)
            {
                return a % b;
            }
            else
            {
                return b % a;
            }

        }
        #endregion

        #region Codewars: Sentance Smash - Take individual words and put them into one sentence.  
        public static string Smash(string[] words)
        {
            return String.Join(" ", words);
        }
        #endregion

        #region  Codewars: Grasshopper -Summation --Write a program that finds the summation of every number from 1 to num.       
        public static int summation(int num)
        {
            int sum = 0;
            for (int i = 0; i <= num; i++)
            {
                sum += i; //sum = sum + i
            }
            return sum;
        }

        #endregion

       
        #region Codewars: Opposites Attract -- Pick flowers peters to determine love
        public static bool lovefunc(int flower1, int flower2)
        {

            if (flower1 % 2 == 0 && flower2 % 2 != 0) return true;
            if (flower1 % 2 != 0 && flower2 % 2 == 0) return true;
            return false;
        }
        #endregion
        #endregion All Completed Codewars Methods
    }

}
