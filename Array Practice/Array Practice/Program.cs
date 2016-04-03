using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             *Algorithm
             * 1. Declare array to store exam scores for 10 students
             * 2. Read in exam scores
             * 3. Store in array
             * 4. Print out all elmants for array
             * 5. Calculate Average
             * REPEAT
                 * 6. test if value selected is found
                 * 7. Print out yes or no
             * UNTIL found or all elements checked
             */


            //Declaration of variables
            //1. Declare array to store exam scores for 10 students
            int maxStudents = 10;
            int currentValidScore;
            int targetScore = 0;

            int[] ExamScores = new int[10];

            string currentScore = "";
            string targetScoreString;

            bool validScore = false;
            bool targetScoreValid = false;

            double overallTotal = 0;
            double overallAverage;

            
            for (int currentStudentScore = 0; currentStudentScore < maxStudents; currentStudentScore++)
            {
                while (validScore == false)
                {
                    Console.WriteLine("Please enter the score");

                    BlankLine();

                    //2. Read in exam scores
                    currentScore = Console.ReadLine();

                    validScore = Int32.TryParse(currentScore, out currentValidScore);

                    //3. Store in array
                    ExamScores[currentStudentScore] = currentValidScore;

                    overallTotal = overallTotal + currentValidScore;

                    BlankLine();

                }//End While

                validScore = false;

            }//End For
            

            //4. Print out all elements for array 
            for (int currentStudentScore = 0; currentStudentScore < maxStudents; currentStudentScore++)
            {

                Console.WriteLine("Student " + (currentStudentScore + 1).ToString() + " got " + ExamScores[currentStudentScore].ToString());

            }//End For
            

            //Calculate average
            overallAverage = overallTotal/maxStudents;

            BlankLine();

            //Print average
            Console.WriteLine("The average is " + overallAverage.ToString("N1"));

            BlankLine();

            while (targetScoreValid == false)
            {
                //Ask target
                Console.WriteLine("\nPlease Enter a target score");

                //Read target
                targetScoreString = Console.ReadLine();

                targetScoreValid = Int32.TryParse(targetScoreString, out targetScore);

                BlankLine();

            }//End While
            

            //6. test if value selected is found
            for (int arrayIndicator = 0; arrayIndicator < ExamScores.Length; arrayIndicator++)
            {

                if (ExamScores[arrayIndicator] == targetScore)
                {

                    Console.WriteLine(targetScore + " at the position " + (arrayIndicator + 1));
                    break;

                }
                else if (arrayIndicator == ExamScores.Length - 1)
                {

                    Console.WriteLine("Target not found");

                }//End if

            }//End for


            //Pause
            Console.ReadKey();

        }//End Main

        private static void BlankLine()
        {
            Console.WriteLine();
        }
    }
}
