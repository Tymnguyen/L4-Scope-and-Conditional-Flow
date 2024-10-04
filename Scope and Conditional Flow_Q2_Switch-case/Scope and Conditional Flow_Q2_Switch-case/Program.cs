using System;

class Program
{
    static void Main(string[] args)
    {
        // Question 1: Basic Switch Case
        Console.WriteLine("Enter a number between 1 and 3:");
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("One");
                break;
            case 2:
                Console.WriteLine("Two");
                break;
            case 3:
                Console.WriteLine("Three");
                break;
            default:
                Console.WriteLine("Invalid number");
                break;
        }

        // Question 2: Game Character Selection
        Console.WriteLine("\nChoose a character class (1-Warrior, 2-Mage, 3-Archer):");
        int characterClass = Convert.ToInt32(Console.ReadLine());
        switch (characterClass)
        {
            case 1:
                Console.WriteLine("You chose Warrior");
                break;
            case 2:
                Console.WriteLine("You chose Mage");
                break;
            case 3:
                Console.WriteLine("You chose Archer");
                break;
            default:
                Console.WriteLine("Invalid class");
                break;
        }

        // Question 3: Directional Movement
        Console.WriteLine("\nChoose a direction (1-North, 2-South, 3-East, 4-West):");
        int direction = Convert.ToInt32(Console.ReadLine());
        switch (direction)
        {
            case 1:
                Console.WriteLine("Moving North");
                break;
            case 2:
                Console.WriteLine("Moving South");
                break;
            case 3:
                Console.WriteLine("Moving East");
                break;
            case 4:
                Console.WriteLine("Moving West");
                break;
            default:
                Console.WriteLine("Invalid direction");
                break;
        }

        // Question 4: Day of the Week
        Console.WriteLine("\nEnter a number between 1 and 7 for the day of the week:");
        int day = Convert.ToInt32(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }

        // Question 5: Weapon Selection
        Console.WriteLine("\nChoose a weapon (1-Sword, 2-Bow, 3-Staff, 4-Axe):");
        int weapon = Convert.ToInt32(Console.ReadLine());
        switch (weapon)
        {
            case 1:
                Console.WriteLine("You chose Sword");
                break;
            case 2:
                Console.WriteLine("You chose Bow");
                break;
            case 3:
                Console.WriteLine("You chose Staff");
                break;
            case 4:
                Console.WriteLine("You chose Axe");
                break;
            default:
                Console.WriteLine("Invalid weapon");
                break;
        }

        // Question 6: Elemental Magic
        Console.WriteLine("\nChoose a magic spell (1-Fire, 2-Water, 3-Earth, 4-Air, 5-Lightning):");
        int spell = Convert.ToInt32(Console.ReadLine());
        switch (spell)
        {
            case 1:
                Console.WriteLine("You cast Fire");
                break;
            case 2:
                Console.WriteLine("You cast Water");
                break;
            case 3:
                Console.WriteLine("You cast Earth");
                break;
            case 4:
                Console.WriteLine("You cast Air");
                break;
            case 5:
                Console.WriteLine("You cast Lightning");
                break;
            default:
                Console.WriteLine("Invalid spell");
                break;
        }

