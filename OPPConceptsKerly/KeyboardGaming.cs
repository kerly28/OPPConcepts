using OPPConcepts;
using OPPConceptsKerly;

public class KeyBoardGaming : Peripherals, IPeripherals

{
    //Constant
    public const string Separator = "══════════════════════════════════════";

    // Getters and Setters
    public bool RGB { get; set; }
    public ColourSwitches SwitchColour { get; set; }
    public int Percentage { get; set; }
    public int CountKeys { get; set; }

    public int PriceKeyboard { get; set; }

    // Set the number of keys based on percentage
    private void SetCountKeysBasedOnPercentage()
    {
        if (Percentage == 100)
            CountKeys = 110;
        else if (Percentage == 85)
            CountKeys = 88;
        else if (Percentage == 75)
            CountKeys = 82;
        else if (Percentage == 60)
            CountKeys = 61;
    }

    // Constructor
    public KeyBoardGaming(string owner, string brand, bool rgb, ColourSwitches switchColour, int percentage, int priceTotal, int priceKeyboard)
        : base(owner, brand, priceTotal)
    {
        RGB = rgb;
        SwitchColour = switchColour;
        Percentage = percentage;
        SetCountKeysBasedOnPercentage();

        //PriceHelper for validate the keyboard price
        if (!PriceHelper.IsValidPrice(priceKeyboard))
        {
            throw new ArgumentException("The price must be a positive value! ");
        }
        PriceKeyboard = priceKeyboard;

    }

    // Show details of the keyboard
    public override void ShowDetails()
    {
        base.ShowDetails();
        Console.WriteLine(Separator);
        Console.WriteLine("      DETAILS OF THE KEYBOARD       ");
        Console.WriteLine(Separator);
        Console.WriteLine($"Lighting RGB: {(RGB ? "Yes" : "No")}"); //ternary operator
        Console.WriteLine(Separator);
        Console.WriteLine(SwitchColour.GetColourDescription());
        Console.WriteLine(Separator);
        Console.WriteLine($"Size of keyboard: {Percentage}%");
        Console.WriteLine(Separator);
        Console.WriteLine($"Total keys: {CountKeys}");
        Console.WriteLine(Separator);
        Console.WriteLine($"The price of this keyboard is {PriceKeyboard} euros");
    }
}
