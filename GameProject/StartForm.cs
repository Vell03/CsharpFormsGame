using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace GameProject
{
    public partial class StartForm : Form
    {
        int strength;
        int dexterity;
        int survivability;
        int luck;
        int freePoints;

        public List<int> ShowStats()
        {
            return new List<int> { strength, dexterity, survivability, luck };
        }

        public StartForm()
        {
            InitializeComponent();

            StrengthPlus.Click += new System.EventHandler(this.StrengthChange);
            StrengthMinus.Click += new System.EventHandler(this.StrengthChange);

            DexterityPlus.Click += new System.EventHandler(this.DexterityChange);
            DexterityMinus.Click += new System.EventHandler(this.DexterityChange);

            SurvivabilityPlus.Click += new System.EventHandler(this.SurvivabilityChange);
            SurvivabilityMinus.Click += new System.EventHandler(this.SurvivabilityChange);

            LuckPlus.Click += new System.EventHandler(this.LuckChange);
            LuckMinus.Click += new System.EventHandler(this.LuckChange);
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            strength = 0;
            dexterity = 0;
            survivability = 0;
            luck = 0;
            freePoints = 10;
        }
        private void NewGame_Click(object sender, EventArgs e)
        {
            StatsText.Visible = true;
            FreePointsText.Visible = true;
            FreePoints.Visible = true;

            StrengthText.Visible = true;
            Strength.Visible = true;
            StrengthPlus.Visible = true;
            StrengthMinus.Visible = true;

            DexterityText.Visible = true;
            Dexterity.Visible = true;
            DexterityPlus.Visible = true;
            DexterityMinus.Visible = true;

            SurvivabilityText.Visible = true;
            Survivability.Visible = true;
            SurvivabilityPlus.Visible = true;
            SurvivabilityMinus.Visible = true;

            LuckText.Visible = true;
            Luck.Visible = true;
            LuckPlus.Visible = true;
            LuckMinus.Visible = true;

            StartGame.Visible = true;

            this.Width = 780;
        }


        private void StrengthChange(object sender, EventArgs e)
        {
            Button ThisButton = sender as Button;
            if (ThisButton.Text == "+" && freePoints != 0)
            {
                Strength.Text = Convert.ToString(++strength);
                FreePoints.Text = Convert.ToString(--freePoints);
            }
            else if (ThisButton.Text == "-" && Convert.ToInt32(Strength.Text) != 0)
            {
                Strength.Text = Convert.ToString(--strength);
                FreePoints.Text = Convert.ToString(++freePoints);
            }
        }
        private void DexterityChange(object sender, EventArgs e)
        {
            Button ThisButton = sender as Button;
            if (ThisButton.Text == "+" && freePoints != 0)
            {
                Dexterity.Text = Convert.ToString(++dexterity);
                FreePoints.Text = Convert.ToString(--freePoints);
            }
            else if (ThisButton.Text == "-" && dexterity != 0)
            {
                Dexterity.Text = Convert.ToString(--dexterity);
                FreePoints.Text = Convert.ToString(++freePoints);
            }
        }
        private void SurvivabilityChange(object sender, EventArgs e)
        {
            Button ThisButton = sender as Button;
            if (ThisButton.Text == "+" && freePoints != 0)
            {
                Survivability.Text = Convert.ToString(++survivability);
                FreePoints.Text = Convert.ToString(--freePoints);
            }
            else if (ThisButton.Text == "-" && survivability != 0)
            {
                Survivability.Text = Convert.ToString(--survivability);
                FreePoints.Text = Convert.ToString(++freePoints);
            }
        }
        private void LuckChange(object sender, EventArgs e)
        {
            Button ThisButton = sender as Button;
            if (ThisButton.Text == "+" && freePoints != 0)
            {
                Luck.Text = Convert.ToString(++luck);
                FreePoints.Text = Convert.ToString(--freePoints);
            }
            else if (ThisButton.Text == "-" && luck != 0)
            {
                Luck.Text = Convert.ToString(--luck);
                FreePoints.Text = Convert.ToString(++freePoints);
            }
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            if (freePoints == 0)
            {
                Form1 Game = new Form1(strength, dexterity, survivability, luck);
                Game.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Потратьте все свободные очки",
                                "Ошибка",
                                MessageBoxButtons.OK);
            }
        }
    }
}
