using System;
namespace Sales_Taxes
{
    interface IReceipt
    {
        void AddSalesItem(ISalesItem salesItem);
        void ClearSalesItems();
        void Display();
        decimal Total { get; }
        decimal TotalSalesTaxes { get; }
    }
}
