using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    //A class the holds and manages a list of sales items. The class is also reponsible for the displaying the receipt
    internal class Receipt : Sales_Taxes.IReceipt
    {
        private List<ISalesItem> _salesItems;
        public decimal TotalSalesTaxes { get; private set; }
        public decimal Total { get; private set; }

        public Receipt()
        {
            _salesItems = new List<ISalesItem>();
        }

        public void AddSalesItem(ISalesItem salesItem)
        {
            _salesItems.Add(salesItem);
        }

        public void ClearSalesItems()
        {
            _salesItems.Clear();
            TotalSalesTaxes = 0.000M;
            Total = 0.00M;
        }

        //Displays the receipt with columns followed by a list of sales items
        public void Display()
        {
            TotalSalesTaxes = 0;
            Console.WriteLine("{0,-5}{1,-30}{2,10}", "Qty", "Description", "Amount");
            Console.WriteLine("-".PadRight(45, '-'));
            foreach(ISalesItem salesItem in _salesItems)
            {
                TotalSalesTaxes += salesItem.SalesTax;
                Total += salesItem.TotalPrice;
                Console.WriteLine(salesItem.ToString());
            }
            
            Console.WriteLine("=".PadRight(45, '='));
            Console.WriteLine("{0, -35}{1,10:C2}", "Sales Taxes", TotalSalesTaxes);
            Console.WriteLine("{0, -35}{1,10:C2}", "Total", Total);

        }
    }
}
