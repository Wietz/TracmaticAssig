using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    class Program
    {
        static void Main(string[] args)
        {
            IReceipt r = new Receipt();

            //Adding sales items to receipt
            r.AddSalesItem(new SalesItem(ItemTypes.Book, "book", 12.409M, false, 1));
            r.AddSalesItem(new SalesItem(ItemTypes.Other, "music CD", 14.990M, false, 1));
            r.AddSalesItem(new SalesItem(ItemTypes.Food, "chocolate bar", 0.850M, false, 1));

            Console.WriteLine("\n\nOuput 1");
            r.Display();

            r.ClearSalesItems();
            r.AddSalesItem(new SalesItem(ItemTypes.Food, "box of chocolates", 10.000M, true, 1));
            r.AddSalesItem(new SalesItem(ItemTypes.Other, "bottle of perfume", 47.500M, true, 1));
            

            Console.WriteLine("\n\nOutput 2");
            r.Display();

            r.ClearSalesItems();
            r.AddSalesItem(new SalesItem(ItemTypes.Other, "bottle of perfume", 27.990M, true, 1));
            r.AddSalesItem(new SalesItem(ItemTypes.Other, "bottle of perfume", 18.990m, false, 1));
            r.AddSalesItem(new SalesItem(ItemTypes.Medical, "packet of headache pills", 9.750M, false, 1));
            r.AddSalesItem(new SalesItem(ItemTypes.Food, "box of chocolates", 11.250M, true, 1));

            Console.WriteLine("\n\nOutput 3");
            r.Display();

            Console.ReadLine();
        }
    }
}
