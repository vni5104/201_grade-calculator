/*
 * Name: Vicky Ni
 * Class: IGME-201.01
 * Due: 10/12/2025 
 */

namespace GradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Vicky";
            int[] grades = [100, 92, 87, 200, -20, 52, 82, 75, 67, 88];

            //*** Print to Console ***
            Console.WriteLine("Welcome, " + name + ".");
            Console.WriteLine("\nHere are your grades:\n");
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine("Grade: " + grades[i]);

                if (grades[i] >= 90 && grades[i] <= 100) {
                    Console.WriteLine("This grade is an A!");
                    if (grades[i] == 100)
                    {
                        Console.WriteLine("WOW! A perfect score!");
                    }
                }
                else if (grades[i] >= 80 && grades[i] <= 89)
                {
                    Console.WriteLine("This grade is a B.");
                }
                else if (grades[i] >= 70 && grades[i] <= 79)
                {
                    Console.WriteLine("This grade is a C.");
                }
                else if (grades[i] >= 65 && grades[i] <= 69)
                {
                    Console.WriteLine("This grade is a D.");
                }
                else if (grades[i] >= 0 && grades[i] <= 64)
                {
                    Console.WriteLine("This grade is a F.");
                }
                else
                {
                    Console.WriteLine("This is out of the range 0-100. How did you even get this grade?");
                }

                Console.WriteLine(""); //new line for new iteration
            }

            //Calculates average grade
            float average = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                average += grades[i];
            }
            average /= grades.Length;

            Console.WriteLine("-----");
            Console.WriteLine("Average Grade: " + average);
            Console.WriteLine("We have displayed all grades for " + name + ".");
        }
    }
}
