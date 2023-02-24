using System;

namespace PierresBakery.Models
{
    public class Pastry
    {
        public int PastryOrder { get; set; }

        public Pastry(int pastries)
        {
            PastryOrder = pastries;
        }
    }
}