        // Question 7: Menu Navigation
        Console.WriteLine("\nNavigate the menu (1-Start Game, 2-Options, 3-Load Game, 4-Exit):");
        int menuOption = Convert.ToInt32(Console.ReadLine());
        switch (menuOption)
        {
            case 1:
                Console.WriteLine("Starting Game...");
                break;
            case 2:
                Console.WriteLine("Opening Options...");
                break;
            case 3:
                Console.WriteLine("Loading Game...");
                break;
            case 4:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

        // Question 8: NPC Interaction
        Console.WriteLine("\nChoose an NPC interaction (1-Talk, 2-Trade, 3-Quest):");
        int interaction = Convert.ToInt32(Console.ReadLine());
        switch (interaction)
        {
            case 1:
                Console.WriteLine("You chose to Talk");
                break;
            case 2:
                Console.WriteLine("You chose to Trade");
                break;
            case 3:
                Console.WriteLine("You chose to Quest");
                break;
            default:
                Console.WriteLine("Invalid interaction");
                break;
        }

        // Question 9: Puzzle Solutions
        Console.WriteLine("\nChoose a solution (1-5):");
        int solution = Convert.ToInt32(Console.ReadLine());
        switch (solution)
        {
            case 1:
                Console.WriteLine("Solution 1 selected");
                break;
            case 2:
                Console.WriteLine("Solution 2 selected");
                break;
            case 3:
                Console.WriteLine("Solution 3 selected");
                break;
            case 4:
                Console.WriteLine("Solution 4 selected");
                break;
            case 5:
                Console.WriteLine("Solution 5 selected");
                break;
            default:
                Console.WriteLine("Invalid solution");
                break;
        }

        // Question 10: Dialogue Choices
        Console.WriteLine("\nChoose a dialogue option (1-4):");
        int dialogue = Convert.ToInt32(Console.ReadLine());
        switch (dialogue)
        {
            case 1:
                Console.WriteLine("You chose dialogue option 1");
                break;
            case 2:
                Console.WriteLine("You chose dialogue option 2");
                break;
            case 3:
                Console.WriteLine("You chose dialogue option 3");
                break;
            case 4:
                Console.WriteLine("You chose dialogue option 4");
                break;
            default:
                Console.WriteLine("Invalid dialogue choice");
                break;
        }

        // Question 11: Crafting Items
        Console.WriteLine("\nChoose a crafting recipe (1-Potion, 2-Weapon, 3-Armor):");
        int crafting = Convert.ToInt32(Console.ReadLine());
        switch (crafting)
        {
            case 1:
                Console.WriteLine("You crafted a Potion");
                break;
            case 2:
                Console.WriteLine("You crafted a Weapon");
                break;
            case 3:
                Console.WriteLine("You crafted Armor");
                break;
            default:
                Console.WriteLine("Invalid crafting option");
                break;
        }

        // Question 12: Scene Selection
        Console.WriteLine("\nChoose a scene (1-5):");
        int scene = Convert.ToInt32(Console.ReadLine());
        switch (scene)
        {
            case 1:
                Console.WriteLine("Scene 1 selected");
                break;
            case 2:
                Console.WriteLine("Scene 2 selected");
                break;
            case 3:
                Console.WriteLine("Scene 3 selected");
                break;
            case 4:
                Console.WriteLine("Scene 4 selected");
                break;
            case 5:
                Console.WriteLine("Scene 5 selected");
                break;
            default:
                Console.WriteLine("Invalid scene");
                break;
        }

        // Question 13: Quest Progression
        Console.WriteLine("\nChoose a quest (1-4):");
        int quest = Convert.ToInt32(Console.ReadLine());
        switch (quest)
        {
            case 1:
                Console.WriteLine("Quest 1 selected");
                break;
            case 2:
                Console.WriteLine("Quest 2 selected");
                break;
            case 3:
                Console.WriteLine("Quest 3 selected");
                break;
            case 4:
                Console.WriteLine("Quest 4 selected");
                break;
            default:
                Console.WriteLine("Invalid quest");
                break;
        }

        // Question 14: Potion Brewing
        Console.WriteLine("\nChoose a potion to brew (1-Health Potion, 2-Mana Potion, 3-Stamina Potion):");
        int potion = Convert.ToInt32(Console.ReadLine());
        switch (potion)
        {
            case 1:
                Console.WriteLine("You brewed a Health Potion");
                break;
            case 2:
                Console.WriteLine("You brewed a Mana Potion");
                break;
            case 3:
                Console.WriteLine("You brewed a Stamina Potion");
                break;
            default:
                Console.WriteLine("Invalid potion");
                break;
        }

        // Question 15: Platform Movement
        Console.WriteLine("\nChoose a movement direction (1-Left, 2-Right, 3-Jump, 4-Crouch):");
        int movement = Convert.ToInt32(Console.ReadLine());
        switch (movement)
        {
            case 1:
                Console.WriteLine("You moved Left");
                break;
            case 2:
                Console.WriteLine("You moved Right");
                break;
            case 3:
                Console.WriteLine("You Jumped");
                break;
            case 4:
                Console.WriteLine("You Crouched");
                break;
            default:
                Console.WriteLine("Invalid movement");
                break;
        }

        // Question 16: Weapon Upgrades
        Console.WriteLine("\nChoose a material for weapon upgrade (1-Iron, 2-Steel, 3-Gold, 4-Diamond):");
        int material = Convert.ToInt32(Console.ReadLine());
        switch (material)
        {
            case 1:
                Console.WriteLine("You upgraded your weapon with Iron");
                break;
            case 2:
                Console.WriteLine("You upgraded your weapon with Steel");
                break;
            case 3:
                Console.WriteLine("You upgraded your weapon with Gold");
                break;
            case 4:
                Console.WriteLine("You upgraded your weapon with Diamond");
                break;
            default:
                Console.WriteLine("Invalid material");
                break;
        }

        // Question 17: Spell Casting
        Console.WriteLine("\nChoose a spell element (1-Fire, 2-Water, 3-Earth, 4-Air):");
        int spellElement = Convert.ToInt32(Console.ReadLine());
        switch (spellElement)
        {
            case 1:
                Console.WriteLine("You cast a Fire spell");
                break;
            case 2:
                Console.WriteLine("You cast a Water spell");
                break;
            case 3:
                Console.WriteLine("You cast an Earth spell");
                break;
            case 4:
                Console.WriteLine("You cast an Air spell");
                break;
            default:
                Console.WriteLine("Invalid spell element");
                break;
        }

        // Question 18: Skill Selection
        Console.WriteLine("\nChoose a skill to enhance (1-Strength, 2-Agility, 3-Intelligence, 4-Vitality):");
        int skill = Convert.ToInt32(Console.ReadLine());
        switch (skill)
        {
            case 1:
                Console.WriteLine("You enhanced Strength");
                break;
            case 2:
                Console.WriteLine("You enhanced Agility");
                break;
            case 3:
                Console.WriteLine("You enhanced Intelligence");
                break;
            case 4:
                Console.WriteLine("You enhanced Vitality");
                break;
            default:
                Console.WriteLine("Invalid skill");
                break;
        }

        // Question 19: Puzzle Solutions
        Console.WriteLine("\nChoose a puzzle solution (1-5):");
        int puzzleSolution = Convert.ToInt32(Console.ReadLine());
        switch (puzzleSolution)
        {
            case 1:
                Console.WriteLine("You chose Solution 1");
                break;
            case 2:
                Console.WriteLine("You chose Solution 2");
                break;
            case 3:
                Console.WriteLine("You chose Solution 3");
                break;
            case 4:
                Console.WriteLine("You chose Solution 4");
                break;
            case 5:
                Console.WriteLine("You chose Solution 5");
                break;
            default:
                Console.WriteLine("Invalid solution choice");
                break;
        }

        // Question 20: Potion Brewing
        Console.WriteLine("\nChoose an ingredient for potion brewing (1-Herb, 2-Mushroom, 3-Flower, 4-Crystal):");
        int potionIngredient = Convert.ToInt32(Console.ReadLine());
        switch (potionIngredient)
        {
            case 1:
                Console.WriteLine("You used Herb to brew a potion.");
                break;
            case 2:
                Console.WriteLine("You used Mushroom to brew a potion.");
                break;
            case 3:
                Console.WriteLine("You used Flower to brew a potion.");
                break;
            case 4:
                Console.WriteLine("You used Crystal to brew a potion.");
                break;
            default:
                Console.WriteLine("Invalid ingredient choice");
                break;
        }

        // Question 21: NPC Interactions
        Console.WriteLine("\nChoose an NPC interaction (1-Talk, 2-Trade, 3-Quest):");
        int npcInteraction = Convert.ToInt32(Console.ReadLine());
        switch (npcInteraction)
        {
            case 1:
                Console.WriteLine("You chose to Talk with the NPC.");
                break;
            case 2:
                Console.WriteLine("You chose to Trade with the NPC.");
                break;
            case 3:
                Console.WriteLine("You chose to receive a Quest from the NPC.");
                break;
            default:
                Console.WriteLine("Invalid NPC interaction choice.");
                break;
        }

        // Question 22: Scene Navigation
        Console.WriteLine("\nChoose a scene to navigate (1-5):");
        int sceneSelection = Convert.ToInt32(Console.ReadLine());
        switch (sceneSelection)
        {
            case 1:
                Console.WriteLine("You navigated to Scene 1.");
                break;
            case 2:
                Console.WriteLine("You navigated to Scene 2.");
                break;
            case 3:
                Console.WriteLine("You navigated to Scene 3.");
                break;
            case 4:
                Console.WriteLine("You navigated to Scene 4.");
                break;
            case 5:
                Console.WriteLine("You navigated to Scene 5.");
                break;
            default:
                Console.WriteLine("Invalid scene choice.");
                break;
        }

        // Question 23: Quest Progression
        Console.WriteLine("\nChoose a quest option to progress (1-4):");
        int questProgression = Convert.ToInt32(Console.ReadLine());
        switch (questProgression)
        {
            case 1:
                Console.WriteLine("You progressed in Quest 1.");
                break;
            case 2:
                Console.WriteLine("You progressed in Quest 2.");
                break;
            case 3:
                Console.WriteLine("You progressed in Quest 3.");
                break;
            case 4:
                Console.WriteLine("You progressed in Quest 4.");
                break;
            default:
                Console.WriteLine("Invalid quest progression choice.");
                break;
        }

        // Question 24: Menu Navigation
        Console.WriteLine("\nChoose a menu option (1-Start, 2-Options, 3-Load Game, 4-Exit):");
        int menuNavigation = Convert.ToInt32(Console.ReadLine());
        switch (menuNavigation)
        {
            case 1:
                Console.WriteLine("Game started.");
                break;
            case 2:
                Console.WriteLine("Options menu opened.");
                break;
            case 3:
                Console.WriteLine("Game loading...");
                break;
            case 4:
                Console.WriteLine("Exiting game...");
                break;
            default:
                Console.WriteLine("Invalid menu option.");
                break;
        }

    }
}
