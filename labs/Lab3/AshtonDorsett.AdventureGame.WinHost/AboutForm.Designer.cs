namespace AshtonDorsett.AdventureGame.WinHost
{
    partial class AboutForm
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
            textBox=new RichTextBox();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.BorderStyle=BorderStyle.None;
            textBox.Dock=DockStyle.Fill;
            textBox.Font=new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location=new Point(0, 0);
            textBox.Name="textBox";
            textBox.ReadOnly=true;
            textBox.Size=new Size(584, 361);
            textBox.TabIndex=0;
            textBox.Text="";
            // 
            // AboutForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(584, 361);
            Controls.Add(textBox);
            FormBorderStyle=FormBorderStyle.FixedSingle;
            MaximizeBox=false;
            MinimizeBox=false;
            Name="AboutForm";
            ShowIcon=false;
            StartPosition=FormStartPosition.CenterParent;
            Text="About";
            Load+=OnLoad;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox textBox;
    }
}