namespace Alchemy_ColorShaper
{
    class Tint
    {
        private string color;
        private int amount;

        public Tint(string inputColor)
        {
            color = inputColor;
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
