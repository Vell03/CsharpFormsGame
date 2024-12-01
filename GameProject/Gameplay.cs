using GameUnits;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameProject
{
    public partial class Gameplay : Form
    {
        int playerStength;
        int playerDexterity;
        int playerSurvivability;
        int playerLuck;

        int enemyStrength;
        int enemyDexterity;
        int enemySurvivability;
        int enemyLuck;

        int turn;

        public Gameplay(int playerStength, int playerDexterity, int playerSurvivability, int playerLuck, int enemyStrength, int enemyDexterity, int enemySurvivability, int enemyLuck)
        {
            InitializeComponent();
            this.playerStength = playerStength;
            this.playerDexterity = playerDexterity;
            this.playerSurvivability = playerSurvivability;
            this.playerLuck = playerLuck;
            this.enemyStrength = enemyStrength;
            this.enemyDexterity = enemyDexterity;
            this.enemySurvivability = enemySurvivability;
            this.enemyLuck = enemyLuck;

            Strength.Text = playerStength.ToString();
            Dexterity.Text = playerDexterity.ToString();
            Survivability.Text = playerSurvivability.ToString();
            Luck.Text = playerLuck.ToString();
            EnemyStrength.Text = enemyStrength.ToString();
            EnemyDexterity.Text= enemyDexterity.ToString();
            EnemySurvivability.Text = enemySurvivability.ToString();
            EnemyLuck.Text = enemyLuck.ToString();

            PlayerHealth.Text = Convert.ToString(playerSurvivability * 2);
            EnemyHealth.Text = Convert.ToString(enemySurvivability * 2);
        }

        private async void Gameplay_Load(object sender, EventArgs e)
        {

            Random rnd = new Random();
            Fight fight = new Fight(playerStength, playerDexterity, playerSurvivability, playerLuck, enemyStrength, enemyDexterity, enemySurvivability, enemyLuck, PlayerHealth, EnemyHealth);
            turn = rnd.Next(0, 2); // 0-Enemy 1-Player

            while (Convert.ToInt32(PlayerHealth.Text) > 0 || Convert.ToInt32(EnemyHealth.Text) > 0)
            {
                if (turn == 0)
                {
                    turn = 1;
                    TurnText.Text = "Enemy turn";

                    fight.EnemyAttack();
                    await Task.Delay(1000);
                }
                else if (turn == 1)
                {
                    turn = 0;
                    TurnText.Text = "Player turn";

                    fight.PlayerAttack();
                    await Task.Delay(1000);
                }
                if (Convert.ToInt32(PlayerHealth.Text) == 0 || Convert.ToInt32(EnemyHealth.Text) == 0)
                {
                    break;
                }
            }
        }
    }
}
