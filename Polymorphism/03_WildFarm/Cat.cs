
namespace _03_WildFarm
{
    public class Cat : Felime
    {
        public string Breed { get; }

        public Cat(string animalName, double animalWeight, string livingRegion, string breed) 
            : base("Cat", animalName, animalWeight, livingRegion)
        {
            this.Breed = breed;
        }

        public override string MakeSound()
        {
            return $"Meowwww";
        }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName}, {base.LivingRegion}, {base.AnimalWeight}, {this.Breed}, {base.FoodEaten}]";
        }
    }
}
