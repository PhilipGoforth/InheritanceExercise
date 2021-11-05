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

            var Cyclops = new Animal();
            Cyclops.Eyes = 1;
            Cyclops.Carnivore = true;
            Cyclops.Legs = 2;
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
            var Emu = new Bird();
            Emu.CanFly = false;
            Emu.Carnivore = false;
            Emu.Color = "brown";
            Emu.IsEdible = true;
            Emu.IsExtinct = false;
            Emu.Legs = 2;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var Aligator = new Reptile();
            Aligator.IsPoisenous = false;
            Aligator.HasWebbedFeet = true;
            Aligator.Carnivore = true;
            Aligator.Color = "green";
            Aligator.CanJump = true;
            Aligator.HasTail = true;
        }
    }
}
