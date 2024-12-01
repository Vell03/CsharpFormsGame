namespace GameProject
{
    partial class StartForm
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
            NewGame = new Button();
            Continue = new Button();
            GameRules = new Button();
            GameName = new Label();
            StatsText = new Label();
            FreePointsText = new Label();
            FreePoints = new Label();
            StrengthText = new Label();
            DexterityText = new Label();
            SurvivabilityText = new Label();
            LuckText = new Label();
            Strength = new Label();
            Dexterity = new Label();
            Survivability = new Label();
            Luck = new Label();
            StartGame = new Button();
            StrengthPlus = new Button();
            StrengthMinus = new Button();
            DexterityMinus = new Button();
            DexterityPlus = new Button();
            SurvivabilityMinus = new Button();
            SurvivabilityPlus = new Button();
            LuckMinus = new Button();
            LuckPlus = new Button();
            SuspendLayout();
            // 
            // NewGame
            // 
            NewGame.FlatAppearance.BorderSize = 2;
            NewGame.FlatStyle = FlatStyle.Flat;
            NewGame.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            NewGame.Location = new Point(75, 176);
            NewGame.Name = "NewGame";
            NewGame.Size = new Size(172, 62);
            NewGame.TabIndex = 0;
            NewGame.Text = "Новая игра";
            NewGame.UseVisualStyleBackColor = true;
            NewGame.Click += NewGame_Click;
            // 
            // Continue
            // 
            Continue.FlatAppearance.BorderSize = 2;
            Continue.FlatStyle = FlatStyle.Flat;
            Continue.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            Continue.Location = new Point(75, 266);
            Continue.Name = "Continue";
            Continue.Size = new Size(172, 62);
            Continue.TabIndex = 1;
            Continue.Text = "Продолжить";
            Continue.UseVisualStyleBackColor = true;
            // 
            // GameRules
            // 
            GameRules.FlatAppearance.BorderSize = 2;
            GameRules.FlatStyle = FlatStyle.Flat;
            GameRules.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            GameRules.Location = new Point(75, 356);
            GameRules.Name = "GameRules";
            GameRules.Size = new Size(172, 62);
            GameRules.TabIndex = 2;
            GameRules.Text = "Правила игры";
            GameRules.UseVisualStyleBackColor = true;
            // 
            // GameName
            // 
            GameName.AutoSize = true;
            GameName.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            GameName.Location = new Point(59, 41);
            GameName.Name = "GameName";
            GameName.Size = new Size(203, 29);
            GameName.TabIndex = 3;
            GameName.Text = "Название игры";
            // 
            // StatsText
            // 
            StatsText.AutoSize = true;
            StatsText.Font = new Font("Tahoma", 18F, FontStyle.Bold);
            StatsText.Location = new Point(419, 41);
            StatsText.Name = "StatsText";
            StatsText.Size = new Size(299, 29);
            StatsText.TabIndex = 4;
            StatsText.Text = "Ваши характеристики:";
            StatsText.Visible = false;
            // 
            // FreePointsText
            // 
            FreePointsText.AutoSize = true;
            FreePointsText.Font = new Font("Tahoma", 14F, FontStyle.Bold);
            FreePointsText.Location = new Point(419, 148);
            FreePointsText.Name = "FreePointsText";
            FreePointsText.Size = new Size(279, 23);
            FreePointsText.TabIndex = 5;
            FreePointsText.Text = "Нераспределенных очков: ";
            FreePointsText.Visible = false;
            // 
            // FreePoints
            // 
            FreePoints.AutoSize = true;
            FreePoints.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            FreePoints.Location = new Point(704, 150);
            FreePoints.Name = "FreePoints";
            FreePoints.Size = new Size(21, 22);
            FreePoints.TabIndex = 6;
            FreePoints.Text = "0";
            FreePoints.Visible = false;
            // 
            // StrengthText
            // 
            StrengthText.AutoSize = true;
            StrengthText.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            StrengthText.Location = new Point(525, 211);
            StrengthText.Name = "StrengthText";
            StrengthText.Size = new Size(57, 22);
            StrengthText.TabIndex = 7;
            StrengthText.Text = "Сила";
            StrengthText.Visible = false;
            // 
            // DexterityText
            // 
            DexterityText.AutoSize = true;
            DexterityText.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            DexterityText.Location = new Point(526, 252);
            DexterityText.Name = "DexterityText";
            DexterityText.Size = new Size(97, 22);
            DexterityText.TabIndex = 8;
            DexterityText.Text = "Ловкость";
            DexterityText.Visible = false;
            // 
            // SurvivabilityText
            // 
            SurvivabilityText.AutoSize = true;
            SurvivabilityText.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            SurvivabilityText.Location = new Point(525, 291);
            SurvivabilityText.Name = "SurvivabilityText";
            SurvivabilityText.Size = new Size(152, 22);
            SurvivabilityText.TabIndex = 9;
            SurvivabilityText.Text = "Выживаемость";
            SurvivabilityText.Visible = false;
            // 
            // LuckText
            // 
            LuckText.AutoSize = true;
            LuckText.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            LuckText.Location = new Point(526, 331);
            LuckText.Name = "LuckText";
            LuckText.Size = new Size(67, 22);
            LuckText.TabIndex = 10;
            LuckText.Text = "Удача";
            LuckText.Visible = false;
            // 
            // Strength
            // 
            Strength.AutoSize = true;
            Strength.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            Strength.Location = new Point(588, 211);
            Strength.Name = "Strength";
            Strength.Size = new Size(21, 22);
            Strength.TabIndex = 11;
            Strength.Text = "0";
            Strength.Visible = false;
            // 
            // Dexterity
            // 
            Dexterity.AutoSize = true;
            Dexterity.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            Dexterity.Location = new Point(629, 252);
            Dexterity.Name = "Dexterity";
            Dexterity.Size = new Size(21, 22);
            Dexterity.TabIndex = 12;
            Dexterity.Text = "0";
            Dexterity.Visible = false;
            // 
            // Survivability
            // 
            Survivability.AutoSize = true;
            Survivability.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            Survivability.Location = new Point(683, 291);
            Survivability.Name = "Survivability";
            Survivability.Size = new Size(21, 22);
            Survivability.TabIndex = 13;
            Survivability.Text = "0";
            Survivability.Visible = false;
            // 
            // Luck
            // 
            Luck.AutoSize = true;
            Luck.Font = new Font("Tahoma", 13F, FontStyle.Bold);
            Luck.Location = new Point(599, 331);
            Luck.Name = "Luck";
            Luck.Size = new Size(21, 22);
            Luck.TabIndex = 14;
            Luck.Text = "0";
            Luck.Visible = false;
            // 
            // StartGame
            // 
            StartGame.FlatAppearance.BorderSize = 2;
            StartGame.FlatStyle = FlatStyle.Flat;
            StartGame.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            StartGame.Location = new Point(486, 397);
            StartGame.Name = "StartGame";
            StartGame.Size = new Size(172, 39);
            StartGame.TabIndex = 15;
            StartGame.Text = "Начать";
            StartGame.UseVisualStyleBackColor = true;
            StartGame.Visible = false;
            StartGame.Click += StartGame_Click;
            // 
            // StrengthPlus
            // 
            StrengthPlus.FlatAppearance.BorderSize = 2;
            StrengthPlus.FlatStyle = FlatStyle.Flat;
            StrengthPlus.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            StrengthPlus.Location = new Point(491, 208);
            StrengthPlus.Name = "StrengthPlus";
            StrengthPlus.Size = new Size(30, 30);
            StrengthPlus.TabIndex = 16;
            StrengthPlus.Text = "+";
            StrengthPlus.UseVisualStyleBackColor = true;
            StrengthPlus.Visible = false;
            // 
            // StrengthMinus
            // 
            StrengthMinus.FlatAppearance.BorderSize = 2;
            StrengthMinus.FlatStyle = FlatStyle.Flat;
            StrengthMinus.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            StrengthMinus.Location = new Point(455, 208);
            StrengthMinus.Name = "StrengthMinus";
            StrengthMinus.Size = new Size(30, 30);
            StrengthMinus.TabIndex = 17;
            StrengthMinus.Text = "-";
            StrengthMinus.UseVisualStyleBackColor = true;
            StrengthMinus.Visible = false;
            // 
            // DexterityMinus
            // 
            DexterityMinus.FlatAppearance.BorderSize = 2;
            DexterityMinus.FlatStyle = FlatStyle.Flat;
            DexterityMinus.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            DexterityMinus.Location = new Point(455, 249);
            DexterityMinus.Name = "DexterityMinus";
            DexterityMinus.Size = new Size(30, 30);
            DexterityMinus.TabIndex = 19;
            DexterityMinus.Text = "-";
            DexterityMinus.UseVisualStyleBackColor = true;
            DexterityMinus.Visible = false;
            // 
            // DexterityPlus
            // 
            DexterityPlus.FlatAppearance.BorderSize = 2;
            DexterityPlus.FlatStyle = FlatStyle.Flat;
            DexterityPlus.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            DexterityPlus.Location = new Point(491, 249);
            DexterityPlus.Name = "DexterityPlus";
            DexterityPlus.Size = new Size(30, 30);
            DexterityPlus.TabIndex = 18;
            DexterityPlus.Text = "+";
            DexterityPlus.UseVisualStyleBackColor = true;
            DexterityPlus.Visible = false;
            // 
            // SurvivabilityMinus
            // 
            SurvivabilityMinus.FlatAppearance.BorderSize = 2;
            SurvivabilityMinus.FlatStyle = FlatStyle.Flat;
            SurvivabilityMinus.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            SurvivabilityMinus.Location = new Point(455, 288);
            SurvivabilityMinus.Name = "SurvivabilityMinus";
            SurvivabilityMinus.Size = new Size(30, 30);
            SurvivabilityMinus.TabIndex = 21;
            SurvivabilityMinus.Text = "-";
            SurvivabilityMinus.UseVisualStyleBackColor = true;
            SurvivabilityMinus.Visible = false;
            // 
            // SurvivabilityPlus
            // 
            SurvivabilityPlus.FlatAppearance.BorderSize = 2;
            SurvivabilityPlus.FlatStyle = FlatStyle.Flat;
            SurvivabilityPlus.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            SurvivabilityPlus.Location = new Point(491, 288);
            SurvivabilityPlus.Name = "SurvivabilityPlus";
            SurvivabilityPlus.Size = new Size(30, 30);
            SurvivabilityPlus.TabIndex = 20;
            SurvivabilityPlus.Text = "+";
            SurvivabilityPlus.UseVisualStyleBackColor = true;
            SurvivabilityPlus.Visible = false;
            // 
            // LuckMinus
            // 
            LuckMinus.FlatAppearance.BorderSize = 2;
            LuckMinus.FlatStyle = FlatStyle.Flat;
            LuckMinus.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            LuckMinus.Location = new Point(455, 328);
            LuckMinus.Name = "LuckMinus";
            LuckMinus.Size = new Size(30, 30);
            LuckMinus.TabIndex = 23;
            LuckMinus.Text = "-";
            LuckMinus.UseVisualStyleBackColor = true;
            LuckMinus.Visible = false;
            // 
            // LuckPlus
            // 
            LuckPlus.FlatAppearance.BorderSize = 2;
            LuckPlus.FlatStyle = FlatStyle.Flat;
            LuckPlus.Font = new Font("Tahoma", 10F, FontStyle.Bold);
            LuckPlus.Location = new Point(491, 328);
            LuckPlus.Name = "LuckPlus";
            LuckPlus.Size = new Size(30, 30);
            LuckPlus.TabIndex = 22;
            LuckPlus.Text = "+";
            LuckPlus.UseVisualStyleBackColor = true;
            LuckPlus.Visible = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 459);
            Controls.Add(LuckMinus);
            Controls.Add(LuckPlus);
            Controls.Add(SurvivabilityMinus);
            Controls.Add(SurvivabilityPlus);
            Controls.Add(DexterityMinus);
            Controls.Add(DexterityPlus);
            Controls.Add(StrengthMinus);
            Controls.Add(StrengthPlus);
            Controls.Add(StartGame);
            Controls.Add(Luck);
            Controls.Add(Survivability);
            Controls.Add(Dexterity);
            Controls.Add(Strength);
            Controls.Add(LuckText);
            Controls.Add(SurvivabilityText);
            Controls.Add(DexterityText);
            Controls.Add(StrengthText);
            Controls.Add(FreePoints);
            Controls.Add(FreePointsText);
            Controls.Add(StatsText);
            Controls.Add(GameName);
            Controls.Add(GameRules);
            Controls.Add(Continue);
            Controls.Add(NewGame);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button NewGame;
        private Button Continue;
        private Button GameRules;
        private Label GameName;
        private Label StatsText;
        private Label FreePointsText;
        private Label FreePoints;
        private Label StrengthText;
        private Label DexterityText;
        private Label SurvivabilityText;
        private Label LuckText;
        private Label Strength;
        private Label Dexterity;
        private Label Survivability;
        private Label Luck;
        private Button StartGame;
        private Button StrengthPlus;
        private Button StrengthMinus;
        private Button DexterityMinus;
        private Button DexterityPlus;
        private Button SurvivabilityMinus;
        private Button SurvivabilityPlus;
        private Button LuckMinus;
        private Button LuckPlus;
    }
}