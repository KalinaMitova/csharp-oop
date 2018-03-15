using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Animals
{
   public class Kitten : Cat
    {
        public Kitten(string name, double age) 
            : base(name, age, "Female")
        {
            base.SoundType = new KittenSound();
        }
    }
}
