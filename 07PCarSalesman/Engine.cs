using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PCarSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private string displacements;
        private string efficiancy;

        public string Model => this.model;
        public int Power => this.power;
        public string Displacements
        {
            get
            {
                return displacements;
            }
            set
            {
                displacements = value;
            }
        }
        public string Efficiancy
        {
            get
            {
                return efficiancy;
            }
            set
            {
                efficiancy = value;
            }
        }
        public Engine()
        {
        }

        public Engine(string model, int power)
        {
            this.model = model;
            this.power = power;
            displacements = "n/a";
            efficiancy = "n/a";
        }

        public Engine(string model, int power, string displacements)
            :this(model, power)
        {
            this.displacements = displacements;
        }

        public Engine(string model, int power, string displacements, string efficiancy)
            : this(model, power, displacements)
        {
            this.efficiancy = efficiancy;
        }

    }
}
