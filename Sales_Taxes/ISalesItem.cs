using System;
namespace Sales_Taxes
{
    internal interface ISalesItem
    {
        string Description { get; set; }
        decimal TotalPrice { get; }
        bool IsImported { get; set; }
        ItemTypes ItemType { get; set; }
        int Quantity { get; set; }
        decimal SalesTax { get; }
        decimal StockPrice { get; set; }
        string ToString();
    }
}
