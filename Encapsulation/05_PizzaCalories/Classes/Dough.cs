using System;

namespace _05_PizzaCalories
{
   public class Dough
    {
        private const int caloriesBasicPerGram = 2;
        private const double whiteFactor = 1.5;
        private const double wholegrainFactor = 1.0;
        private const double crispyFactor = 0.9;
        private const double chewyFactor = 1.1;
        private const double homemadeFactor = 1.0;


        private string flour;
        private string bakingTechnique;
        private double weight;

        public string Flour
        {
            get {return this.flour; }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }
                this.flour = value;
            }
        }

        public string BakingTechnique
        {
            get { return this.bakingTechnique; }
            private set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }
                this.bakingTechnique = value;
            }
        }

        public double Weight
        {
            get { return this.weight; }
            private set
            {
                if (value < 1  || value > 200)
                {
                    throw new ArgumentException($"Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public string PizzaFlour
        {
            get { return this.flour; }
            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new ArgumentException($"Invalid type of dough.");
                }
                this.flour = value;
            }
        }
        public Dough(string flour, string bakingTechnique, double weight)
        {
            this.Flour = flour;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }

        public Dough()
        {

        }

        public double GetCaloriesOfDough ()
        {
            return CalculateCalories();
        }
        private double CalculateCalories ()
        {
            double flourFactor = 0;
            double baikingFactor = 0;
            
            switch (this.Flour.ToLower())
            {
                case "white": flourFactor = whiteFactor; break;
                case "wholegrain": flourFactor = wholegrainFactor; break;
            }

            switch (this.BakingTechnique.ToLower())
            {
                case "crispy": baikingFactor = crispyFactor; break;
                case "chewy": baikingFactor = chewyFactor; break;
                case "homemade": baikingFactor = homemadeFactor; break;
            }
            return this.Weight * caloriesBasicPerGram * flourFactor * baikingFactor;
        }
    }
}
