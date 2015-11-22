using System;

namespace StarterProject.Animals
{
    sealed class Bear : Mammal 
    {
        private const string MAMMAL_TYPE = "Bear";
        private const float BLACK_WEIGHT = 0.014f;
        private const float POLAR_WEIGHT = 0.016f;
        private const float NO_WEIGHT    = 0.0f;

        //Default constructor. 
        public Bear()
            :base(MAMMAL_TYPE)
        {

        }
        
        private string[] speciesOptions = new string[] {"Black","Polar"};

        public override string[] SpeciesOptions
        {
            get { return this.speciesOptions; }
        }//end property


        public override float Serving
        {
            get
            {  
                switch (Species)
                {
                    case "Black":
                        return this.Weight * BLACK_WEIGHT;

                    case "Polar":
                        return this.Weight * POLAR_WEIGHT;

                    default:
                        return NO_WEIGHT;
                }
            }
        }//end property

        public override string Meal
        {
            get
            {
                switch(Species)
                {
                    case "Black":
                        return "berries, green vegetation, flowers, fruits, fish";

                    case "Polar":
                        return "berries, fish";

                    default:
                        return "";
                }
            }
        }//end property

        public override string Time
        {
            get
            {
                return "9AM and 3PM";
            }
        }//end property


        
    }
}//end class
