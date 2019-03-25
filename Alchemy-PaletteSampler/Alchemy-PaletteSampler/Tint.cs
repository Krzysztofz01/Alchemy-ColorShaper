namespace Alchemy_PaletteSampler
{
    class Tint
    {
        private string color;
        private int amount;

        public Tint(string a)
        {
            color = a;
            amount = 1;
        }

        public void add()
        {
            amount++;
        }

        public string printColor()
        {
            return color;
        }

        public int getAmount()
        {
            return amount;
        }
    }
}
