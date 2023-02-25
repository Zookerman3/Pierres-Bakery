using System;

namespace PierresBakery.Models
{
    public class Pastry
    {
        public int PastryOrder { get; set; }
        public int PastryTotalPrice {get; set;}

        public Pastry(int pastries)
        {
            PastryOrder = pastries;
            PastryTotalPrice = GetPastryTotalPrice(pastries);
        }

        public int GetPastryTotalPrice(int pastriesOrdered)
        {
            int pricePerPastry = 2;
            PastryTotalPrice = pastriesOrdered * pricePerPastry;
            return PastryTotalPrice;
        }
    }
}