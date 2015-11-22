using System;

namespace StarterProject.Animals
{
    public abstract class Mammal : Animal
    {
        //Default constructor. 
        public Mammal(string mammalType)
            :base(mammalType)
        {

        }//end constructor

        //This property returns the instructions. 
        public override string Instructions
        {
            get
            {
                return "Keep area secure at all times.";
            }
        }//end property

    }
}//end class
