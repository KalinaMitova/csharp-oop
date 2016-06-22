using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RawData
{
    public class Cargo
    {

        private string cargoType;
        private int cargoWeight;

        public string CargoType
        {
            get
            {
                return cargoType;
            }
            set
            {
                cargoType = value;
            }
        }

        public int CargoWeight
        {
            get
            {
                return cargoWeight;
            }
            set
            {
                cargoWeight = value;
            }
        }
    }
}
