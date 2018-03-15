
namespace _06_Animals
{
    public class Cat : Animal
    {
        public Cat(string name, double age, string gender) 
            : base(name, age, gender)
        {
            base.SoundType = new CatSound();
        }
    }
}
