
namespace _06_Animals
{
    public class Dog : Animal
    {
        public Dog(string name, double age, string gender) 
            : base(name, age, gender)
        {
            base.SoundType = new DogSound();
        }

    }
}
