using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird() 
        {
            Name = "Robin";
            NumberOfLegs = 2;
            RunFast = "slow"; 
            LargeOrSmall = "small";   
                
        }
        


            public bool CanFly { get; set; }
            public bool Migrates { get; set; }  
            public bool Farmed { get; set; }    
            public bool Tropical { get; set; }  


        

    }




    

    
}
