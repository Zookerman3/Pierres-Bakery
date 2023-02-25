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
            int freePastries = pastriesOrdered / 4;
            int paidPastries = pastriesOrdered - freePastries;
            PastryTotalPrice = paidPastries * pricePerPastry;
            return PastryTotalPrice;
        }
    }
}