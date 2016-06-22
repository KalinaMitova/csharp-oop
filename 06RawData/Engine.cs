using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06RawData
{
   public class Engine
    {
        private int enginePower;
        private int engineSpeed;

        public int EnginePower
        {
            get
            {
                return enginePower;
            }
            set
            {
                enginePower = value;
            }
        }

        public int EngineSpeed
        {
            get
            {
                return engineSpeed;
            }
            set
            {
                engineSpeed = value;
            }
        }
    }
}
