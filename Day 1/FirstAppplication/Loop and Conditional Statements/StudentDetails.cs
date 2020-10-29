using System;


namespace Loop_and_Conditional_Statements
{
    class StudentDetails
    {
        static void Main()
        {
            string StudentName, SchoolName;
            int Age;
            Console.WriteLine("Enter the StudentName");
            StudentName = Console.ReadLine();
            Console.WriteLine("Enter the SchoolName");
            SchoolName = Console.ReadLine();
            Console.WriteLine("Enter the Age");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name= {0}", StudentName);
            Console.WriteLine("School= {0}", SchoolName);
            Console.WriteLine("Age {0}", Age);

            Console.Read();

        }
        
    }
}
