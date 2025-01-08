using System;

namespace OPPConcepts
{
    public abstract class SetUp
    {
        //Getters and setters
        public string? Owner { get; set; }
        public int TotalPrice { get; set; }

        // Constructor
        public SetUp(string owner, int totalPrice)
        {
            Owner = owner;

            // Validate the price before assigning it (Class Helper ValidPrice)
            if (!PriceHelper.IsValidPrice(totalPrice))
            {
                throw new ArgumentException("The price must be a positive value.");
            }
            TotalPrice = totalPrice;
        }

        // Show info of the setup 
        public void InfoOfSetup()
        {
            Console.WriteLine($"This setup is from {Owner}, and it has cost {TotalPrice} euros");
        }
    }
}
