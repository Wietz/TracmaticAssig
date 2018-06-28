using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Taxes
{
    internal static class Helper
    {
        /// <summary>
        /// Rounds the input number up to to  the nearest 0.05;
        /// </summary>
        /// <param name="number">A decimal number to be rounded</param>
        /// <returns>A decimal number round up to nearest 0.05</returns>
        public static decimal RoundToZeroPointFive(decimal number)
        {
            decimal fractPart = number - (Math.Truncate(number));
            decimal rndVal = Math.Round(fractPart, 2) % 0.100M;
            decimal result = 0.000M;
            string strFractVal = fractPart.ToString();
            if (rndVal < 0.050M && rndVal > 0.000M)
            {
                StringBuilder sb = new StringBuilder(strFractVal);
                sb[3] = '5';
                strFractVal = sb.ToString();
                result = Math.Truncate(number) + decimal.Parse(strFractVal);
            }
            else
            {
                result = Math.Round(number, 1);
            }

            return result;
        }

        
    }
}
