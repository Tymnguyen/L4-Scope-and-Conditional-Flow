using System;

class Program
{
    static void Main(string[] args)
    {
        //////////////////// Part 1 ////////////////////

        //There are scope-related errors in the code. Fix the scope-related errors in the code.

        Console.WriteLine("You're on a quest to find a hidden treasure deep in the forest.");
        Console.WriteLine("You stumble upon an ancient cave with mysterious inscriptions.");

        // Enter the cave to explore
        Console.WriteLine("\nYou enter the dark cave, your heart pounding with excitement.");

        // Declare your character's health and energy levels outside the block so they can be accessed globally in this context.
        int health = 100;
        int energy = 50;
        int treasureChestGold = 0;  // Declare treasureChestGold outside the block

        // Start a new block for inside the cave
        {
            // Declare a variable for finding a treasure chest
            treasureChestGold = 1000;
            // Explore the cave and find the treasure chest
            Console.WriteLine("\nYou stumble upon an old treasure chest, hidden beneath rubble!");
            Console.WriteLine("Your eyes widen as you uncover the gleaming gold coins inside.");
            Console.WriteLine("You found " + treasureChestGold + " gold coins!");
        }

        // Access treasureChestGold outside the block
        Console.WriteLine("\nWith your newfound wealth, you continue your journey deeper into the forest.");
        Console.WriteLine("Your health: " + health);
        Console.WriteLine("Your energy: " + energy);
        Console.WriteLine("You count your gold coins outside the cave: " + treasureChestGold);


        //////////////////// Part 2 ////////////////////

        //There are scope-related errors in the code. Fix the scope-related errors in the code.

        Console.WriteLine("You arrive at the crime scene, a dimly lit alleyway shrouded in mystery.");
        Console.WriteLine("Your keen eyes scan the surroundings for any clues.");

        // Declare variables for evidence found at the crime scene
        string evidence1;
        string evidence2;
        string fingerprint = "";  // Declare fingerprint outside the block

        // Begin your investigation
        Console.WriteLine("\nYou start gathering evidence, carefully collecting any clues left behind.");

        // Start a new block for searching the crime scene
        {
            // Assign a value to the fingerprint variable
            fingerprint = "Unknown";
            // Investigate further and find a torn piece of cloth
            Console.WriteLine("\nYou discover a torn piece of cloth with a mysterious symbol.");
            Console.WriteLine("Your heart races as you realize its significance: " + fingerprint);
            // Store the discovered evidence
            evidence1 = "Torn cloth with mysterious symbol";
            evidence2 = "Unknown";
        }

        // Access the fingerprint variable outside the block
        Console.WriteLine("\nYou carefully analyze the fingerprint: " + fingerprint);

        // Continue your investigation
        Console.WriteLine("\nWith the evidence collected, you piece together the puzzle of the crime.");


        //////////////////// Part 3 ////////////////////

        // There are scope-related errors in the code. Fix the scope-related errors in the code.

        Console.WriteLine("You step into the laboratory, surrounded by rows of sophisticated equipment and bubbling beakers.");
        Console.WriteLine("Your mission is to uncover the secrets of a mysterious substance.");

        // Declare variables for lab experiment results
        double result1;
        double result2;
        double concentration = 0;  // Declare concentration outside the block

        // Begin your experiment
        Console.WriteLine("\nYou set up your equipment and prepare to conduct the experiment.");

        // Start a new block for conducting the experiment
        {
            // Assign a value to the concentration variable
            concentration = 0.5;
            // Perform the experiment and observe the first result
            Console.WriteLine("\nYou conduct the first experiment and observe the results.");
            result1 = concentration * 10;
            // Store the first experiment result
            result2 = result1 / 2;
            Console.WriteLine("Result 1: " + result1);
        }

        // Access the concentration variable outside the block
        Console.WriteLine("You analyze the concentration of the substance: " + concentration);

        // Continue your experiments
        Console.WriteLine("\nWith the first results obtained, you continue your experiments to unravel the mystery.");
    }
}
