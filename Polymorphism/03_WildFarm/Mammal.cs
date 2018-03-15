
namespace _03_WildFarm
{
    public abstract class Mammal : Animal
    {
        public string LivingRegion { get; }

        public Mammal(string animalType, string animalName, double animalWeight, string livingRegion) 
            : base(animalType, animalName, animalWeight)
        {
            this.LivingRegion = livingRegion;
        }

        public override string ToString()
        {
            return $"{base.AnimalType}[{base.AnimalName}, {base.AnimalWeight}, {this.LivingRegion}, {base.FoodEaten}]";
        }
    }
}
