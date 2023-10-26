/*
* Ashton Dorsett
* ITSE 1430
* Lab 3
*/

namespace AshtonDorsett.AdventureGame
{
    /// <summary>
    /// Represents a character.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Gets or sets the character's name.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Gets or sets the character's profession.
        /// </summary>
        public Profession Profession { get; set; } = Profession.None;

        /// <summary>
        /// Gets or sets the character's race.
        /// </summary>
        public Race Race { get; set; } = Race.None;

        /// <summary>
        /// Gets or sets the character's biography.
        /// </summary>
        public string Biography { get; set; } = "";

        /// <summary>
        /// Gets or sets the character's strength.
        /// </summary>
        public int Strength
        {
            get => _strength;
            set { if (value is >= 1 and <= 100) _strength = value; }
        }

        /// <summary>
        /// Gets or sets the character's intelligence.
        /// </summary>
        public int Intelligence
        {
            get => _intelligence;
            set { if (value is >= 1 and <= 100) _intelligence = value; }
        }

        /// <summary>
        /// Gets or sets the character's agility.
        /// </summary>
        public int Agility
        {
            get => _agility;
            set { if (value is >= 1 and <= 100) _agility = value; }
        }

        /// <summary>
        /// Gets or sets the character's constitution.
        /// </summary>
        public int Constitution
        {
            get => _constitution;
            set { if (value is >= 1 and <= 100) _constitution = value; }
        }

        /// <summary>
        /// Gets or sets the character's charisma.
        /// </summary>
        public int Charisma
        {
            get => _charisma;
            set { if (value is >= 1 and <= 100) _charisma = value; }
        }

        // Private backing fields. Defaults to 1 since 0 is not allowed. c:
        private int _strength = 1;
        private int _intelligence = 1;
        private int _agility = 1;
        private int _constitution = 1;
        private int _charisma = 1;

        /// <summary>
        /// Creates a new character.
        /// </summary>
        public Character() { }

        /// <summary>
        /// Creates a new character.
        /// </summary>
        /// <param name="name">Name of the character.</param>
        /// <param name="profession">Profession of the character.</param>
        /// <param name="race">Race of the character.</param>
        /// <param name="bio">Biography of the character.</param>
        public Character(string name, Profession profession, Race race, string bio)
        {
            Name = name;
            Profession = profession;
            Race = race;
            Biography = bio;
        }

        /// <summary>
        /// Creates a new character.
        /// </summary>
        /// <param name="name">Name of the character.</param>
        /// <param name="profession">Profession of the character.</param>
        /// <param name="race">Race of the character.</param>
        /// <param name="bio">Biography of the character.</param>
        /// <param name="strength">Strength of the character.</param>
        /// <param name="intelligence">Intelligence of the character.</param>
        /// <param name="agility">Agility of the character.</param>
        /// <param name="constitution">Constitution of the character.</param>
        /// <param name="charisma">Charisma of the character.</param>
        public Character(string name, Profession profession, Race race, string bio, int strength, int intelligence, int agility, int constitution, int charisma)
        {
            Name = name;
            Profession = profession;
            Race = race;
            Biography = bio;
            Strength = strength;
            Intelligence = intelligence;
            Agility = agility;
            Constitution = constitution;
            Charisma = charisma;
        }

        /// <summary>
        /// Ensures the character is valid.
        /// </summary>
        public string Validate()
        {
            if (String.IsNullOrEmpty(Name.Trim()))
                return "Name is required.";

            if (Race == Race.None)
                return "Race is required.";

            if (Profession == Profession.None)
                return "Profession is required.";

            return "";
        }

        /// <summary>
        /// Prints the character's name, profession, and race.
        /// </summary>
        public override string ToString() => $"{Name}, {Profession}, {Race}";
    }

    /// <summary>
    /// Represents a character's profession.
    /// </summary>
    public enum Profession
    {
        None,
        Fighter,
        Hunter,
        Priest,
        Rogue,
        Wizard
    }

    /// <summary>
    /// Represents a character's race.
    /// </summary>
    public enum Race
    {
        None,
        Dwarf,
        Elf,
        Gnome,
        HalfElf,
        Human
    }
}
