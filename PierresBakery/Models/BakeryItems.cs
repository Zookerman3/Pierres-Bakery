

namespace PierresBakery.Models
{
    public class Bread
    {
        private int _loaves;
        public int Loaves
        {
            get { return _loaves; }
            set { _loaves = value; }
        }


        public Bread(int amount)
        {
            _loaves = amount;
        }
    }
}