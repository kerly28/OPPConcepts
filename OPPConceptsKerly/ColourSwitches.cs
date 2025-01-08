using System;

namespace OPPConcepts
{
    public class ColourSwitches
    {
        public string ColourName { get; set; }

        // Constructor
        public ColourSwitches(string colourName)
        {
            // Validar que el color sea uno de los permitidos
            if (colourName == "Red" || colourName == "Blue" || colourName == "Brown" || colourName == "Black")
            {
                ColourName = colourName;
            }
            else
            {
                throw new ArgumentException("The colour of the switches can only be Red, Blue, Brown or Black");
            }
        }

        // Método para obtener la descripción del color 
        public string GetColourDescription()
        {
            return $"Switch colour: {ColourName}";
        }
    }
}
