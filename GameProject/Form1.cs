using GameUnits;

namespace GameProject
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();

        int strength;
        int dexterity;
        int survivability;
        int luck;

        int enemyStrength;
        int enemyDexterity;
        int enemySurvivability;
        int enemyLuck;

        public Form1(int strength, int dexterity, int survivability, int luck)
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 560;

            this.strength = strength;
            this.dexterity = dexterity;
            this.survivability = survivability;
            this.luck = luck;

            Strength.Text = strength.ToString();
            Dexterity.Text = dexterity.ToString();
            Survivability.Text = survivability.ToString();
            Luck.Text = luck.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        { 

        }

        private void Stats_Click(object sender, EventArgs e)
        {
            this.Height = (this.Height == 700) ? 560 : 700;
        }
        private void Menu_Click(object sender, EventArgs e)
        {
            this.Width = (this.Width == 900) ? 700 : 900;
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Fight_Click(object sender, EventArgs e)
        {
            enemyStrength = rnd.Next(1, 5);
            enemyDexterity = rnd.Next(1, 5);
            enemySurvivability = rnd.Next(1, 5);
            enemyLuck = rnd.Next(1, 5);

            Gameplay fight = new Gameplay(strength, dexterity, survivability, luck, enemyStrength, enemyDexterity, enemySurvivability, enemyLuck);
            fight.Show();
            Fight.Visible = false;
        }
    }
}
