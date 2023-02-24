using System;

namespace PierresBakery.Models
{
    public class Bread
    {
        public int LoavesOrder {get; set; }
        public int TotalPrice {get; set; }

        public Bread(int loaves)
        {
            LoavesOrder = loaves;
            TotalPrice = GetBreadTotalPrice(loaves);
        }

        public int GetBreadTotalPrice(int loavesOrdered)
        {
            int pricePerLoaf = 5;
            int freeLoaves = loavesOrdered / 3;
            int paidLoaves = loavesOrdered - freeLoaves;
            TotalPrice = paidLoaves * pricePerLoaf;
            return TotalPrice;
        }
    }
}