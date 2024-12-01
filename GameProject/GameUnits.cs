using System;
using System.DirectoryServices;
using System.Windows.Forms;
using GameProject;
namespace GameUnits
{
    

    public class Player
    {
        int strength;
        int dexterity;
        int survivability;
        int luck;
        List<string> items;

        public Player(int strength, int dexterity, int survivability, int luck)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.survivability = survivability;
            this.luck = luck;
        }


    }

    public class Enemy
    {
        int strength;
        int dexterity;
        int survivability;
        int luck;

        public Enemy(int strength, int dexterity, int survivability, int luck)
        {
            this.strength = strength;
            this.dexterity = dexterity;
            this.survivability = survivability;
            this.luck = luck;
        }
    }


    public class Fight
    {
        Random random = new Random();

        int playerStrength;
        int playerDexterity;
        int playerSurvivability;
        int playerLuck;

        int enemyStrength;
        int enemyDexterity;
        int enemySurvivability;
        int enemyLuck;

        int playerHealth;
        int enemyHealth;
        Label playerHealthLabel;
        Label enemyHealthLabel;

        public Fight(int playerStrength, int playerDexterity, int playerSurvivability, int playerLuck, int enemyStrength, int enemyDexterity, int enemySurvivability, int enemyLuck, Label playerHealthLabel, Label enemyHealthLabel)
        {
            this.playerStrength = playerStrength;
            this.playerDexterity = playerDexterity;
            this.playerSurvivability = playerSurvivability;
            this.playerLuck = playerLuck;
            this.enemyStrength = enemyStrength;
            this.enemyDexterity = enemyDexterity;
            this.enemySurvivability = enemySurvivability;
            this.enemyLuck = enemyLuck;

            playerHealth = playerSurvivability * 2;
            enemyHealth = enemySurvivability * 2;
            this.playerHealthLabel = playerHealthLabel;
            this.enemyHealthLabel = enemyHealthLabel;
        }

        public void EnemyAttack()
        {
            if (playerDexterity + playerLuck < random.Next(0, 10))
            {
                playerHealth -= enemyStrength;
                playerHealthLabel.Text = playerHealth.ToString();
            }
        }

        public void PlayerAttack()
        {
            if (enemyDexterity + enemyLuck < random.Next(0, 10))
            {
                enemyHealth -= playerStrength;
                enemyHealthLabel.Text = enemyHealth.ToString();
            }
        }
    }
}