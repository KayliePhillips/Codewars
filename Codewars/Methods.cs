using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
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

        #region Codewars: If you Can't sleep, just count sheep!! -- Enter a number and return a string. 
        public static string CountSheep(int n)
        {
            string sheepCount = "";
            for (int i = 1; i <= n; i++)
            {
                sheepCount += $"{i} sheep...";
            }
            return sheepCount;
        }
        #endregion
            
        #region Codewars: Convert boolean values to strings 'Yes' or 'No'
        public static string boolToWord(bool word)
        {
            if (word == true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }

        }
        #endregion

        #region Codewars: GetPlanetName - debug Switch Statement
        public static string GetPlanetName(int id)
        {
            //string name;
            switch (id)
            {
                case 1:
                    return "Mercury";
                    break;
                case 2:
                    return "Venus";
                    break;
                case 3:
                    return "Earth";
                    break;
                case 4:
                    return "Mars";
                    break;
                case 5:
                    return "Jupiter";
                    break;
                case 6:
                    return "Saturn";
                    break;
                case 7:
                    return "Uranus";
                    break;
                case 8:
                    return "Neptune";
                    break;
                default:
                    return "name";
                    break;
            }
        }
        //return name;
        #endregion
        
        #region Codewars: CorrectTail debugging
        public static bool CorrectTail(string body, string tail)
        {
            //string sub = body.SubString(bodylength - (tail.length));

            char last_body = body[body.Length - 1];
            char last_tail = tail[tail.Length - 1];
            
                if (last_body == last_tail)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
        #endregion

        #region Codewars: Jenny's secret message
        public static string greet(string name)
        {
           // return "Hello, " + name + "!";
            if (name == "Johnny")
            {
                return "Hello, my love!";
            }
            else
            {
                return "Hello," + name + "!";
            }
        }
        #endregion

        #region Codewars: 101 Dalmations-squash the bugs, not the dogs!
        public static string HowManyDalmatians(int n)
        {
            List<string> dogs = new List<string>()
            {
                "Hardly any",
                "More than a handful!",
                "Woah that's a lot of dogs!",
                "101 DALMATIONS!!!"
            };
                if (n <= 10)
                {
                    return dogs[0];
                }
                else if (n <= 50)
                {
                    return dogs[1];
                }
                else if (n == 101)
                {
                    return dogs[3];
                }
                else
                {
                    return dogs[2];
                }

        }
        #endregion

        #region Codewars: Calculate Average in a list
        //public static double FindAverage(double[] array)
        //{

        //    if (array.Length == null) ;
        //    return 0;

        //    double sum = 0;
        //    foreach (var num in array)
        //    {
        //        sum += num;
        //    }
        //    return sum/(array.Length);
        //}
        #endregion

        #region Codewars: The Wide-Mouthed frog!
        public static string MouthSize(string animal)
        {
            animal = animal.ToLower();
            if (animal == "alligator") 
                return "small";
            else
                return "wide";
        }
        #endregion

        #region Codewars: Grasshopper-Grade book

        public static char GetGrade(int s1, int s2, int s3)
        {
            int sum = (s1 + s2 + s3);
            int score = (sum / 3);
            if (score <= 100 && score >= 90)
                return 'A';
            else if (score < 90 && score >= 80)
                return 'B';
            else if (score < 80 && score >= 70)
                return 'C';
            else if (score < 70 && score >= 60)
                return 'D';
            else
                return 'F';
            
        }
        #endregion


        #region Codewars: Simple multiplication
        public static int Multiply(int x)
        {
            if (x % 2 == 0)
                return (x * 8);
            else
                return (x * 9);
        }

        #endregion




        #endregion All Completed Codewars Methods




    }


}





