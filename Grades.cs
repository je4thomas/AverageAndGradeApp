/*Grade.cs
 * Author: Joseph Thomas
 * Date: 06/24/2012
 * This class defines a template
 * for a student's scores that 
 * includes 5 scores and a method
 * that calculates the score average.
 * It also overrides ToString()
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AverageAndGradeApp
{
    class Grades
    {
        private int score1;
        private int score2;
        private int score3;
        private int score4;
        private int score5;
        private double scoreAvg;

        // Property acting as mutator and accessor
        public int Score1
        {
            get 
            {
                return score1;
            }
            set
            {
                score1 = value;
            }
        }

        // Property acting as mutator and accessor
        public int Score2
        {
            get
            {
                return score2;
            }
            set 
            {
                score2 = value;
            }
        }

        // Property acting as mutator and accessor
        public int Score3
        {
            get
            {
                return score3;
            }
            set
            {
                score3= value;
            }
        }

        // Property acting as mutator and accessor
        public int Score4
        {
            set
            {
                score4 = value;
            }

            get
            {
                return score4;
            }

        }

        // Property acting as mutator and accessor
        public int Score5
        {
            get
            {
                return score5;
            }
            set
            {
                score5 = value;
            }
        }

        // Default Constructor
        public Grades()
        {
        }

        // One Parameter Constructor
        public Grades(int scr1)
        {
            score1 = scr1;
        }

        // Two Score Constructor
        public Grades(int scr1, int scr2)
        {
            score1 = scr1;
            score2 = scr2;
        }

        // Three Score Constructor
        public Grades(int scr1, int scr2, int scr3)
        {
            score1 = scr1;
            score2 = scr2;
            score3 = scr3;
        }

        // Four Score Constructor
        public Grades(int scr1, int scr2, int scr3, int scr4)
        {
            score1 = scr1;
            score2 = scr2;
            score3 = scr3;
            score4 = scr4;
        }

        // Five Score Constructor
        public Grades(int scr1, int scr2, int scr3, int scr4, int scr5)
        {
            score1 = scr1;
            score2 = scr2;
            score3 = scr3;
            score4 = scr4;
            score5 = scr5;
        }

        // Calculates the Average of the 5 Scores Entered
        public double ScoreAve()
        {
            scoreAvg = ((score1 + score2 + score3 + score4 + score5) / 5.0);
            return scoreAvg;
        }

        // Override the ToString for Grades.cs
        public override string ToString()
        {
            return "Student's Scores" + "\n\tScore1 = " + score1 + "\n\tScore2 = " + score2 + "\n\tScore3 = " + score3 + "\n\tScore4 = " + score4 + "\n\tScore5 = " + score5 + "\n\t_________________________" + "\n\tAverage = " + ScoreAve().ToString("F0");
        }

    }
}
