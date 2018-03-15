
namespace _06_Animals
{
    public class Frog : Animal
    {
        public Frog(string name, double age, string gender) 
            : base(name, age, gender)
        {
            base.SoundType = new FrogSound();
        }
    }
}
