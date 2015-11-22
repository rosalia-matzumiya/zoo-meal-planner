using StarterProject.Animals;
using System;


namespace StarterProject.UI
{
    sealed class AnimalFeedingMenu
    {
        private const int FIRST_OPTION     = 1; 
        private const int THIRD_OPTION     = 1;
        private const int ARRAY_INDEX      = 0;
        private const int QUIT             = 3;
        private const float INVALID_WEIGHT = -999.9f;
        private const string ERROR         = "Invalid Entry.";
        private static string userInput;
        
        private string[] animalKinds;

        //This constructor sets the animalKinds array.
        public AnimalFeedingMenu(string[] animalKinds)
        {
            this.animalKinds = animalKinds;

        }//end constructor

        //Display the main menu options and return the user input i.e. Monkey, Bear, Quit 
        public string DisplayMainMenu()
        {
            Console.WriteLine( "\n" + "================");
            Console.WriteLine("Zoo Menu Planner");
            Console.WriteLine("================");
            for (int i = ARRAY_INDEX; i < animalKinds.Length; i++)
            {
                Console.WriteLine((i + FIRST_OPTION).ToString() + ". " + animalKinds[i]);
            }
            Console.WriteLine((animalKinds.Length + THIRD_OPTION).ToString() + ". Quit");
            Console.Write("Selection:     ");
            userInput = Console.ReadLine();
            return userInput;
        }//end method

        //Validate user input, based on the DisplayMainMenu() method that uses the 
        //animalKinds array which stores the animal type  i.e. Monkey, Bear
        public string GetMainMenu()
        {
            int selectedItemNumber = 0;
            userInput = DisplayMainMenu();

            while (!int.TryParse(userInput, out selectedItemNumber) 
                    || selectedItemNumber < ARRAY_INDEX
                    || selectedItemNumber > animalKinds.Length)
            {
                if (selectedItemNumber == QUIT)
                {
                    Console.WriteLine( "\n" + "Thank you.  Your session is now over.");
                    userInput = Console.ReadLine();
                    return "Quit";
                }
                Console.WriteLine(ERROR);
                userInput = DisplayMainMenu();
                selectedItemNumber++;
            }
            return animalKinds[selectedItemNumber - FIRST_OPTION];
        }//end method

        //Prompt user for species options and read the input.
        public string PromptForSpecies(Animal animal)
        {
            Console.WriteLine("\n" + "Species");
            Console.WriteLine("-------");
            for (int i = ARRAY_INDEX; i < animal.SpeciesOptions.Length; i++)
            {
                string speciesOption = animal.SpeciesOptions[i];
                Console.WriteLine((i + FIRST_OPTION).ToString() + ". {0}", speciesOption);
            }
            Console.Write("Selection:     ");
            userInput = Console.ReadLine();
            return userInput;
        }//end method

        //Validate user input, based on the PromptForSpecies() method that uses 
        //speciesOptions array which stores the animal species of a bear or a monkey. 
        //i.e. Howler, Squirrel, Colobus, Polar, Black
        public string GetSpecies(Animal animal)
        {
            int selectedIndex = 0;
            userInput = PromptForSpecies(animal);
            
            while (!int.TryParse(userInput, out selectedIndex) || selectedIndex < ARRAY_INDEX
                    || selectedIndex > animal.SpeciesOptions.Length)
            {
                Console.WriteLine(ERROR);
                userInput = PromptForSpecies(animal);
            }
            return animal.SpeciesOptions[selectedIndex - FIRST_OPTION];
        }//end method

        //Prompt user to enter a weight and read the input. Validate the user selected weight. 
        public float PromptForWeight()
        {
            int negativeWeight = 0;
            float selectedWeight;

            Console.Write("Weight in KG:  ");
            userInput = Console.ReadLine();

            if (!float.TryParse(userInput, out selectedWeight) ||  float.Parse(userInput) <= negativeWeight)
            {
                Console.WriteLine(ERROR + "\n");
                return INVALID_WEIGHT;
            }
            return selectedWeight;
        }//end method


        //Get the user selected weight and validate 
        public float GetWeight()
        {
            float input;
            do
            {
                input = PromptForWeight();
            } while (input == INVALID_WEIGHT);
            return input;
        }//end method

        //Display a meal recommendation, based on the user selected animal type, species and weight. 
        public void DisplayRecommendation(Animal animal)
        {
            Console.WriteLine("\n" + "Meal Recommendation");
            Console.WriteLine("--------------------");
            Console.WriteLine("Mammal Type:  {0}", animal.MammalType);
            Console.WriteLine("Species:      {0}", animal.Species);
            Console.WriteLine("Weight:       {0}" + " KG", animal.Weight.ToString("F"));
            Console.WriteLine("Serving:      {0} KG {1}.", animal.Serving.ToString("N3"), animal.Meal);
            Console.WriteLine("\n" + "Instructions: {0}", animal.Instructions);
            Console.WriteLine("              Feed at {0}.", animal.Time);
        }//end method
    }
}//end class
