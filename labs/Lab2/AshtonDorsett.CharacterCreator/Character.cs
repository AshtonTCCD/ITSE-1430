/*
* Ashton Dorsett
* ITSE 1430
* Lab 2
*/

namespace AshtonDorsett.CharacterCreator
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
            set { if (value >= 1 && value <= 100) _strength = value; }
        }

        /// <summary>
        /// Gets or sets the character's intelligence.
        /// </summary>
        public int Intelligence
        {
            get => _intelligence;
            set { if (value >= 1 && value <= 100) _intelligence = value; }
        }

        /// <summary>
        /// Gets or sets the character's agility.
        /// </summary>
        public int Agility
        {
            get => _agility;
            set { if (value >= 1 && value <= 100) _agility = value; }
        }

        /// <summary>
        /// Gets or sets the character's constitution.
        /// </summary>
        public int Constitution
        {
            get => _constitution;
            set { if (value >= 1 && value <= 100) _constitution = value; }
        }

        /// <summary>
        /// Gets or sets the character's charisma.
        /// </summary>
        public int Charisma
        {
            get => _charisma;
            set { if (value >= 1 && value <= 100) _charisma = value; }
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
        public Character (string name, Profession profession, Race race, string bio)
        {
            Name = name;
            Profession = profession;
            Race = race;
            Biography = bio;
        }
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
