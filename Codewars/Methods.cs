using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

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

        #region Codewars: Find the first non-consecutive number
        public static object FirstNonConsecutive(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 != arr[i + 1])
                {
                    return arr[i + 1];
                }
            }
            return null;
        }
        #endregion

        #region Codewars: Sum of positive with Linq
        public static int PositiveSum(int[] arr)
        {
            var posSum = arr.Where(x => x > 0).Sum(x => x);
            return posSum;
        }
        #endregion

        #region Codewars: Calculate BMI
        public static string Bmi(double weight, double height)
        {
            var bmi = (weight / (height * height));

            if (bmi <= 18.5)
            {
                return "Underweight";
            }
            else if (bmi <= 25.0)
            {
                return "Normal";
            }
            else if (bmi <= 30.0)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }

        }
        #endregion

        #region Codewars: String Templates-Bug Fixing #5
        public static string buildString(string[] args)
        {
            return string.Format("I like {0}!", string.Join(", ", args));

        }
        #endregion

        #region Codewars: Man in the west -- Gold checker T/F
        public static bool CheckTheBucket(string[] bucket)
        {
            foreach (var item in bucket)
            {
                if (item == "gold")
                {
                    return true;
                }

            }
            return false;
        }

        #endregion

        #region Codewars: For UFC Fans(Total Beginners)
        public static string Quote(string fighter)
        {

            if (fighter.ToLower() == "conor mcgregor")
            {
                return ("I'd like to take this chance to apologize.. To absolutely NOBODY!");
            }
            else
            {
                return ("I am not impressed by your performance.");
            }
        }
        #endregion

        #region Codewars: You only need one -- Beginner
        public static bool Check(object[] a, object x)
        {
            return a.Contains(x);
        }
        #endregion;

        #region Codewars: Remove First and Last Character
        public static string Remove_char(string s)
        {
            string result = s.Substring(1, s.Length - 2);
            return result;

        }
        #endregion

        #region Codewars: Reverse List
        public static int[] reverseList(int[] list)
        {
            return list.Reverse().ToArray();
        }
        #endregion

        #region Codewars: The Feast of Many Beasts
        public static bool Feast(string beast, string dish)
        {
            char[] wordBeast = beast.ToLower().ToCharArray();
            char[] wordDish = dish.ToLower().ToCharArray();

            if (wordBeast[0] == wordDish[0] && wordBeast[beast.Length -1] == wordDish[dish.Length-1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Codewars: Counting sheep True or False
        public static int CountSheeps(bool[] sheeps)
        {
            int x = 0;
            foreach (var item in sheeps)
            {
                if (item == true)
                {
                    x++;
                }
            }
            return x;
        }
        #endregion

        #region Codewars: Switch/Case-Bug Fixing #6
        public static double EvalObject(double value1, double value2, char operation)
        {
            double result = 0;
            switch (operation)
            {
                case '+': return value1 + value2;
                case '-': return value1 - value2;
                case '/': return value1 / value2;
                case '*': return value1 * value2;
                case '%': return value1 % value2;
                case '^': return Math.Pow(value1, value2);
                default: return 0;

            }
            
        }
        #endregion

        #region Codewars: Reversed Strings
        public static string Solution(string str)
        {
        return string.Join("", str.Reverse());
            
        }
        #endregion

        #region Codewars: Transportation on Vacation
        public static int RentalCarCost(int d)
        {
            
            if (d>=7)
            {
                return (40 * d) - 50;
            }
            else if (3 <= d && d < 7)
            {
                return (40 * d) - 20;
            }
            return (d * 40);
        }
        #endregion

        #region Codewars: Beginner - Lost Without a Map
        public static int[] Maps(int[] x)
        {
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i] * 2;
            }
            return y;
        }
        #endregion

        #region All Star Code Challenge #18
        public static int StrCount(string str, string letter)
        {
            

            char[] wordString = str.ToLower().ToCharArray();
            char[] givenLetter = letter.ToLower().ToCharArray();

            var countAnswer = 0;
            for (int i = 0; i < wordString.Length; i++)
            {

                if (wordString[i] == givenLetter[0])
                {
                    countAnswer++;
                }
               
            }
            return countAnswer;
        }
        #endregion

        #region Codeswars: Highest and Lowest
        public static string HighAndLow(string numbers)
        {
            var max = numbers.Split(' ').Select(x => int.Parse(x)).Max();
            int min = numbers.Split(' ').Select(x => int.Parse(x)).Min();
            var answer = ($"{max} {min}");
            return answer;
        }
        #endregion



        #endregion All Completed Codewars Methods

    }

}










