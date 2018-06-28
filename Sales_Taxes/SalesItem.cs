using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    //This class describes a single sales item that would be added to the reciept
    public class SalesItem : ISalesItem
    {
        public string Description { get; set; }

        public decimal StockPrice { get; set; }
        public bool IsImported { get; set; }
        public int Quantity { get; set; }

        //Out: The total sales tax is calculated for the prduct based on
        //      importaion flag. The SalesTax is rounded as follows:
        //                      For a tax rate of n% the shelf price np/100
        //                      will be rounded to the nearest 0.05
        public decimal SalesTax
        {
            get
            {
                decimal totalTaxRate = (new TaxDescriptor()).GetTaxRate(this);
                decimal taxAmount = 0.000M;
                if(totalTaxRate != 0.000M)
                    taxAmount = Helper.RoundToZeroPointFive((StockPrice * totalTaxRate) / 100.000M);
                return taxAmount;
            }
        }

        //Out: The Stockprice + Calculated sales tax
        public decimal TotalPrice
        {
            get
            {
                return StockPrice + SalesTax;
            }
        }

        public ItemTypes ItemType { get; set; }

        public SalesItem(ItemTypes itemType, string description, decimal stockPrice, bool isImported, int quantity)
        {
            Description = description;
            StockPrice = stockPrice;
            ItemType = itemType;
            Quantity = quantity;
            IsImported = isImported;
        }

        public override string ToString()
        {
            //Logic to display a single item in the receipt
            return string.Format("{0, -5}{1,-30}{2,10:C2}", Quantity,  (IsImported ? "imported " : "") + Description, TotalPrice);
        }
    }
}
