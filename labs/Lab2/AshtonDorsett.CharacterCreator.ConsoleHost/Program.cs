/*
* Ashton Dorsett
* ITSE 1430
* Lab 2
*/

namespace AshtonDorsett.CharacterCreator.ConsoleHost
{
    /// <summary>
    /// Provides a console host for the character creator.
    /// </summary>
    internal class Program
    {
        private static bool quit = false;
        private static Character character = null;

        /// <summary>
        /// Maintains the main loop of the program.
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("ITSE 1430 Character Creator - Ashton Dorsett Fall 2023");
            do
            {
                DisplayMenu();
                HandleInput(Console.ReadLine().ToLower());
            }
            while (!quit);
        }

        /// <summary>
        /// Displays the main menu.
        /// </summary>
        private static void DisplayMenu()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("C | Create a new character");
            Console.WriteLine("E | Edit an existing character");
            Console.WriteLine("D | Delete an existing character");
            Console.WriteLine("V | View an existing character");
            Console.WriteLine("Q | Quit");
            Console.WriteLine("------------------------------------------------------");
            Console.Write("> ");
        }

        /// <summary>
        /// Handles the user input for the main menu.
        /// </summary>
        /// <param name="input">Input for main menu.</param>
        private static void HandleInput(string input)
        {
            switch (input)
            {
                case "c":
                character = CreateNewCharacter();
                break;

                case "v":
                ViewCharacter();
                break;

                case "e":
                EditCharacter();
                break;

                case "d":
                DeleteCharacter();
                break;

                case "q":
                Console.Write("Really quit? (Y/N) ");
                var confirm = Console.ReadLine().ToLower();
                if (confirm == "y") quit = true;
                else Console.WriteLine("Not quitting.");
                break;

                default:
                    Console.WriteLine("That is not an option.");
                    break;
            }
        }

        /// <summary>
        /// Creates a new character.
        /// </summary>
        /// <returns>Newly created character.</returns>
        private static Character CreateNewCharacter()
        {
            var character = new Character();

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Create a new character");
            Console.WriteLine("------------------------------------------------------");

            do
            {
                Console.Write("Enter a name: ");
                var name = Console.ReadLine().Trim();
                if (String.IsNullOrEmpty(name)) Console.WriteLine("Name cannot be empty.");
                else
                {
                    character.Name = name;
                    break;
                }
            }
            while (true);

            do
            {
                Console.Write("Enter a profession: ");
                var input = Console.ReadLine();
                if (Enum.TryParse(input, true, out Profession profession))
                {
                    character.Profession = profession;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid profession.");
                    Console.WriteLine($"Valid professions are: {String.Join(", ", Enum.GetNames(typeof(Profession)))}");
                }
            }
            while (true);

            do
            {
                Console.Write("Enter a race: ");
                var input = Console.ReadLine();
                if (Enum.TryParse(input, true, out Race race))
                {
                    character.Race = race;
                    break;
                } else
                {
                    Console.WriteLine("That is not a valid race.");
                    Console.WriteLine($"Valid races are: {String.Join(", ", Enum.GetNames(typeof(Race)))}");
                }
            }
            while (true);

            // This is an optional field, does not need validation.
            Console.Write("Enter a biography (optional): ");
            character.Biography = Console.ReadLine();

            do
            {
                Console.Write("Enter strength (1-100): ");
                var input = Console.ReadLine();
                if (Int32.TryParse(input, out var strength) && strength >= 1 && strength <= 100)
                {
                    character.Strength = strength;
                    break;
                } else
                {
                    Console.WriteLine("That is not a valid strength.");
                    Console.WriteLine("Strength must be a number between 1 and 100.");
                }
            }
            while (true);

            do
            {
                Console.Write("Enter intelligence (1-100): ");
                var input = Console.ReadLine();
                if (Int32.TryParse(input, out var intelligence) && intelligence >= 1 && intelligence <= 100)
                {
                    character.Intelligence = intelligence;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid intelligence.");
                    Console.WriteLine("Intelligence must be a number between 1 and 100.");
                }
            }
            while (true);

            do
            {
                Console.Write("Enter agility (1-100): ");
                var input = Console.ReadLine();
                if (Int32.TryParse(input, out var agility) && agility >= 1 && agility <= 100)
                {
                    character.Agility = agility;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid agility.");
                    Console.WriteLine("Agility must be a number between 1 and 100.");
                }
            }
            while (true);

            do
            {
                Console.Write("Enter constitution (1-100): ");
                var input = Console.ReadLine();
                if (Int32.TryParse(input, out var constitution) && constitution >= 1 && constitution <= 100)
                {
                    character.Constitution = constitution;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid constitution.");
                    Console.WriteLine("Constitution must be a number between 1 and 100.");
                }
            }
            while (true);

            do
            {
                Console.Write("Enter charisma (1-100): ");
                var input = Console.ReadLine();
                if (Int32.TryParse(input, out var charisma) && charisma >= 1 && charisma <= 100)
                {
                    character.Charisma = charisma;
                    break;
                }
                else
                {
                    Console.WriteLine("That is not a valid charisma.");
                    Console.WriteLine("Charisma must be a number between 1 and 100.");
                }
            }
            while (true);

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Character created!");
            Console.WriteLine("------------------------------------------------------");
            
            return character;
        }

        /// <summary>
        /// Displays the character information.
        /// </summary>
        private static void ViewCharacter()
        {
            if (character == null)
            {
                Console.WriteLine("There is no character to view.");
                return;
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("View character");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine($"Name: {character.Name}");
            Console.WriteLine($"Profession: {character.Profession}");
            Console.WriteLine($"Race: {character.Race}");
            if (!String.IsNullOrEmpty(character.Biography)) Console.WriteLine($"Biography: {character.Biography}");
            Console.WriteLine($"Strength: {character.Strength}");
            Console.WriteLine($"Intelligence: {character.Intelligence}");
            Console.WriteLine($"Agility: {character.Agility}");
            Console.WriteLine($"Constitution: {character.Constitution}");
            Console.WriteLine($"Charisma: {character.Charisma}");
        }
    
        /// <summary>
        /// Displays the edit menu and handles user input.
        /// </summary>
        private static void EditCharacter()
        {
            if (character == null)
            {
                CreateNewCharacter();
                return;
            }

            do
            {
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("Edit character");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("What would you like to edit?");
                Console.WriteLine($"N | Name ({character.Name})");
                Console.WriteLine($"P | Profession ({character.Profession})");
                Console.WriteLine($"R | Race ({character.Race})");
                Console.WriteLine($"B | Biography ({character.Biography})");
                Console.WriteLine($"S | Strength ({character.Strength})");
                Console.WriteLine($"I | Intelligence ({character.Intelligence})");
                Console.WriteLine($"A | Agility ({character.Agility})");
                Console.WriteLine($"C | Constitution ({character.Constitution})");
                Console.WriteLine($"H | Charisma ({character.Charisma})");
                Console.WriteLine("\nQ | Go back to menu");
                Console.WriteLine("------------------------------------------------------");
                Console.Write("> ");
                var input = Console.ReadLine().ToLower();
                
                switch (input)
                {
                    case "n":
                    do
                    {
                        Console.Write("Enter a name: ");
                        var name = Console.ReadLine().Trim();
                        if (String.IsNullOrEmpty(name)) Console.WriteLine("Name cannot be empty.");
                        else
                        {
                            character.Name = name;
                            break;
                        }
                    }
                    while (true);
                    break;

                    case "p":
                    do
                    {
                        Console.Write("Enter a profession: ");
                        var profInput = Console.ReadLine();
                        if (Enum.TryParse(profInput, true, out Profession profession))
                        {
                            character.Profession = profession;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid profession.");
                            Console.WriteLine($"Valid professions are: {String.Join(", ", Enum.GetNames(typeof(Profession)))}");
                        }
                    }
                    while (true);
                    break;

                    case "r":
                    do
                    {
                        Console.Write("Enter a race: ");
                        var raceInput = Console.ReadLine();
                        if (Enum.TryParse(raceInput, true, out Race race))
                        {
                            character.Race = race;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid race.");
                            Console.WriteLine($"Valid races are: {String.Join(", ", Enum.GetNames(typeof(Race)))}");
                        }
                    }
                    while (true);
                    break;

                    case "b":
                    Console.Write("Enter a biography (optional): ");
                    character.Biography = Console.ReadLine();
                    break;

                    case "s":
                    do
                    {
                        Console.Write("Enter strength (1-100): ");
                        var strengthInput = Console.ReadLine();
                        if (Int32.TryParse(strengthInput, out var strength) && strength >= 1 && strength <= 100)
                        {
                            character.Strength = strength;
                            break;
                        } else
                        {
                            Console.WriteLine("That is not a valid strength.");
                            Console.WriteLine("Strength must be a number between 1 and 100.");
                        }
                    }
                    while (true);
                    break;

                    case "i":
                    do
                    {
                        Console.Write("Enter intelligence (1-100): ");
                        var intelligenceInput = Console.ReadLine();
                        if (Int32.TryParse(intelligenceInput, out var intelligence) && intelligence >= 1 && intelligence <= 100)
                        {
                            character.Intelligence = intelligence;
                            break;
                        } else
                        {
                            Console.WriteLine("That is not a valid intelligence.");
                            Console.WriteLine("Intelligence must be a number between 1 and 100.");
                        }
                    }
                    while (true);
                    break;

                    case "a":
                    do
                    {
                        Console.Write("Enter agility (1-100): ");
                        var agilityInput = Console.ReadLine();
                        if (Int32.TryParse(agilityInput, out var agility) && agility >= 1 && agility <= 100)
                        {
                            character.Agility = agility;
                            break;
                        } else
                        {
                            Console.WriteLine("That is not a valid agility.");
                            Console.WriteLine("Agility must be a number between 1 and 100.");
                        }
                    }
                    while (true);
                    break;

                    case "c":
                    do
                    {
                        Console.Write("Enter constitution (1-100): ");
                        var constitutionInput = Console.ReadLine();
                        if (Int32.TryParse(constitutionInput, out var constitution) && constitution >= 1 && constitution <= 100)
                        {
                            character.Constitution = constitution;
                            break;
                        } else
                        {
                            Console.WriteLine("That is not a valid constitution.");
                            Console.WriteLine("Constitution must be a number between 1 and 100.");
                        }
                    }
                    while (true);
                    break;

                    case "h":
                    do
                    {
                        Console.Write("Enter charisma (1-100): ");
                        var charismaInput = Console.ReadLine();
                        if (Int32.TryParse(charismaInput, out var charisma) && charisma >= 1 && charisma <= 100)
                        {
                            character.Charisma = charisma;
                            break;
                        } else
                        {
                            Console.WriteLine("That is not a valid charisma.");
                            Console.WriteLine("Charisma must be a number between 1 and 100.");
                        }
                    }
                    while (true);
                    break;

                    case "q":
                    return;

                    default:
                        Console.WriteLine("That is not an option.");
                        break;
                }
            }
            while (true);
        }
    
        /// <summary>
        /// Prompts to delete the current character.-
        /// </summary>
        private static void DeleteCharacter()
        {
            if (character == null)
            {
                Console.WriteLine("There is no character to delete.");
                return;
            }
            Console.Write("Are you sure you want to delete this character? (Y/N) ");
            var confirm = Console.ReadLine().ToLower();
            if (confirm == "y") character = null;
            else Console.WriteLine("Not deleting.");
        }
    }
}