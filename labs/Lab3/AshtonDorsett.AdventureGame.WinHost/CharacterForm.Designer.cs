namespace AshtonDorsett.AdventureGame.WinHost
{
    partial class CharacterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose ( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            components=new System.ComponentModel.Container();
            nameLabel=new Label();
            nameBox=new TextBox();
            raceLabel=new Label();
            raceBox=new ComboBox();
            professionLabel=new Label();
            professionBox=new ComboBox();
            bioBox=new RichTextBox();
            bioLabel=new Label();
            strengthBox=new NumericUpDown();
            strengthLabel=new Label();
            intelLabel=new Label();
            intelBox=new NumericUpDown();
            agilityLabel=new Label();
            agilityBox=new NumericUpDown();
            constLabel=new Label();
            constBox=new NumericUpDown();
            charismaLabel=new Label();
            charismaBox=new NumericUpDown();
            saveButton=new Button();
            cancelButton=new Button();
            errorProvider=new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)strengthBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)intelBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)agilityBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)constBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)charismaBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize=true;
            nameLabel.Font=new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location=new Point(116, 20);
            nameLabel.Name="nameLabel";
            nameLabel.Size=new Size(64, 28);
            nameLabel.TabIndex=0;
            nameLabel.Text="Name";
            // 
            // nameBox
            // 
            nameBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location=new Point(186, 17);
            nameBox.Name="nameBox";
            nameBox.Size=new Size(250, 36);
            nameBox.TabIndex=1;
            nameBox.Validating+=nameBox_Validating;
            // 
            // raceLabel
            // 
            raceLabel.AutoSize=true;
            raceLabel.Font=new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            raceLabel.Location=new Point(116, 73);
            raceLabel.Name="raceLabel";
            raceLabel.Size=new Size(64, 28);
            raceLabel.TabIndex=2;
            raceLabel.Text="Race";
            // 
            // raceBox
            // 
            raceBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            raceBox.FormattingEnabled=true;
            raceBox.Items.AddRange(new object[] { "Dwarf", "Elf", "Gnome", "HalfElf", "Human" });
            raceBox.Location=new Point(186, 70);
            raceBox.Name="raceBox";
            raceBox.Size=new Size(250, 36);
            raceBox.TabIndex=3;
            raceBox.Validating+=raceBox_Validating;
            // 
            // professionLabel
            // 
            professionLabel.AutoSize=true;
            professionLabel.Font=new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            professionLabel.Location=new Point(38, 126);
            professionLabel.Name="professionLabel";
            professionLabel.Size=new Size(142, 28);
            professionLabel.TabIndex=4;
            professionLabel.Text="Profession";
            // 
            // professionBox
            // 
            professionBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            professionBox.FormattingEnabled=true;
            professionBox.Items.AddRange(new object[] { "Fighter", "Hunter", "Priest", "Rogue", "Wizard" });
            professionBox.Location=new Point(186, 123);
            professionBox.Name="professionBox";
            professionBox.Size=new Size(250, 36);
            professionBox.TabIndex=5;
            professionBox.Validating+=professionBox_Validating;
            // 
            // bioBox
            // 
            bioBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            bioBox.Location=new Point(186, 176);
            bioBox.Name="bioBox";
            bioBox.Size=new Size(250, 150);
            bioBox.TabIndex=6;
            bioBox.Text="";
            // 
            // bioLabel
            // 
            bioLabel.AutoSize=true;
            bioLabel.Font=new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bioLabel.Location=new Point(51, 179);
            bioLabel.Name="bioLabel";
            bioLabel.Size=new Size(129, 28);
            bioLabel.TabIndex=7;
            bioLabel.Text="Biography";
            // 
            // strengthBox
            // 
            strengthBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            strengthBox.Location=new Point(186, 347);
            strengthBox.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
            strengthBox.Name="strengthBox";
            strengthBox.Size=new Size(250, 36);
            strengthBox.TabIndex=8;
            strengthBox.Value=new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // strengthLabel
            // 
            strengthLabel.AutoSize=true;
            strengthLabel.Font=new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            strengthLabel.Location=new Point(64, 349);
            strengthLabel.Name="strengthLabel";
            strengthLabel.Size=new Size(116, 28);
            strengthLabel.TabIndex=9;
            strengthLabel.Text="Strength";
            // 
            // intelLabel
            // 
            intelLabel.AutoSize=true;
            intelLabel.Font=new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            intelLabel.Location=new Point(12, 402);
            intelLabel.Name="intelLabel";
            intelLabel.Size=new Size(168, 28);
            intelLabel.TabIndex=11;
            intelLabel.Text="Intelligence";
            // 
            // intelBox
            // 
            intelBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            intelBox.Location=new Point(186, 400);
            intelBox.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
            intelBox.Name="intelBox";
            intelBox.Size=new Size(250, 36);
            intelBox.TabIndex=10;
            intelBox.Value=new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // agilityLabel
            // 
            agilityLabel.AutoSize=true;
            agilityLabel.Font=new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            agilityLabel.Location=new Point(77, 455);
            agilityLabel.Name="agilityLabel";
            agilityLabel.Size=new Size(103, 28);
            agilityLabel.TabIndex=13;
            agilityLabel.Text="Agility";
            // 
            // agilityBox
            // 
            agilityBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            agilityBox.Location=new Point(186, 453);
            agilityBox.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
            agilityBox.Name="agilityBox";
            agilityBox.Size=new Size(250, 36);
            agilityBox.TabIndex=12;
            agilityBox.Value=new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // constLabel
            // 
            constLabel.AutoSize=true;
            constLabel.Font=new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            constLabel.Location=new Point(12, 508);
            constLabel.Name="constLabel";
            constLabel.Size=new Size(168, 28);
            constLabel.TabIndex=15;
            constLabel.Text="Constitution";
            // 
            // constBox
            // 
            constBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            constBox.Location=new Point(186, 506);
            constBox.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
            constBox.Name="constBox";
            constBox.Size=new Size(250, 36);
            constBox.TabIndex=14;
            constBox.Value=new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // charismaLabel
            // 
            charismaLabel.AutoSize=true;
            charismaLabel.Font=new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point);
            charismaLabel.Location=new Point(64, 561);
            charismaLabel.Name="charismaLabel";
            charismaLabel.Size=new Size(116, 28);
            charismaLabel.TabIndex=17;
            charismaLabel.Text="Charisma";
            // 
            // charismaBox
            // 
            charismaBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            charismaBox.Location=new Point(186, 559);
            charismaBox.Minimum=new decimal(new int[] { 1, 0, 0, 0 });
            charismaBox.Name="charismaBox";
            charismaBox.Size=new Size(250, 36);
            charismaBox.TabIndex=16;
            charismaBox.Value=new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // saveButton
            // 
            saveButton.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            saveButton.Location=new Point(77, 613);
            saveButton.Name="saveButton";
            saveButton.Size=new Size(120, 40);
            saveButton.TabIndex=18;
            saveButton.Text="Save";
            saveButton.UseVisualStyleBackColor=true;
            saveButton.Click+=SaveCharacter;
            // 
            // cancelButton
            // 
            cancelButton.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            cancelButton.Location=new Point(251, 613);
            cancelButton.Name="cancelButton";
            cancelButton.Size=new Size(120, 40);
            cancelButton.TabIndex=19;
            cancelButton.Text="Cancel";
            cancelButton.UseVisualStyleBackColor=true;
            cancelButton.Click+=Cancel;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl=this;
            // 
            // CharacterForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(454, 665);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(charismaLabel);
            Controls.Add(charismaBox);
            Controls.Add(constLabel);
            Controls.Add(constBox);
            Controls.Add(agilityLabel);
            Controls.Add(agilityBox);
            Controls.Add(intelLabel);
            Controls.Add(intelBox);
            Controls.Add(strengthLabel);
            Controls.Add(strengthBox);
            Controls.Add(bioLabel);
            Controls.Add(bioBox);
            Controls.Add(professionBox);
            Controls.Add(professionLabel);
            Controls.Add(raceBox);
            Controls.Add(raceLabel);
            Controls.Add(nameBox);
            Controls.Add(nameLabel);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="CharacterForm";
            ShowIcon=false;
            StartPosition=FormStartPosition.CenterParent;
            Text="Create New Character";
            Load+=OnLoad;
            ((System.ComponentModel.ISupportInitialize)strengthBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)intelBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)agilityBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)constBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)charismaBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private TextBox nameBox;
        private Label raceLabel;
        private ComboBox raceBox;
        private Label professionLabel;
        private ComboBox professionBox;
        private RichTextBox bioBox;
        private Label bioLabel;
        private NumericUpDown strengthBox;
        private Label strengthLabel;
        private Label intelLabel;
        private NumericUpDown intelBox;
        private Label agilityLabel;
        private NumericUpDown agilityBox;
        private Label constLabel;
        private NumericUpDown constBox;
        private Label charismaLabel;
        private NumericUpDown charismaBox;
        private Button saveButton;
        private Button cancelButton;
        private ErrorProvider errorProvider;
    }
}