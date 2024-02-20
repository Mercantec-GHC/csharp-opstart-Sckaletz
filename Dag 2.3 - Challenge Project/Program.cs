using System.Diagnostics;

internal class Program
{
    public static void Main(string[] args)
    {
        //Start();
        Final();
    }

    public static void Start()
    {
        int examAssignments = 5;

        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

        int[] studentScores = new int[10];

        string currentStudentLetterGrade = "";

        // display the header row for scores/grades
        Console.Clear();
        Console.WriteLine("Student\t\tGrade\tLetter Grade\n");

        /*
        The outer foreach loop is used to:
        - iterate through student names 
        - assign a student's grades to the studentScores array
        - sum assignment scores (inner foreach loop)
        - calculate numeric and letter grade
        - write the score report information
        */


        foreach (string name in studentNames)
        {
            string currentStudent = name;

            if (currentStudent == "Sophia")
                studentScores = sophiaScores;

            else if (currentStudent == "Andrew")
                studentScores = andrewScores;

            else if (currentStudent == "Emma")
                studentScores = emmaScores;

            else if (currentStudent == "Logan")
                studentScores = loganScores;

            int sumAssignmentScores = 0;

            decimal currentStudentGrade = 0;

            int gradedAssignments = 0;

            /* 
            the inner foreach loop sums assignment scores
            extra credit assignments are worth 10% of an exam score
            */

            foreach (int score in studentScores)
            {
                gradedAssignments += 1;

                if (gradedAssignments <= examAssignments)
                    sumAssignmentScores += score;

                else
                    sumAssignmentScores += score / 10;
            }

            currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";

            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";

            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";

            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";

            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";

            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";

            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";

            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";

            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";

            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";

            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";

            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";

            else
                currentStudentLetterGrade = "F";

            // Student         Grade
            // Sophia:         92.2    A-

            Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
        }

        // required for running in VS Code (keeps the Output windows open to view results)
        Console.WriteLine("\n\rPress the Enter key to continue");
        Console.ReadLine();
    }

    public static void Final()
    {
        int examAssignments = 5;

        string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

        int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
        int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
        int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
        int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

        int[] studentScores = new int[10];

        string currentStudentLetterGrade = "";

        Console.Clear();
        Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

        // Calculate exam scores, extra credit, and overall grades for each student.
        foreach (string name in studentNames)
        {
            string currentStudent = name;

            if (currentStudent == "Sophia")
                studentScores = sophiaScores;

            else if (currentStudent == "Andrew")
                studentScores = andrewScores;

            else if (currentStudent == "Emma")
                studentScores = emmaScores;

            else if (currentStudent == "Logan")
                studentScores = loganScores;

            int gradedAssignments = 0;
            int gradedExtraCreditAssignments = 0;

            int sumExamScores = 0;
            int sumExtraCreditScores = 0;

            decimal currentStudentGrade = 0;
            decimal currentStudentExamScore = 0;
            decimal currentStudentExtraCreditScore = 0;

            /* 
            the inner foreach loop: 
            - sums the exam and extra credit scores
            - counts the extra credit assignments
            */

            foreach (int score in studentScores)
            {
                gradedAssignments += 1;

                if (gradedAssignments <= examAssignments)
                {
                    sumExamScores = sumExamScores + score;
                }

                else
                {
                    gradedExtraCreditAssignments += 1;
                    sumExtraCreditScores += score;
                }
            }

            // Calculate the average exam score and extra credit score for the current student.
            currentStudentExamScore = (decimal)(sumExamScores) / examAssignments;
            currentStudentExtraCreditScore = (decimal)(sumExtraCreditScores) / gradedExtraCreditAssignments;

            // Calculate the overall grade for the current student, including extra credit.
            currentStudentGrade = (decimal)((decimal)sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

            // Determine the letter grade for the current student based on their overall grade.
            if (currentStudentGrade >= 97)
                currentStudentLetterGrade = "A+";

            else if (currentStudentGrade >= 93)
                currentStudentLetterGrade = "A";

            else if (currentStudentGrade >= 90)
                currentStudentLetterGrade = "A-";

            else if (currentStudentGrade >= 87)
                currentStudentLetterGrade = "B+";

            else if (currentStudentGrade >= 83)
                currentStudentLetterGrade = "B";

            else if (currentStudentGrade >= 80)
                currentStudentLetterGrade = "B-";

            else if (currentStudentGrade >= 77)
                currentStudentLetterGrade = "C+";

            else if (currentStudentGrade >= 73)
                currentStudentLetterGrade = "C";

            else if (currentStudentGrade >= 70)
                currentStudentLetterGrade = "C-";

            else if (currentStudentGrade >= 67)
                currentStudentLetterGrade = "D+";

            else if (currentStudentGrade >= 63)
                currentStudentLetterGrade = "D";

            else if (currentStudentGrade >= 60)
                currentStudentLetterGrade = "D-";

            else
                currentStudentLetterGrade = "F";

            // Output the results to the console.
            Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
        }

        // Prompt user to press Enter to continue.
        Console.WriteLine("\n\rPress the Enter key to continue");
        Console.ReadLine();
    }
}
