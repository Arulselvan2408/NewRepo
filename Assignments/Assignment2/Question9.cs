using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    enum Feedback
    {
        Fail,Poor, Average, AboveAverage, Good, Outstanding
    }
    class Question9
    {
        char calculate_grade(int[] Marks)
        {
            for (int i=0; i<5; i++)
            {
                if (Marks[i] > 90)
                {
                    return Grade= 'O';
                    
                }
                if (Marks[i] > 80)
                {
                    return Grade= 'A';
                }
                if (Marks[i] >60)
                {
                    return "Grade= B";
                }
                if (Marks[i] >50)
                {
                    return "Grade= C";
                }
                if (Marks[i] >40)
                {
                    return "Grade= D";
                }
                if (Marks[i]<40)
                {
                    return "Grade= F"; 
                }

            }
            
            void calculate_Feedback (string Grade)
            {
                if (Grade== "O")
                {
                    Console.WriteLine(Feedback.Outstanding);
                }
                if (Grade == "A")
                {
                    Console.WriteLine(Feedback.Good);
                }
                if (Grade == "B")
                {
                    Console.WriteLine(Feedback.AboveAverage);
                }
                if (Grade == "C")
                {
                    Console.WriteLine(Feedback.Average);
                }
                if (Grade == "D")
                {
                    Console.WriteLine(Feedback.Poor);
                }
                if (Grade == "F")
                {
                    Console.WriteLine(Feedback.Fail);
                }
            }
        }
        void DisplayResultMethod(string Name, Char Grade, string Feedback)
        {
            Console.WriteLine("Name:{0}\nGrade: {1}\nFeedback:{2}", Name, Grade, Feedback);
        }

        static void Main()
        {
            Console.WriteLine("Enter the Name");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[5] { 60, 75, 80, 95, 45 };
            Question9 Q9 = new Question9();
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Grade:{0}", Q9.calculate_grade(marks));


        }
    }
}
