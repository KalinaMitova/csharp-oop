
namespace _06_Animals
{
   public abstract class Sound
    {
        private string makeSound ;

        protected string MakeSound
            {
            get { return this.makeSound; }
            set
            {
                this.makeSound = value;
            }
            }

        public  string ProduceSound()
        {
            return this.MakeSound;
        }
    }
}
