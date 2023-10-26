/*
* Ashton Dorsett
* ITSE 1430
* Lab 3
*/

namespace AshtonDorsett.AdventureGame.WinHost
{
    public partial class MainForm : Form
    {
        private readonly List<Character> characters = new();

        /// <summary>
        /// Initializes the form.
        /// </summary>
        public MainForm () => InitializeComponent();

        /// <summary>
        /// Adds a character and refreshes the list.
        /// </summary>
        /// <param name="character">The character to add.</param>
        public void AddCharacter ( Character character )
        {
            characters.Add(character);
            RefreshList();
        }

        /// <summary>
        /// Updates a character and refreshes the list.
        /// </summary>
        /// <param name="character">The new character.</param>
        /// <param name="oldCharacter">The character to update.</param>
        public void UpdateCharacter ( Character character, Character oldCharacter )
        {
            characters.Remove(oldCharacter);
            characters.Add(character);
            RefreshList();
        }

        /// <summary>
        /// Refreshes the ListBox's data source.
        /// </summary>
        private void RefreshList ()
        {
            characterList.DataSource = null;
            characterList.DataSource = characters;
        }

        /// <summary>
        /// Gets the selected character.
        /// </summary>
        /// <returns>The selected character.</returns>
        public Character GetSelectedCharacter () => characterList.SelectedItem as Character;

        /// <summary>
        /// Confirms an exit.
        /// </summary>
        private void Exit ( object sender, EventArgs e )
        {
            var confirm = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                Close();
        }

        /// <summary>
        /// Shows the about form.
        /// </summary>
        private void About ( object sender, EventArgs e )
        {
            var about = new AboutForm();
            about.ShowDialog();

            about.Dispose();
        }

        /// <summary>
        /// Shows the character creation form.
        /// </summary>
        private void NewCharacter ( object sender, EventArgs e )
        {
            var characterForm = new CharacterForm();
            characterForm.ShowDialog(this);

            characterForm.Dispose();
        }

        /// <summary>
        /// Shows the character creation form with the selected character.
        /// </summary>
        private void EditCharacter ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null) return;

            var characterForm = new CharacterForm(character);
            characterForm.ShowDialog(this);

            characterForm.Dispose();
        }

        /// <summary>
        /// Confirms a character deletion.
        /// </summary>
        private void DeleteCharacter ( object sender, EventArgs e )
        {
            var character = GetSelectedCharacter();
            if (character == null) return;

            var confirm = MessageBox.Show($"Are you sure you want to delete {character.Name}?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            characters.Remove(character);
            RefreshList();
        }
    }
}