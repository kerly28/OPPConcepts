using OPPConcepts;
using OPPConceptsKerly;

public abstract class Peripherals : SetUp, IPeripherals
{
    //Getters and setters
    public string Brand { get; set; }

    //Constructor
    public Peripherals(string owner, string brand, int priceTotal) : base(owner, priceTotal)
    {
        Brand = brand;
    }

    public virtual void ShowDetails()
    {
        InfoOfSetup();
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine($"The peripherals of this setup are from: {Brand}");
    }
}
