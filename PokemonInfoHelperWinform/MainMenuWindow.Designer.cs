
namespace PokemonInfoHelperWinform
{
    partial class MainMenuWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
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
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            InfoTrackerLabel = new Label();
            Generation2Button = new Button();
            Generation6Button = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.PokemonLogo;
            pictureBox1.Location = new Point(195, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(549, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // InfoTrackerLabel
            // 
            InfoTrackerLabel.AutoSize = true;
            InfoTrackerLabel.BackColor = Color.Transparent;
            InfoTrackerLabel.Font = new Font("Dubai Medium", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InfoTrackerLabel.Location = new Point(288, 188);
            InfoTrackerLabel.Name = "InfoTrackerLabel";
            InfoTrackerLabel.Size = new Size(382, 108);
            InfoTrackerLabel.TabIndex = 1;
            InfoTrackerLabel.Text = "Info Tracker";
            // 
            // Generation2Button
            // 
            Generation2Button.BackColor = Color.FromArgb(57, 95, 170);
            Generation2Button.FlatAppearance.BorderSize = 0;
            Generation2Button.FlatStyle = FlatStyle.Flat;
            Generation2Button.Font = new Font("Dubai Medium", 28F, FontStyle.Bold);
            Generation2Button.ForeColor = Color.FromArgb(255, 203, 5);
            Generation2Button.Location = new Point(82, 312);
            Generation2Button.Name = "Generation2Button";
            Generation2Button.Size = new Size(325, 102);
            Generation2Button.TabIndex = 2;
            Generation2Button.Text = "Generation 2-5";
            Generation2Button.UseVisualStyleBackColor = false;
            Generation2Button.Click += Generation2Button_Click;
            // 
            // Generation6Button
            // 
            Generation6Button.BackColor = Color.FromArgb(57, 95, 170);
            Generation6Button.FlatAppearance.BorderSize = 0;
            Generation6Button.FlatStyle = FlatStyle.Flat;
            Generation6Button.Font = new Font("Dubai Medium", 28F, FontStyle.Bold);
            Generation6Button.ForeColor = Color.FromArgb(255, 203, 5);
            Generation6Button.Location = new Point(531, 312);
            Generation6Button.Name = "Generation6Button";
            Generation6Button.Size = new Size(325, 102);
            Generation6Button.TabIndex = 3;
            Generation6Button.Text = "Generation 6+";
            Generation6Button.UseVisualStyleBackColor = false;
            Generation6Button.Click += Generation6Button_Click;
            // 
            // MainMenuWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackgroundImage = Properties.Resources.PokeBackground;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(934, 551);
            Controls.Add(Generation6Button);
            Controls.Add(Generation2Button);
            Controls.Add(InfoTrackerLabel);
            Controls.Add(pictureBox1);
            Name = "MainMenuWindow";
            Text = "MainMenu";
            Icon = Properties.Resources.PITIcon;
            FormClosed += MainMenuWindow_FormClosed;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label InfoTrackerLabel;
        private Button Generation2Button;
        private Button Generation6Button;
    }
}
