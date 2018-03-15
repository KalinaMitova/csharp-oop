
namespace _08PokemonTrainer
{
    public class Pokemon
    {
        private string nameTrainer;
        private string name;
        private string element;
        private decimal health;

        public string NameTrainer => nameTrainer;
        public string Name => this.name;
        public string Element => this.element;
        public decimal Health
        {
            get
            {
                return health;
            }
            set
            {
                health = value;
            }
        }

        public Pokemon()
        {
        }

        public Pokemon(string nameTrainer, string name, string element, decimal health)
        {
            this.nameTrainer = nameTrainer;
            this.name = name;
            this.element = element;
            this.health = health;
        }

    }
}
