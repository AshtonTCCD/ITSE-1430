/*
* Ashton Dorsett
* ITSE 1430
* Lab 3
*/


namespace AshtonDorsett.AdventureGame.WinHost
{
    public partial class AboutForm : Form
    {
        public AboutForm ()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Sets the text box to display the product name, company name, and version.
        /// </summary>
        private void OnLoad ( object sender, EventArgs e )
        {
            textBox.AppendText("Product: " + Application.ProductName);
            textBox.AppendText(Environment.NewLine);
            textBox.AppendText("Company: " + Application.CompanyName);
            textBox.AppendText(Environment.NewLine);
            textBox.AppendText("Version: " + Application.ProductVersion);
        }
    }
}
