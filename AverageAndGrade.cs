/*AverageAndGradeApp.cs
 * Author: Joseph Thomas
 * This application will
 * take a student's 5 scores.
 * It will construct an obect of
 * the Grades class will
 * calculate the average. 
 * It will then call DetermineGrade
 * to determine the appropriate
 * grade from A to F.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageAndGradeApp
{
    class AverageAndGrade
    {
        static void Main(string[] args)
        {
            int scoreResults;
            double scrRes;
            char grade = 'i';
            
            DisplayInstructions();

            Grades myGradeResults = new Grades();
            myGradeResults.Score1 = GetScores("number 1 ");
            myGradeResults.Score2 = GetScores("number 2 ");
            myGradeResults.Score3 = GetScores("number 3 ");
            myGradeResults.Score4 = GetScores("number 4 ");
            myGradeResults.Score5 = GetScores("number 5 ");

            // Gets the Score Average from Grades.cs
            scrRes = myGradeResults.ScoreAve();
            // Converts the double average to an int for grade determination
            scoreResults = Convert.ToInt32(scrRes);

            grade = DetermineGrade(scoreResults);
            
            DisplayResults(scoreResults, grade);

        }

        public static char DetermineGrade(double scr)
        {
            char grd = 'Q';

            if (scr < 60.0)
                grd = 'F';
            else if (scr < 70.0)
                grd = 'D';
            else if (scr < 80.0)
                grd = 'C';
            else if (scr < 90.0)
                grd = 'B';
            else if (scr <= 100.0)
                grd = 'A';

            return grd;
        }


        public static void DisplayResults(double scravg, char grd)
        {
            Console.Clear();
            Console.WriteLine("AVERAGE & GRADE RESULTS");
            Console.Write("\n\nAverage = \t{0:F0}", scravg);
            Console.WriteLine("\t " + grd);
            Console.WriteLine("\n\n\nPress any key to exit...");
            Console.ReadKey();
        }
  

        // Request Scores from User      
        public static int GetScores(string scoreNumber)
        {      
            int usersScore;
            string inputValue;

            Console.Write("Enter the score for exam {0} : ", scoreNumber);
            inputValue = Console.ReadLine();
            usersScore = int.Parse(inputValue);
            return usersScore;
        }


        public static void DisplayInstructions()
        {
            // Display the Instructions for User to Follow
            Console.WriteLine("{0, 45}", "Calculate Average & Determine Grade");
            Console.WriteLine("\n\nThis program averages the 5 scores of the user.");
            Console.WriteLine("The user will input the scores of their 5 exams");
            Console.WriteLine("The program will then calculate the Student's average \nand determine the appropriate grade.");
            Console.WriteLine("\n\nPress any key to begin...");
            Console.ReadKey();
            Console.Clear();
        }

    }
}
