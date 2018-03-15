namespace _09Google
{
   public class Car
    {
        private string ownerName;
        private string model;
        private double speed;

       public string OwnerName => this.ownerName;
        public Car(string ownerName, string model, double speed)
        {
            this.ownerName = ownerName;
            this.model = model;
            this.speed = speed;
        }

        public override string ToString()
        {
            return $"{model} {speed:0}";
        }
    }
}
