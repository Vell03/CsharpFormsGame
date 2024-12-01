namespace GameProject
{
    partial class Form1
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
            Menu = new Button();
            button2 = new Button();
            Leave = new Button();
            Stats = new Button();
            ScoreLabel = new Label();
            textBox1 = new TextBox();
            Fight = new Button();
            StrengthText = new Label();
            DexterityText = new Label();
            SurvivabilityText = new Label();
            LuckText = new Label();
            Luck = new Label();
            Survivability = new Label();
            Dexterity = new Label();
            Strength = new Label();
            Exit = new Button();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.FlatAppearance.BorderColor = Color.Red;
            Menu.FlatAppearance.BorderSize = 2;
            Menu.FlatStyle = FlatStyle.Flat;
            Menu.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Menu.ForeColor = Color.DarkRed;
            Menu.Location = new Point(602, 12);
            Menu.Name = "Menu";
            Menu.Size = new Size(71, 28);
            Menu.TabIndex = 0;
            Menu.Text = "Меню";
            Menu.UseVisualStyleBackColor = true;
            Menu.Click += Menu_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(190, 51);
            button2.Name = "button2";
            button2.Size = new Size(310, 247);
            button2.TabIndex = 1;
            button2.Text = "MOB";
            button2.UseVisualStyleBackColor = true;
            // 
            // Leave
            // 
            Leave.BackColor = Color.IndianRed;
            Leave.FlatAppearance.BorderColor = Color.Brown;
            Leave.FlatAppearance.BorderSize = 2;
            Leave.FlatStyle = FlatStyle.Flat;
            Leave.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            Leave.ForeColor = Color.Transparent;
            Leave.Location = new Point(500, 462);
            Leave.Name = "Leave";
            Leave.Size = new Size(173, 51);
            Leave.TabIndex = 2;
            Leave.Text = "Сбежать";
            Leave.UseVisualStyleBackColor = false;
            // 
            // Stats
            // 
            Stats.BackColor = Color.Peru;
            Stats.FlatAppearance.BorderColor = Color.OrangeRed;
            Stats.FlatAppearance.BorderSize = 2;
            Stats.FlatStyle = FlatStyle.Flat;
            Stats.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            Stats.ForeColor = Color.Transparent;
            Stats.Location = new Point(12, 462);
            Stats.Name = "Stats";
            Stats.Size = new Size(173, 51);
            Stats.TabIndex = 3;
            Stats.Text = "Открыть инвентарь";
            Stats.UseVisualStyleBackColor = false;
            Stats.Click += Stats_Click;
            // 
            // ScoreLabel
            // 
            ScoreLabel.AutoSize = true;
            ScoreLabel.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            ScoreLabel.Location = new Point(330, 455);
            ScoreLabel.Name = "ScoreLabel";
            ScoreLabel.Size = new Size(49, 19);
            ScoreLabel.TabIndex = 4;
            ScoreLabel.Text = "Счет";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(247, 477);
            textBox1.MaxLength = 10;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(208, 23);
            textBox1.TabIndex = 5;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Fight
            // 
            Fight.BackColor = Color.DarkSeaGreen;
            Fight.FlatAppearance.BorderColor = Color.ForestGreen;
            Fight.FlatAppearance.BorderSize = 2;
            Fight.FlatStyle = FlatStyle.Flat;
            Fight.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            Fight.ForeColor = Color.Transparent;
            Fight.Location = new Point(256, 304);
            Fight.Name = "Fight";
            Fight.Size = new Size(173, 51);
            Fight.TabIndex = 6;
            Fight.Text = "Драться";
            Fight.UseVisualStyleBackColor = false;
            Fight.Click += Fight_Click;
            // 
            // StrengthText
            // 
            StrengthText.AutoSize = true;
            StrengthText.Location = new Point(27, 545);
            StrengthText.Name = "StrengthText";
            StrengthText.Size = new Size(35, 15);
            StrengthText.TabIndex = 7;
            StrengthText.Text = "Сила";
            // 
            // DexterityText
            // 
            DexterityText.AutoSize = true;
            DexterityText.Location = new Point(27, 570);
            DexterityText.Name = "DexterityText";
            DexterityText.Size = new Size(58, 15);
            DexterityText.TabIndex = 8;
            DexterityText.Text = "Ловкость";
            // 
            // SurvivabilityText
            // 
            SurvivabilityText.AutoSize = true;
            SurvivabilityText.Location = new Point(27, 597);
            SurvivabilityText.Name = "SurvivabilityText";
            SurvivabilityText.Size = new Size(90, 15);
            SurvivabilityText.TabIndex = 9;
            SurvivabilityText.Text = "Выживаемость";
            // 
            // LuckText
            // 
            LuckText.AutoSize = true;
            LuckText.Location = new Point(27, 621);
            LuckText.Name = "LuckText";
            LuckText.Size = new Size(39, 15);
            LuckText.TabIndex = 10;
            LuckText.Text = "Удача";
            // 
            // Luck
            // 
            Luck.AutoSize = true;
            Luck.Location = new Point(79, 621);
            Luck.Name = "Luck";
            Luck.Size = new Size(38, 15);
            Luck.TabIndex = 14;
            Luck.Text = "label4";
            // 
            // Survivability
            // 
            Survivability.AutoSize = true;
            Survivability.Location = new Point(123, 597);
            Survivability.Name = "Survivability";
            Survivability.Size = new Size(38, 15);
            Survivability.TabIndex = 13;
            Survivability.Text = "label3";
            // 
            // Dexterity
            // 
            Dexterity.AutoSize = true;
            Dexterity.Location = new Point(91, 570);
            Dexterity.Name = "Dexterity";
            Dexterity.Size = new Size(38, 15);
            Dexterity.TabIndex = 12;
            Dexterity.Text = "label2";
            // 
            // Strength
            // 
            Strength.AutoSize = true;
            Strength.Location = new Point(68, 545);
            Strength.Name = "Strength";
            Strength.Size = new Size(38, 15);
            Strength.TabIndex = 11;
            Strength.Text = "label1";
            // 
            // Exit
            // 
            Exit.BackColor = Color.IndianRed;
            Exit.FlatAppearance.BorderColor = Color.Brown;
            Exit.FlatAppearance.BorderSize = 2;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            Exit.ForeColor = Color.Transparent;
            Exit.Location = new Point(699, 74);
            Exit.Name = "Exit";
            Exit.Size = new Size(173, 51);
            Exit.TabIndex = 15;
            Exit.Text = "Выйти из игры";
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 662);
            Controls.Add(Exit);
            Controls.Add(Luck);
            Controls.Add(Survivability);
            Controls.Add(Dexterity);
            Controls.Add(Strength);
            Controls.Add(LuckText);
            Controls.Add(SurvivabilityText);
            Controls.Add(DexterityText);
            Controls.Add(StrengthText);
            Controls.Add(Fight);
            Controls.Add(textBox1);
            Controls.Add(ScoreLabel);
            Controls.Add(Stats);
            Controls.Add(Leave);
            Controls.Add(button2);
            Controls.Add(Menu);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Menu;
        private Button button2;
        private Button Leave;
        private Button Stats;
        private Label ScoreLabel;
        private TextBox textBox1;
        private Button Fight;
        private Label StrengthText;
        private Label DexterityText;
        private Label SurvivabilityText;
        private Label LuckText;
        private Label Luck;
        private Label Survivability;
        private Label Dexterity;
        private Label Strength;
        private Button Exit;
    }
}
