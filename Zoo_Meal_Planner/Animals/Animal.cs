using System;

namespace StarterProject.Animals
{

    public abstract class Animal
    {
        public string MammalType { get; set; }            //i.e. Monkey or Bear
        public virtual string Species { get; set; }       //i.e. Squirrel, Howler, Colobus, Polar, Black
        public virtual float Weight { get; set; }         //Based on user input
        public abstract float Serving { get; }            //Depending on the user's selected weight multiplied by 
        public abstract string Meal { get; }              //Based on the user's selected mammal type
        public abstract string Time { get; }              //Based on the user's selected mammal type
        public abstract string Instructions { get; }      //They both share the same instructions
        public abstract string[] SpeciesOptions { get; }  //Depending on the user's selected mammal type

        //Default constructor.
        public Animal()
        {

        }//end constructor

        //This constructor sets the mammal type.
        public Animal(string mammalType)
        {
            this.MammalType = mammalType;
        }//end constructor
    }
}//end class
