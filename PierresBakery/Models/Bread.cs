using System;

namespace PierresBakery.Models
{
    public class Bread
    {
        public int LoavesOrder {get; set; }
        public int TotalLoaves {get; set; }
        public int TotalPrice {get; set; }

        public Bread(int loaves)
        {
            LoavesOrder = loaves;
            TotalPrice = GetBreadTotalPrice();
        }

        public int GetBreadTotalPrice()
        {
            int pricePerLoaf = 5;
            int freeLoaves = this.TotalLoaves / 3;
            int paidLoaves = this.TotalLoaves - freeLoaves;
            TotalPrice = paidLoaves * pricePerLoaf;
            return TotalPrice;
        }
    }
}