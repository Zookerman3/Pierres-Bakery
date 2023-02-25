using System;

namespace PierresBakery.Models
{
    public class Pastry
    {
        public int PastryOrder { get; set; }
        public int TotalPastries;
        public int PastryTotalPrice {get; set;}

        public Pastry(int pastries)
        {
            PastryOrder = pastries;
            PastryTotalPrice = GetPastryTotalPrice();
        }

        public int GetPastryTotalPrice()
        {
            int pricePerPastry = 2;
            int freePastries = this.TotalPastries / 4;
            int paidPastries = this.TotalPastries - freePastries;
            PastryTotalPrice = paidPastries * pricePerPastry;
            return PastryTotalPrice;
        }
    }
}