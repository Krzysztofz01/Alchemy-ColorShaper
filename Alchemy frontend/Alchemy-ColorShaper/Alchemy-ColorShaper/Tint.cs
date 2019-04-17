namespace Alchemy_ColorShaper
{
    class Tint
    {
        //Tint class is a simple container to hold the Hex value of a color and the amount occurrences

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
