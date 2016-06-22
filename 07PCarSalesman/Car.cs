using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PCarSalesman
{
    public class Car
    {
        private string model;
        private string engineModel;
        private string weight;
        private string color;

        public string Model => this.model;
        public string Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
  
        public string EnginesModel => this.engineModel;

        public Car()
        {
        }

        public Car(string model, string engineModel)
        {
            this.model = model;
            this.engineModel = engineModel;
            weight = "n/a";
            color = "n/a";
        }

        public Car(string model, string engine, string weight)
            :this(model, engine)
        {
           this.weight = weight;
        }

        public Car(string model, string engine, string weight, string color)
            : this(model, engine, weight)
        {
            this.color = color;
        }
    }
}
