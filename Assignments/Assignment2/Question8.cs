using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Question8
    {
        void CourseDetails(int Cid, string Cname, int feeamount)
        {
            Console.WriteLine("Courseid ={0}\nCourse Name={1}\nFee Amount={2}", Cid, Cname, feeamount);
        }
        static void Main()
        {
            Console.WriteLine("Enter the CourseID");
            int Courseid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Course Name");
            string CourseName=Console.ReadLine();
            Console.WriteLine("Enter the Fee Amount");
            int feeamount = Convert.ToInt32(Console.ReadLine());
            Question8 Q8 = new Question8();
            Q8.CourseDetails(Courseid, CourseName, feeamount);
            Console.Read();

        }
    }
}
