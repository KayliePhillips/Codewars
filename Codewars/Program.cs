using Codewars;
using System;
using System.Linq.Expressions;

#region All Completed Codewars 

#region: Codewars: Basic Mathematical Operations - reads input of an operator, two values and then completes the equations with the input
//Console.WriteLine(Methods.basicOp('+', 4, 3));
#endregion

#region Codewars: Opposite Number - Return Opposite Number.  Ex. Give 1, return -1
//Console.WriteLine(Methods.Opposite(3));
#endregion

#region Codewars: Find the Remainder
//Console.WriteLine(Methods.Remainder(0, 1));
#endregion

#region Codewars: Sentence Smash
//string[] givenWords = new string[] { "hi", "how", "are", "you" };
//Console.WriteLine(Methods.Smash(givenWords));
#endregion

#region Codewars: Grasshopper -Summation --Write a program that finds the summation of every number from 1 to num.
//Console.WriteLine(Methods.summation(4));
#endregion

#region Codewars: Opposites Attract --Pick flowers peters to determine love
//Console.WriteLine(Methods.lovefunc(0,0));
//Console.WriteLine(Methods.lovefunc(2, 2));
//Console.WriteLine(Methods.lovefunc(3, 2));
#endregion

#region Codewars: If you Can 't sleep, just count sheep!! -- Enter a number and return a string. 
//Console.WriteLine(Methods.CountSheep(3));
#endregion

#region Codewars: Convert boolean values to strings 'Yes' or 'No'
//Console.WriteLine(Methods.boolToWord(false));
#endregion

#region Codewars: GetPlanetName - debug Switch Statement
//Console.WriteLine(Methods.GetPlanetName(2));
#endregion

#region Codewars: CorrectTail debugging
//Console.WriteLine(Methods.CorrectTail("Fox", 'x'));
#endregion

#region Codewars: Jenny's secret message
//Console.WriteLine(Methods.greet("Johnny"));
#endregion

#region Codewars: 101 Dalmations-squash the bugs, not the dogs!
//Console.WriteLine(Methods.HowManyDalmatians(8));
#endregion

#region Codewars: The Wide-Mouthed frog!
//Console.WriteLine(Methods.MouthSize("alligator"));
//Console.WriteLine(Methods.MouthSize("Ant Bear"));
#endregion

#region Codewars: Grasshopper-Grade book
//Console.WriteLine(Methods.GetGrade(95, 90, 93));
#endregion

#region Codewars: Simple multiplication

//Console.WriteLine(Methods.Multiply(5));
#endregion

#region Codewars: Calculate BMI
//Console.WriteLine(Methods.Bmi(80, 1.80));
#endregion

#region Codewars: String Templates-Bug Fixing #5
//Console.WriteLine(Methods.Arr(4));
#endregion

#region Codewars: For UFC Fans(Total Beginners)
//Console.WriteLine(Methods.Quote("Conor mcgregor"));
#endregion

#region Codewars: Transportation on Vacation
//Console.WriteLine(Methods.RentalCarCost(3));
#endregion

#region Codewars: Highest and Lowest
//Console.WriteLine(Methods.HighAndLow("1 2 3 4 5 -5 33"));
#endregion

#region Codewars: Sorted?yes?no?how?  === didn't finish
//Console.WriteLine(Methods.IsSortedAndHow(new[] {1,2,3,4,5}));
//Console.WriteLine(Methods.IsSortedAndHow(new[] { 10,9,8,7,5 }));
//Console.WriteLine(Methods.IsSortedAndHow(new[] { 1, 12, 3, 94, 5 }));
#endregion

#region Codewars: DNA to RNA Conversion
//Console.WriteLine(Methods.dnaToRna("GCAT"));
#endregion

#region Codewars: Contamination #1-String
//Console.WriteLine(Methods.Contamination("abc", "z"));
#endregion

#region Codewars: Vowel Remover
//Console.WriteLine(Methods.Shortcut("Hello"));
#endregion;

#region Codewars: Sum of differences in array
//var arr = new int[] { 25, 24, -25, 2 };
//Console.WriteLine(Methods.SumOfDifferences(arr));
#endregion

//Console.WriteLine(Methods.numberToPower(2,3));

#region Codewars:Reversed Words
//Console.WriteLine(Methods.ReverseWords("The greatest victory"));
#endregion

#region Codewars: Disemvowel Trolls
//Console.WriteLine(Methods.Disemvowel("No offense but, \nYour writing is among the worse I've ever read"));
#endregion

#region Codewars: Predict your age! 
public class Predicter
{
    public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
    {
        int x = ((age1 * age1) + (age2 * age2) + (age3 * age3) + (age4 * age4) + (age5 * age5) + (age6 * age6) + (age7 * age7) + (age8 * age8));

        var z = (Math.Sqrt(x) / 2);

        z = Math.Floor(z);

        return Convert.ToInt32(z);    
    }
}
#endregion

#endregion All of Completed Codewars


