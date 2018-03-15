namespace _11CatLady
{
   public class Cat
    {
        private string name;
        private string type;
        private int earSizeOreardecibelsOfMeowsSize;
        private double furLength;

        public string Name => this.name;
        public string Type => this.type;
        public int EarSizeOreardecibelsOfMeowsSize => this.earSizeOreardecibelsOfMeowsSize;
        public double FurLenght => this.furLength;

        public Cat(string siameseOrStreetExtraordinaire, string nameSiamese, int earSizeOreardecibelsOfMeowsSize)
        {
            type = siameseOrStreetExtraordinaire;
            name = nameSiamese;
            this.earSizeOreardecibelsOfMeowsSize = earSizeOreardecibelsOfMeowsSize;
        }

        public Cat(string cymric, string name, double furLength)
        {
            type = cymric;
            this.name = name;
            this.furLength = furLength;

        }
    }
}
