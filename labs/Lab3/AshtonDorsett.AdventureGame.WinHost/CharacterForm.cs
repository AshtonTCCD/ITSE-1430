/*
* Ashton Dorsett
* ITSE 1430
* Lab 3
*/

using System.ComponentModel;

namespace AshtonDorsett.AdventureGame.WinHost
{
    public partial class CharacterForm : Form
    {
        private Character character;

        /// <summary>
        /// Initializes the form.
        /// </summary>
        public CharacterForm ()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Initializes the form with a character to pre-load.
        /// </summary>
        /// <param name="character">The character to pre-load.</param>
        public CharacterForm ( Character character )
        {
            InitializeComponent();
            this.character = character;
            Text = "Edit Character";
        }

        /// <summary>
        /// Closes the form on cancel.
        /// </summary>
        private void Cancel ( object sender, EventArgs e ) => Close();

        /// <summary>
        /// Validates and saves the character.
        /// </summary>
        private void SaveCharacter ( object sender, EventArgs e )
        {
            var name = nameBox.Text;
            var biography = bioBox.Text;
            var strength = (int)strengthBox.Value;
            var intelligence = (int)intelBox.Value;
            var agility = (int)agilityBox.Value;
            var constitution = (int)constBox.Value;
            var charisma = (int)charismaBox.Value;

            if (!Enum.TryParse<Race>(raceBox.Text, out var race))
            {
                Error("Race is not valid.");
                return;
            }

            if (!Enum.TryParse<Profession>(professionBox.Text, out var profession))
            {
                Error("Profession is not valid.");
                return;
            }

            var character = new Character(name, profession, race, biography, strength, intelligence, agility, constitution, charisma);
            var error = character.Validate();

            if (!String.IsNullOrEmpty(error))
            {
                Error(error);
                return;
            }

            var mainForm = Owner as MainForm;

            if (this.character != null)
                mainForm.UpdateCharacter(character, this.character);
            else
                mainForm.AddCharacter(character);

            Close();
        }

        /// <summary>
        /// Shows a message box with an error.
        /// </summary>
        /// <param name="message">The error to display.</param>
        private static void Error ( string message ) => MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        /// <summary>
        /// Checks if a character was provided and loads it.
        /// </summary>
        private void OnLoad ( object sender, EventArgs e )
        {
            if (character == null) return;
            nameBox.Text = character.Name;
            raceBox.Text = character.Race.ToString();
            professionBox.Text = character.Profession.ToString();
            bioBox.Text = character.Biography;
            strengthBox.Value = character.Strength;
            intelBox.Value = character.Intelligence;
            agilityBox.Value = character.Agility;
            constBox.Value = character.Constitution;
            charismaBox.Value = character.Charisma;
        }

        /// <summary>
        /// Validates the name.
        /// </summary>
        private void nameBox_Validating ( object sender, CancelEventArgs e )
        {
            errorProvider.SetError(nameBox, nameBox.Text.Length == 0 ? "Name is required." : String.Empty);
        }

        /// <summary>
        /// Validates the race.
        /// </summary>
        private void raceBox_Validating ( object sender, CancelEventArgs e )
        {
            errorProvider.SetError(raceBox,
                Enum.TryParse<Race>(raceBox.Text, out var _) ? String.Empty : "Race is not valid.");
        }

        /// <summary>
        /// Validates the profession.
        /// </summary>
        private void professionBox_Validating ( object sender, CancelEventArgs e )
        {
            errorProvider.SetError(professionBox,
                Enum.TryParse<Profession>(professionBox.Text, out var _) ? String.Empty : "Profession is not valid.");
        }

        // The number box controls are set to only accept whole numbers 1-100,
        // so there is no need to validate them separately.
    }
}
