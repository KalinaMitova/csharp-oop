namespace _09Google
{
    public class Pokemon
    {
        private string ownerName;
        private string pocName;
        private string type;

        public string OwnerName => this.ownerName;

        public Pokemon(string ownerName, string pocName, string type)
        {
            this.ownerName = ownerName;
            this.pocName = pocName;
            this.type = type;
        }

        public override string ToString()
        {
            return $"{pocName} {type}";
        }

    }
}
