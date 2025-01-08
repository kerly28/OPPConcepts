using System;
using OPPConcepts;

public class OPP
{
    public static void Main()
    {
        // Show cute title of the setup
        Console.WriteLine("═══════════════════════════════════════");
        Console.WriteLine("            GAMING SETUP ^-^             ");
        Console.WriteLine("═══════════════════════════════════════");

        // Create a colour of switches
        var colourSwitches = new ColourSwitches("Red");
        // Create a values of my keyboard gaming, Owner, Brand, RGB, ColourSwitches, Percentatge->Keys, TotalPrice, PriceSetUp
        var keyboardGaming = new KeyBoardGaming("Kerlu", "PcComponentes", true, colourSwitches, 100, 1450, 60);
        // Show details of the keyboard
        keyboardGaming.ShowDetails();
    }
}
