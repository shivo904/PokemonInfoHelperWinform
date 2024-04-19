using ImportHelper;
using Newtonsoft.Json.Linq;
using PokemonInfoHelperWinform.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonInfoHelperWinform
{
    public partial class TypeWeaknessWindow : Form
    {
        private string Generation;
        private Dictionary<string, SWChart> AttackingTypeChart;
        private Dictionary<string, SWChart> DefendingTypeChart;
        private Dictionary<string, Color> TypeColor;
        private List<Pokemon> allPokemon;
        private readonly string[] Types = new string[] { "normal", "fire", "water", "electric", "grass", "ice", "fighting", "poison", "ground", "flying", "psychic", "bug", "rock", "ghost", "dragon", "dark", "steel" };

        public TypeWeaknessWindow(string generation)
        {
            allPokemon = new List<Pokemon>();
            this.Generation = generation;
            AttackingTypeChart = GetAttackingSWChart(generation);
            DefendingTypeChart = GetDefendingSWChart(generation);
            TypeColor = GetTypeColors();
            var allPokemonData = Import.ImportCSVFromString(GetPokedex(generation), ",", false, false);
            foreach (var item in allPokemonData)
            {
                Pokemon pokemon = new Pokemon();
                pokemon.Name = item[1];
                pokemon.Type1 = item[2];
                pokemon.Type2 = item[3];
                pokemon.NationalID = item[0];
                allPokemon.Add(pokemon);
            }
            InitializeComponent();
        }

        private string GetPokedex(string generation)
        {
            if (generation == "gen6")
            {
                return Resources.PokedexGen6;
                //return "Resources\\PokedexGen6.csv";
            }
            return Resources.Pokedex;
            //return "Resources\\Pokedex.csv";
        }

        private Dictionary<string, SWChart> GetAttackingSWChart(string generation)
        {
            if(generation == "gen6")
            {
                return GetSWChart(Resources.AttackingPokemonTypesGen6);
                //return GetSWChartFromFile("Resources\\AttackingPokemonTypesGen6.json");
            }
            return GetSWChart(Resources.AttackingPokemonTypesGen6);
            //return GetSWChartFromFile("Resources\\AttackingPokemonTypesGen2.json");
        }

        private Dictionary<string, SWChart> GetDefendingSWChart(string generation)
        {
            if(generation == "gen6")
            {
                return GetSWChart(Resources.DefendingPokemonTypesGen6);
                //return GetSWChartFromFile("Resources\\DefendingPokemonTypesGen6.json");
            }
            return GetSWChart(Resources.DefendingPokemonTypesGen2);
            //return GetSWChartFromFile("Resources\\DefendingPokemonTypesGen2.json");
        }

        private Dictionary<string, Color> GetTypeColors()
        {
            Dictionary<string, Color> TypeColor = new Dictionary<string, Color>
            {
                {"-", Color.FromArgb(255, 168, 168, 120)},
                {"normal", Color.FromArgb(255, 168, 168, 120)},
                {"fire", Color.FromArgb(255, 240, 128, 48)},
                {"water", Color.FromArgb(255, 104, 144, 240)},
                {"electric", Color.FromArgb(255, 248, 208, 48)},
                {"grass", Color.FromArgb(255, 120, 200, 80)},
                {"ice", Color.FromArgb(255, 152, 216, 216)},
                {"fighting", Color.FromArgb(255, 192, 48, 40)},
                {"poison", Color.FromArgb(255, 160, 64, 160)},
                {"ground", Color.FromArgb(255, 224, 192, 104)},
                {"flying", Color.FromArgb(255, 168, 144, 240)},
                {"psychic", Color.FromArgb(255, 248, 88, 136)},
                {"bug", Color.FromArgb(255, 168, 184, 32)},
                {"rock", Color.FromArgb(255, 184, 160, 56)},
                {"ghost", Color.FromArgb(255, 112, 88, 152)},
                {"dragon", Color.FromArgb(255, 112, 56, 248)},
                {"dark", Color.FromArgb(255, 112, 88, 72)},
                {"steel", Color.FromArgb(255, 184, 184, 208)},
            };
            return TypeColor;
        }

        private Dictionary<string, SWChart> GetSWChartFromFile(string fileLocation)
        {
            Dictionary<string, SWChart> output = new Dictionary<string, SWChart>();
            JObject typeJSON = JObject.Parse(File.ReadAllText(fileLocation));
            foreach (var item in typeJSON)
            {
                SWChart swChart = new SWChart();
                JObject SWs = (JObject)item.Value;
                foreach (var sw in SWs)
                {
                    swChart.SW.Add(sw.Key, Convert.ToDouble(sw.Value.ToString()));
                }
                output.Add(item.Key, swChart);
                Console.WriteLine(item.Key);
            }
            return output;
        }

        private Dictionary<string,SWChart> GetSWChart(string fileLocation)
        {
            Dictionary<string, SWChart> output = new Dictionary<string, SWChart>();
            JObject typeJSON = JObject.Parse(fileLocation);
            foreach (var item in typeJSON)
            {
                SWChart swChart = new SWChart();
                JObject SWs = (JObject)item.Value;
                foreach (var sw in SWs)
                {
                    swChart.SW.Add(sw.Key, Convert.ToDouble(sw.Value.ToString()));
                }
                output.Add(item.Key, swChart);
                Console.WriteLine(item.Key);
            }
            return output;
        }

        private void Type1Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateWeakness();
        }

        private void TypeWeaknessWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PokemonSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string search = PokemonSearchTextBox.Text;
            PokemonSearchListBox.Items.Clear();
            if (search == "")
            {
                PokemonSearchListBox.Items.AddRange(allPokemon.Select(x => x.Name).ToArray());
            }
            else
            {
                PokemonSearchListBox.Items.AddRange(allPokemon.Where(x => x.Name.ToLower().Contains(search.ToLower())).Select(x => x.Name).ToArray());
            }
        }

        private void TypeWeaknessWindow_Load(object sender, EventArgs e)
        {
            PokemonSearchListBox.Items.AddRange(allPokemon.Select(x => x.Name).ToArray());
            Type1Combobox.SelectedIndex = 0;
            Type2Combobox.SelectedIndex = 0;
            MyPokemonRadioButton.Checked = true;
        }

        private void PokemonSearchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PokemonSearchListBox.SelectedIndex == -1)
            {
                return;
            }
            if (MyPokemonRadioButton.Checked)
            {
                OpponentPokemonRadioButton.Checked = true;
            }

            Pokemon pokemon = GetPokemonFromName(PokemonSearchListBox.SelectedItem.ToString());
            Type1Combobox.Text = "-NONE-";
            Type2Combobox.Text = "-NONE-";

            Type1Combobox.Text = pokemon.Type1;
            Type2Combobox.Text = pokemon.Type2;

        }

        private Pokemon GetPokemonFromName(string name)
        {
            var allPoke = allPokemon.Where(x => x.Name == name).ToList();
            if (allPoke.Count == 0)
            {
                return new Pokemon();
            }
            return allPoke[0];
        }

        private void CalculateWeakness()
        {
            if (Type1Combobox.Text == "" || Type2Combobox.Text == "")
            {
                return;
            }
            string type1 = Type1Combobox.Text.ToLower();
            string type2 = Type2Combobox.Text.ToLower();
            SWChart type1SW = AttackingTypeChart[type1];
            SWChart type2SW = AttackingTypeChart[type2];
            if (OpponentPokemonRadioButton.Checked)
            {
                type1SW = DefendingTypeChart[type1];
                type2SW = DefendingTypeChart[type2];
            }
            WeakX4List.Items.Clear();
            WeakX2List.Items.Clear();
            StrongX2List.Items.Clear();
            StrongX4List.Items.Clear();
            NoEffectList.Items.Clear();
            foreach (var typing in Types)
            {
                ListViewItem listItem = new ListViewItem();
                listItem.Text = typing.ToUpper();
                listItem.BackColor = TypeColor[typing];
                listItem.Font = new Font("Arial", 12, FontStyle.Regular);
                var multiplier = type1SW.SW[typing] * type2SW.SW[typing];
                if (multiplier == .25)
                {
                    WeakX4List.Items.Add(listItem);
                }
                else if (multiplier == .5)
                {
                    WeakX2List.Items.Add(listItem);
                }
                else if (multiplier == 2)
                {
                    StrongX2List.Items.Add(listItem);
                }
                else if (multiplier == 4)
                {
                    StrongX4List.Items.Add(listItem);
                }
                else if (multiplier == 0)
                {
                    NoEffectList.Items.Add(listItem);
                }
            }


        }

        private void MyPokemonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (MyPokemonRadioButton.Checked)
            {
                Type2Combobox.SelectedIndex = 0;
                Type2Combobox.Enabled = false;
                PokemonSearchListBox.SelectedIndex = -1;
            }
            else
            {
                Type2Combobox.Enabled = true;
            }
            CalculateWeakness();
        }

        private void OpponentPokemonRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CalculateWeakness();
        }

        private void Type2Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateWeakness();
        }

        private void StrongX4List_SelectedIndexChanged(object sender, EventArgs e)
        {
            StrongX4List.SelectedItems.Clear();
        }

        private void WeakX2List_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeakX2List.SelectedItems.Clear();
        }

        private void StrongX2List_SelectedIndexChanged(object sender, EventArgs e)
        {
            StrongX2List.SelectedItems.Clear();
        }

        private void WeakX4List_SelectedIndexChanged(object sender, EventArgs e)
        {
            WeakX4List.SelectedItems.Clear();
        }

        private void NoEffectList_SelectedIndexChanged(object sender, EventArgs e)
        {
            NoEffectList.SelectedItems.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenuWindow form = new MainMenuWindow();
            form.Show();
            this.Hide();
        }
    }
}
