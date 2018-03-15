using System;

namespace _03_Mordor_sCrueltyPlan
{
    public class FoodFactory
    {
        private string name;
        public const int HappinessPoints = -1;

        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (value.Length <=0)
                {
                    throw new ArgumentException($"Invalid food name!");
                }
                this.name = value;
            }
        }

        public FoodFactory(string name)
        {
            this.Name = name;
        }
    }
}
