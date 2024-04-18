namespace PokemonInfoHelperWinform
{
    partial class TypeWeaknessWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Type1Combobox = new ComboBox();
            pokemonTypeGroup = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            Type2Combobox = new ComboBox();
            groupBox1 = new GroupBox();
            PokemonSearchListBox = new ListBox();
            PokemonSearchTextBox = new TextBox();
            groupBox2 = new GroupBox();
            StrongX4List = new ListView();
            columnHeader5 = new ColumnHeader();
            StrongX2List = new ListView();
            columnHeader4 = new ColumnHeader();
            NoEffectList = new ListView();
            columnHeader3 = new ColumnHeader();
            WeakX4List = new ListView();
            columnHeader1 = new ColumnHeader();
            WeakX2List = new ListView();
            columnHeader2 = new ColumnHeader();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            MyPokemonRadioButton = new RadioButton();
            OpponentPokemonRadioButton = new RadioButton();
            groupBox3 = new GroupBox();
            backButton = new Button();
            pokemonTypeGroup.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Type1Combobox
            // 
            Type1Combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Type1Combobox.FormattingEnabled = true;
            Type1Combobox.Items.AddRange(new object[] { "-NONE-", "Normal", "Fire", "Water", "Electric", "Grass", "Ice", "Fighting", "Poison", "Ground", "Flying", "Psychic", "Bug", "Rock", "Ghost", "Dragon", "Dark", "Steel" });
            Type1Combobox.Location = new Point(22, 41);
            Type1Combobox.Name = "Type1Combobox";
            Type1Combobox.Size = new Size(157, 23);
            Type1Combobox.TabIndex = 0;
            Type1Combobox.SelectedIndexChanged += Type1Combobox_SelectedIndexChanged;
            // 
            // pokemonTypeGroup
            // 
            pokemonTypeGroup.Controls.Add(label2);
            pokemonTypeGroup.Controls.Add(label1);
            pokemonTypeGroup.Controls.Add(Type2Combobox);
            pokemonTypeGroup.Controls.Add(Type1Combobox);
            pokemonTypeGroup.Font = new Font("Arial", 9F, FontStyle.Bold);
            pokemonTypeGroup.Location = new Point(115, 12);
            pokemonTypeGroup.Name = "pokemonTypeGroup";
            pokemonTypeGroup.Size = new Size(481, 76);
            pokemonTypeGroup.TabIndex = 1;
            pokemonTypeGroup.TabStop = false;
            pokemonTypeGroup.Text = "Pokemon Types";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(231, 17);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Type 2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(22, 17);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "Type 1";
            // 
            // Type2Combobox
            // 
            Type2Combobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Type2Combobox.FormattingEnabled = true;
            Type2Combobox.Items.AddRange(new object[] { "-NONE-", "Normal", "Fire", "Water", "Electric", "Grass", "Ice", "Fighting", "Poison", "Ground", "Flying", "Psychic", "Bug", "Rock", "Ghost", "Dragon", "Dark", "Steel" });
            Type2Combobox.Location = new Point(231, 41);
            Type2Combobox.Name = "Type2Combobox";
            Type2Combobox.Size = new Size(157, 23);
            Type2Combobox.TabIndex = 1;
            Type2Combobox.SelectedIndexChanged += Type2Combobox_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PokemonSearchListBox);
            groupBox1.Controls.Add(PokemonSearchTextBox);
            groupBox1.Font = new Font("Arial", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(602, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(253, 426);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pokemon Lookup";
            // 
            // PokemonSearchListBox
            // 
            PokemonSearchListBox.FormattingEnabled = true;
            PokemonSearchListBox.ItemHeight = 15;
            PokemonSearchListBox.Location = new Point(6, 58);
            PokemonSearchListBox.Name = "PokemonSearchListBox";
            PokemonSearchListBox.Size = new Size(241, 349);
            PokemonSearchListBox.TabIndex = 1;
            PokemonSearchListBox.SelectedIndexChanged += PokemonSearchListBox_SelectedIndexChanged;
            // 
            // PokemonSearchTextBox
            // 
            PokemonSearchTextBox.Location = new Point(6, 24);
            PokemonSearchTextBox.Name = "PokemonSearchTextBox";
            PokemonSearchTextBox.Size = new Size(241, 21);
            PokemonSearchTextBox.TabIndex = 0;
            PokemonSearchTextBox.TextChanged += PokemonSearchTextBox_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(StrongX4List);
            groupBox2.Controls.Add(StrongX2List);
            groupBox2.Controls.Add(NoEffectList);
            groupBox2.Controls.Add(WeakX4List);
            groupBox2.Controls.Add(WeakX2List);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Arial", 9F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 150);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(584, 288);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Type Comparison";
            // 
            // StrongX4List
            // 
            StrongX4List.Columns.AddRange(new ColumnHeader[] { columnHeader5 });
            StrongX4List.HeaderStyle = ColumnHeaderStyle.None;
            StrongX4List.HideSelection = true;
            StrongX4List.Location = new Point(465, 51);
            StrongX4List.MultiSelect = false;
            StrongX4List.Name = "StrongX4List";
            StrongX4List.Scrollable = false;
            StrongX4List.Size = new Size(95, 231);
            StrongX4List.TabIndex = 20;
            StrongX4List.UseCompatibleStateImageBehavior = false;
            StrongX4List.View = View.Details;
            StrongX4List.SelectedIndexChanged += StrongX4List_SelectedIndexChanged;
            // 
            // columnHeader5
            // 
            columnHeader5.Width = 96;
            // 
            // StrongX2List
            // 
            StrongX2List.Columns.AddRange(new ColumnHeader[] { columnHeader4 });
            StrongX2List.HeaderStyle = ColumnHeaderStyle.None;
            StrongX2List.HideSelection = true;
            StrongX2List.Location = new Point(346, 51);
            StrongX2List.MultiSelect = false;
            StrongX2List.Name = "StrongX2List";
            StrongX2List.Scrollable = false;
            StrongX2List.Size = new Size(95, 231);
            StrongX2List.TabIndex = 19;
            StrongX2List.UseCompatibleStateImageBehavior = false;
            StrongX2List.View = View.Details;
            StrongX2List.SelectedIndexChanged += StrongX2List_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Width = 96;
            // 
            // NoEffectList
            // 
            NoEffectList.Columns.AddRange(new ColumnHeader[] { columnHeader3 });
            NoEffectList.HeaderStyle = ColumnHeaderStyle.None;
            NoEffectList.HideSelection = true;
            NoEffectList.Location = new Point(6, 51);
            NoEffectList.MultiSelect = false;
            NoEffectList.Name = "NoEffectList";
            NoEffectList.Scrollable = false;
            NoEffectList.Size = new Size(95, 231);
            NoEffectList.TabIndex = 18;
            NoEffectList.UseCompatibleStateImageBehavior = false;
            NoEffectList.View = View.Details;
            NoEffectList.SelectedIndexChanged += NoEffectList_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Width = 96;
            // 
            // WeakX4List
            // 
            WeakX4List.Columns.AddRange(new ColumnHeader[] { columnHeader1 });
            WeakX4List.HeaderStyle = ColumnHeaderStyle.None;
            WeakX4List.HideSelection = true;
            WeakX4List.Location = new Point(116, 51);
            WeakX4List.MultiSelect = false;
            WeakX4List.Name = "WeakX4List";
            WeakX4List.Scrollable = false;
            WeakX4List.Size = new Size(95, 231);
            WeakX4List.TabIndex = 17;
            WeakX4List.UseCompatibleStateImageBehavior = false;
            WeakX4List.View = View.Details;
            WeakX4List.SelectedIndexChanged += WeakX4List_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Width = 96;
            // 
            // WeakX2List
            // 
            WeakX2List.Columns.AddRange(new ColumnHeader[] { columnHeader2 });
            WeakX2List.HeaderStyle = ColumnHeaderStyle.None;
            WeakX2List.HideSelection = true;
            WeakX2List.Location = new Point(230, 51);
            WeakX2List.MultiSelect = false;
            WeakX2List.Name = "WeakX2List";
            WeakX2List.Scrollable = false;
            WeakX2List.Size = new Size(95, 231);
            WeakX2List.TabIndex = 16;
            WeakX2List.UseCompatibleStateImageBehavior = false;
            WeakX2List.View = View.Details;
            WeakX2List.SelectedIndexChanged += WeakX2List_SelectedIndexChanged;
            // 
            // columnHeader2
            // 
            columnHeader2.Width = 96;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 9F, FontStyle.Bold);
            label7.Location = new Point(465, 33);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 15;
            label7.Text = "Super Effective x2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 9F, FontStyle.Bold);
            label6.Location = new Point(346, 32);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 10;
            label6.Text = "Super Effective";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 9F, FontStyle.Bold);
            label5.Location = new Point(6, 33);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 8;
            label5.Text = "No Effect";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(230, 18);
            label4.Name = "label4";
            label4.Size = new Size(65, 30);
            label4.TabIndex = 6;
            label4.Text = "Not Very\r\nEffective...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9F, FontStyle.Bold);
            label3.Location = new Point(116, 18);
            label3.Name = "label3";
            label3.Size = new Size(79, 30);
            label3.TabIndex = 4;
            label3.Text = "Not very\r\nEffective...x2";
            // 
            // MyPokemonRadioButton
            // 
            MyPokemonRadioButton.AutoSize = true;
            MyPokemonRadioButton.Location = new Point(103, 22);
            MyPokemonRadioButton.Name = "MyPokemonRadioButton";
            MyPokemonRadioButton.Size = new Size(84, 19);
            MyPokemonRadioButton.TabIndex = 5;
            MyPokemonRadioButton.TabStop = true;
            MyPokemonRadioButton.Text = "Move Type";
            MyPokemonRadioButton.UseVisualStyleBackColor = true;
            MyPokemonRadioButton.CheckedChanged += MyPokemonRadioButton_CheckedChanged;
            // 
            // OpponentPokemonRadioButton
            // 
            OpponentPokemonRadioButton.AutoSize = true;
            OpponentPokemonRadioButton.Location = new Point(255, 22);
            OpponentPokemonRadioButton.Name = "OpponentPokemonRadioButton";
            OpponentPokemonRadioButton.Size = new Size(137, 19);
            OpponentPokemonRadioButton.TabIndex = 6;
            OpponentPokemonRadioButton.TabStop = true;
            OpponentPokemonRadioButton.Text = "Opponent Pokemon";
            OpponentPokemonRadioButton.UseVisualStyleBackColor = true;
            OpponentPokemonRadioButton.CheckedChanged += OpponentPokemonRadioButton_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(MyPokemonRadioButton);
            groupBox3.Controls.Add(OpponentPokemonRadioButton);
            groupBox3.Font = new Font("Arial", 9F, FontStyle.Bold);
            groupBox3.Location = new Point(12, 94);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(584, 50);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            // 
            // backButton
            // 
            backButton.Font = new Font("Arial", 9F, FontStyle.Bold);
            backButton.Location = new Point(12, 12);
            backButton.Name = "backButton";
            backButton.Size = new Size(97, 76);
            backButton.TabIndex = 8;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // TypeWeaknessWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 450);
            Controls.Add(backButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pokemonTypeGroup);
            Name = "TypeWeaknessWindow";
            Text = "TypeWeaknessWindow";
            Icon = Properties.Resources.PITIcon;
            FormClosed += TypeWeaknessWindow_FormClosed;
            Load += TypeWeaknessWindow_Load;
            pokemonTypeGroup.ResumeLayout(false);
            pokemonTypeGroup.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox Type1Combobox;
        private GroupBox pokemonTypeGroup;
        private ComboBox Type2Combobox;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private ListBox PokemonSearchListBox;
        private TextBox PokemonSearchTextBox;
        private GroupBox groupBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private RadioButton MyPokemonRadioButton;
        private RadioButton OpponentPokemonRadioButton;
        private GroupBox groupBox3;
        private ListView WeakX2List;
        private ColumnHeader columnHeader2;
        private ListView StrongX4List;
        private ColumnHeader columnHeader5;
        private ListView StrongX2List;
        private ColumnHeader columnHeader4;
        private ListView NoEffectList;
        private ColumnHeader columnHeader3;
        private ListView WeakX4List;
        private ColumnHeader columnHeader1;
        private Button backButton;
    }
}