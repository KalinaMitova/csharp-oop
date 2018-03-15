using System.Collections.Generic;

namespace _08PokemonTrainer
{
   public  class Trainer
    {

        private string name;
        private int badges;
        private List<Pokemon> pokemons;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Badges
        {
            get
            {
                return badges;
            }
            set
            {
                badges = value;
            }
        }

        public Trainer()
        {
        }

        public Trainer(string name)
        {
            this.name = name;
            pokemons = new List<Pokemon>();
        }
        public List<Pokemon> Pokemons
        {
            get
            {
                return pokemons;
            }
            set
            {
                pokemons = value;
            }
        }
    }
}
