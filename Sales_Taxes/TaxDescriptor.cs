using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    //This class describes the tax rates for different types of products
    //In a normal solution this data would be stored in a database abd a database repository will be used 
    //to read an populate the Dictionary
    internal class TaxDescriptor
    {
        
        private Dictionary<ItemTypes, decimal> _taxRates;

        public TaxDescriptor()
        {
            _taxRates = new Dictionary<ItemTypes, decimal>();
            LoadTaxRates();
        }

        private void LoadTaxRates()
        {
            _taxRates.Add(ItemTypes.Book, 0.000M);
            _taxRates.Add(ItemTypes.Food, 0.000M);
            _taxRates.Add(ItemTypes.Medical, 0.000M);
            _taxRates.Add(ItemTypes.Other, 10.000M);
            _taxRates.Add(ItemTypes.Imported, 5.000M);
        }

        public decimal GetTaxRate(SalesItem saleItem)
        {
            decimal totalTaxRate = 0.000M;

            //First add importation tax for imported products
            if (saleItem.IsImported)
                totalTaxRate += _taxRates[ItemTypes.Imported];

            //Then add the stndard tax as per the tax table
            totalTaxRate += _taxRates[saleItem.ItemType];
            return totalTaxRate;
        }
    }
}
