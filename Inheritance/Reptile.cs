using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile() 
        {
            Name = "Iguana";
            NumberOfLegs = 4;
            RunFast = "medium";
            LargeOrSmall = "small";

        }

        public bool Friendly { get; set; }
        public bool Poisonous { get; set; }
        public string WarmCold { get; set; }    
        public bool Scales { get; set; }




    }
}
