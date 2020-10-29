using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{

    class Area
    {
        void AreaofSquare(int Side)
        {
            Console.WriteLine("Area of square ={0}", Side * Side);
        }
        void AreaofRectangle(int Length, int Breadth)
        {
            Console.WriteLine("Areaof Rectangle={0}", Length * Breadth);
        }
        static void Main()
        {

            int Side, Length, Breadth;
            Console.WriteLine("Enter the side of Square");
            Side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of the Rectangle");
            Length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of the Rectangle");
            Breadth = Convert.ToInt32(Console.ReadLine());

            Area area = new Area();
            area.AreaofSquare(Side);
            area.AreaofRectangle(Length, Breadth);
            Console.Read();

        }
    }
}

