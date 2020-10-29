using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Question2
    {
        static void Main()
        {
            char[] alphabets = new char[26] {'a', 'b', 'c', 'd', 'e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};
            int i = 0, j = 25;
            while (i<= j)
            {
                Console.WriteLine(alphabets[i]);
                i = i+1;
            }
            Console.Read();

                
        }
    }
}
