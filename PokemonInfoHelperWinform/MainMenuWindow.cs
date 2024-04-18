using PokemonInfoHelperWinform.Properties;

namespace PokemonInfoHelperWinform
{
    public partial class MainMenuWindow : Form
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void Generation2Button_Click(object sender, EventArgs e)
        {
            TypeWeaknessWindow form = new TypeWeaknessWindow("gen2");
            form.Show();
            this.Hide();
        }
        private void Generation6Button_Click(object sender, EventArgs e)
        {
            TypeWeaknessWindow form = new TypeWeaknessWindow("gen6");
            form.Show();
            this.Hide();
        }
        private void MainMenuWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}
