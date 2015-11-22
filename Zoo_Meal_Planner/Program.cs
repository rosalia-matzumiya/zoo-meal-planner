using System;
using StarterProject;
using StarterProject.UI;
using StarterProject.Animals;

namespace StarterProject 
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animalKinds = new string[] { "Monkey", "Bear" };
            AnimalFeedingMenu menu = new AnimalFeedingMenu(animalKinds);
            string selectedOption;

            while ((selectedOption = menu.GetMainMenu()) != "Quit")
            {
                Animal animal  = GetMainOption(selectedOption);
                animal.Species = menu.GetSpecies(animal);
                animal.Weight  = menu.GetWeight();
                menu.DisplayRecommendation(animal);
            }
        }//end main

       
        //This method returns the user's selected option. 
        public static Animal GetMainOption(string animal)
        {
            switch (animal)
            {
                case "Monkey":
                    return new Monkey();

                case "Bear":
                    return new Bear();

                case "Quit":
                    return null;

                default:
                    throw new NotImplementedException(); //We only support monkey and bear
            }
        }//end method
    
    }
}//end class
