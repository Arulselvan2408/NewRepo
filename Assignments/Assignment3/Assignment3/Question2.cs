using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class SalesDetails
    {
        int SalesNO, ProductNo, Price, Quantity, TotalAmount;
        DateTime DateofSale;
        internal SalesDetails(int SalesNo, int ProductNo, int Price, int Quantity, DateTime DateofSale)
        {
            this.SalesNO = SalesNo;
            this.Price = Price;
            this.ProductNo = ProductNo;
            this.Quantity = Quantity;
            this.DateofSale = DateofSale;
        }
        internal int Sales()
        {
            TotalAmount = Quantity * Price;
            return TotalAmount;
        }
        internal void ShowData()
        {
            Console.WriteLine("SalesNo:{0}\nProductNo:{1}\nPrice:{2}\nQuantity{3}\nDate of Sale:{4}", SalesNO, ProductNo, Price, Quantity, DateofSale);
            Console.WriteLine("The Total Amount is :{ 0}", TotalAmount);
        }

    } 
    
    class Question2
    {
        static void Main()
        {
            SalesDetails SD = new SalesDetails(1,102,65100,2,"08-24-1997 12:00" );
            SD.ShowData();
            SD.Sales();
            Console.Read();

        }

    }
}
