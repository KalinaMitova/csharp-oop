using System;
using System.Collections.Generic;

namespace _06_Animals
{
   public class Tomcat : Cat
    {
        public Tomcat(string name, double age) 
            : base(name, age, "Male")
        {
            base.SoundType = new TomcatSound();
        }
    }
}
