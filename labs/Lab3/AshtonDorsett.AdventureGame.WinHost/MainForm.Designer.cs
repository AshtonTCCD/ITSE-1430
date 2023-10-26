namespace AshtonDorsett.AdventureGame.WinHost
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            menuStrip=new MenuStrip();
            fileToolStripMenuItem=new ToolStripMenuItem();
            exitToolStripMenuItem=new ToolStripMenuItem();
            helpToolStripMenuItem=new ToolStripMenuItem();
            aboutToolStripMenuItem=new ToolStripMenuItem();
            characterToolStripMenuItem=new ToolStripMenuItem();
            newToolStripMenuItem=new ToolStripMenuItem();
            editToolStripMenuItem=new ToolStripMenuItem();
            deleteToolStripMenuItem=new ToolStripMenuItem();
            characterList=new ListBox();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem, characterToolStripMenuItem });
            menuStrip.Location=new Point(0, 0);
            menuStrip.Name="menuStrip";
            menuStrip.Size=new Size(784, 24);
            menuStrip.TabIndex=0;
            menuStrip.Text="menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name="fileToolStripMenuItem";
            fileToolStripMenuItem.Size=new Size(37, 20);
            fileToolStripMenuItem.Text="File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name="exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.X;
            exitToolStripMenuItem.Size=new Size(134, 22);
            exitToolStripMenuItem.Text="Exit";
            exitToolStripMenuItem.Click+=Exit;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name="helpToolStripMenuItem";
            helpToolStripMenuItem.Size=new Size(44, 20);
            helpToolStripMenuItem.Text="Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name="aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys=Keys.F1;
            aboutToolStripMenuItem.Size=new Size(126, 22);
            aboutToolStripMenuItem.Text="About";
            aboutToolStripMenuItem.Click+=About;
            // 
            // characterToolStripMenuItem
            // 
            characterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, editToolStripMenuItem, deleteToolStripMenuItem });
            characterToolStripMenuItem.Name="characterToolStripMenuItem";
            characterToolStripMenuItem.Size=new Size(70, 20);
            characterToolStripMenuItem.Text="Character";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name="newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.N;
            newToolStripMenuItem.Size=new Size(141, 22);
            newToolStripMenuItem.Text="New";
            newToolStripMenuItem.Click+=NewCharacter;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Name="editToolStripMenuItem";
            editToolStripMenuItem.ShortcutKeys=Keys.Control|Keys.O;
            editToolStripMenuItem.Size=new Size(141, 22);
            editToolStripMenuItem.Text="Edit";
            editToolStripMenuItem.Click+=EditCharacter;
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name="deleteToolStripMenuItem";
            deleteToolStripMenuItem.ShortcutKeys=Keys.Delete;
            deleteToolStripMenuItem.Size=new Size(141, 22);
            deleteToolStripMenuItem.Text="Delete";
            deleteToolStripMenuItem.Click+=DeleteCharacter;
            // 
            // characterList
            // 
            characterList.Dock=DockStyle.Fill;
            characterList.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            characterList.FormattingEnabled=true;
            characterList.ItemHeight=28;
            characterList.Location=new Point(0, 24);
            characterList.Name="characterList";
            characterList.Size=new Size(784, 537);
            characterList.TabIndex=1;
            // 
            // MainForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(784, 561);
            Controls.Add(characterList);
            Controls.Add(menuStrip);
            MainMenuStrip=menuStrip;
            MinimumSize=new Size(300, 200);
            Name="MainForm";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Ashton Dorsett Adventure Game";
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ListBox characterList;
        private ToolStripMenuItem characterToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
    }
}