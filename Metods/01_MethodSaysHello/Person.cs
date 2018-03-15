namespace _01_MethodSaysHello
{
    public class Persons
    {
        public string name;

        public Persons(string name)
        {
            this.name = name;
        }

        public string SayHello()
        {
            return $"{this.name} says \"Hello\"!";
        }
    }
}
