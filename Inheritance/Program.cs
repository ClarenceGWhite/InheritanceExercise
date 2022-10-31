using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var myBird = new Bird();

            myBird.CanFly = true;
            myBird.Migrates = true;
            myBird.Farmed = false;
            myBird.Tropical = false;


            


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var myReptile = new Reptile();
            
            myReptile.Friendly = true;
            myReptile.Poisonous = false;
            myReptile.WarmCold = "Cold";
            myReptile.Scales = false;


            

            Console.WriteLine($"The {myBird.Name} is a {myBird.LargeOrSmall} animal that runs {myBird.RunFast} and has {myBird.NumberOfLegs} legs.");
            Console.WriteLine($"It can fly: {myBird.CanFly}.");
            Console.WriteLine($"It migrates: {myBird.Migrates}.");
            Console.WriteLine($"It is tropical: {myBird.Tropical}");
            Console.WriteLine($"It is farmed: {myBird.Farmed}");

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"The {myReptile.Name} is a {myReptile.LargeOrSmall} animal that runs {myReptile.RunFast} and has {myReptile.NumberOfLegs} legs.");
            Console.WriteLine($"It is friendly: {myReptile.Friendly}.");
            Console.WriteLine($"It is poisonous: {myReptile.Poisonous}.");
            Console.WriteLine($"It is cold or warm blooded: {myReptile.WarmCold}");
            Console.WriteLine($"It has scales: {myReptile.Scales}");

        }
    }
}
