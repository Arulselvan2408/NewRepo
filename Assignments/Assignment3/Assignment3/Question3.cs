using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{class Product
    {
        int Pid, Price;
        string Pname;
      internal static string ShopName;
        internal Product(int Pid, string Pname, int price)
        {
            this.Pid = Pid;
            this.Pname = Pname;
            this.Price = price;
        }
       
      internal void Display()
        {
            Console.WriteLine("Pid: {0}\nPname: {1}\nPrice: {2}\nShopName: {3}", Pid, Pname, Price, ShopName);
        }
    }
   
       class Question3
    {static void Main()
        {
            Console.WriteLine("Enter the ShopName:");
            Product.ShopName = Console.ReadLine();
            Console.WriteLine("Enter the Value of Size");
            int size = Convert.ToInt32(Console.ReadLine());
            Product[] product = new Product[size];
            for (int i=0; i<size; i++)
            {
                Console.WriteLine("Enter the value of Pid and price");
                int Pid = Convert.ToInt32(Console.ReadLine());
                int Price = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Pname");
                string Pname = Console.ReadLine();
                product[i] = new Product(Pid, Pname, Price);
                product[i].Display();
            }
            Console.Read();

        }
    }
}
