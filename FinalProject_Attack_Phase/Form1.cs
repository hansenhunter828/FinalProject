using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace FinalProject_Attack_Phase
{
    public partial class Form1 : Form
    {
        #region //variables
        // important variables
        int mode = 1;
        int attackPhase = 1;
        int chances;

        string Rules = "Fight In Four Battles With Classic Enemys Like Crabs And Vampires. You Have Two Heals And You Keep Your Health In Each Battle.\n\nGood Luck!";
        string Credits = "Created by Sam Wolfgram\n\nDesigned by Sam Wolfgram\n\nTaught by Mr T.\n\nImages from The Internet\n\nSounds from The Internet\n\nFont from Daniel Linssen";
        //player variables
        int playerHealth = 100;
        int playerMaxHealth = 100;
        bool playerDefeat;
        string[] playerMove = {"Sword","Axe","Bow","Spear"};
        int[] playerDamage = {4,8,5,10};
        int[] playerMoveChance = {99,70,85,60};

        int healUse = 2;
        bool healed;
        bool failed;
        string playerAttack;
        int weaponChoice;
        int missed;
        bool defended;
        //enemy variables
        int currentEnemy;
        int currentEnemtyHealthDiffrence;
        int enemy1 = 0;
        int enemy2 = 1;
        int enemy3 = 2;
        int enemy4 = 3;
        bool enemy1Defeat;
        bool enemy2Defeat;
        bool enemy3Defeat;
        bool enemy4Defeat;
        string[] enemyName = {"Crab","Baby Yoda","Covid-19","Vampire"};
        int[] enemyHealth = {20,14,50,30};
        int[] enemyMaxHealth = {20,14,50,30};

        string[] enemyMove1 = {"claw","force push","weez","scratch"};
        int[] enemyDamage1 = {5,7,3,4};
        string[] enemyMove2 = {"Bite","force lightning","cough","Bat Attack"};
        int[] enemyDamage2 = {9,13,5,7};
        string[] enemyMove3 = {"nible","force lift","mutate","Blood Suck"};
        int[] enemyDamage3 = {4,10,7,6};
        string[] enemyMove4 = {"boiling water","call my daddy","infect","magic stare down"};
        int[] enemyDamage4 = {10,20,100,5};
        int enemyChance = 90;
        int enemyMissed;
        int enemyMoveChoice;

        

        //other set up
        SolidBrush healthBar = new SolidBrush(Color.Green);
        SolidBrush grayBrush = new SolidBrush(Color.Gray);
        Random randGen = new Random();
        SoundPlayer heroAttack = new SoundPlayer(Properties.Resources.Swipe);
        SoundPlayer heroHurt = new SoundPlayer(Properties.Resources.playerHurt);
        SoundPlayer crabAttack = new SoundPlayer(Properties.Resources.crabAttack);
        SoundPlayer crabHurt = new SoundPlayer(Properties.Resources.crabHurt);
        SoundPlayer BabyYodaAttack = new SoundPlayer(Properties.Resources.BabyYodaAttack);
        SoundPlayer BabyYodaHurt = new SoundPlayer(Properties.Resources.BabyYodaHurt);
        SoundPlayer covidAttack = new SoundPlayer(Properties.Resources.cough);
        SoundPlayer covidHurt = new SoundPlayer(Properties.Resources.hurtCough);
        SoundPlayer vampireAttack = new SoundPlayer(Properties.Resources.vampireAttack);
        SoundPlayer vampireHurt = new SoundPlayer(Properties.Resources.vampireHurt);
        
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        #region // input click
        private void inputOne_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    Variable_Reset();
                    mode = 2;
                    Refresh();
                    break;
                case 2:
                    if (!enemy1Defeat && !playerDefeat) ModeTwo_Choose(enemy1);
                    break;
                case 3:
                    switch (attackPhase)
                    {
                        case 1:
                            attackPhase = 2;
                            inputOne.Text = $"{playerMove[0]}";
                            inputTwo.Text = $"{playerMove[1]}";
                            inputThree.Text = $"{playerMove[2]}";
                            inputFour.Text = $"{playerMove[3]}";
                            inputBack.Text = "Back";
                            break;
                        case 2:
                            weaponChoice = 0;
                            playerAttack = $"{playerMove[weaponChoice]}";
                            attackPhase = 3;
                            inputOne.Text = $"Attack Menu";
                            inputTwo.Text = $"Defend";
                            inputThree.Text = $"Heal";
                            inputFour.Text = $"Escape";
                            inputBack.Text = "";
                            break;
                        case 3: break;

                    }
                    break;
            }
        }

        private void inputTwo_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    mode = 2;
                    Refresh();
                    break;
                case 2:
                    if (!enemy2Defeat && !playerDefeat) ModeTwo_Choose(enemy2);
                    break;
                case 3:
                    switch (attackPhase)
                    {
                        case 1:
                            defended = true;
                            attackPhase = 3;
                            Refresh();
                            break;
                        case 2:
                            weaponChoice = 1;
                            playerAttack = $"{playerMove[weaponChoice]}";
                            attackPhase = 3;
                            inputOne.Text = $"Attack Menu";
                            inputTwo.Text = $"Defend";
                            inputThree.Text = $"Heal";
                            inputFour.Text = $"Escape";
                            inputBack.Text = "";
                            break;
                        case 3: break;

                    }
                    break;
            }

        }
        private void inputThree_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    rulesLabel.Text = $"{Rules}";
                    break;
                case 2:
                    if (!enemy3Defeat && !playerDefeat) ModeTwo_Choose(enemy3);
                    break;
                case 3:
                    switch (attackPhase)
                    {
                        case 1:
                            if (healUse >= 1)
                            {
                                if (playerHealth <= 80)
                                {
                                    playerHealth += 20;
                                    outputLabel.Text = "you healed 20 health!";
                                    healUse--;
                                    healed = true;
                                    attackPhase = 3;
                                }
                                else outputLabel.Text = "you cannot heal yet";


                                inputOne.Text = $"Attack Menu";
                                inputTwo.Text = $"Defend";
                                inputThree.Text = $"Heal";
                                inputFour.Text = $"Escape";
                                inputBack.Text = "";
                            }
                            else outputLabel.Text = "You have already healed enough times!";
                            break;
                        case 2:
                            weaponChoice = 2;
                            playerAttack = $"{playerMove[weaponChoice]}";
                            attackPhase = 3;
                            inputOne.Text = $"Attack Menu";
                            inputTwo.Text = $"Defend";
                            inputThree.Text = $"Heal";
                            inputFour.Text = $"Escape";
                            inputBack.Text = "";
                            break;
                        case 3: break;

                    }
                    break;
            }

        }

        private void inputFour_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    rulesLabel.Text = $"{Credits}";
                    break;
                case 2:
                    if (!enemy4Defeat && !playerDefeat) ModeTwo_Choose(enemy4);
                    break;
                case 3:
                    switch (attackPhase)
                    {
                        case 1:
                            chances = randGen.Next(1,101);
                            if (chances <= 50)
                            {
                                mode = 2;
                                Refresh();
                                outputLabel.Text = "You Escaped!";
                            }
                            else
                            {
                                outputLabel.Text = "You Didn't Escape";
                                failed = true;
                                attackPhase = 3;
                            }
                            

                            break;
                        case 2:
                            weaponChoice = 3;
                            playerAttack = $"{playerMove[weaponChoice]}";
                            attackPhase = 3;
                            inputOne.Text = $"Attack Menu";
                            inputTwo.Text = $"Defend";
                            inputThree.Text = $"Heal";
                            inputFour.Text = $"Escape";
                            inputBack.Text = "";
                            break;
                        case 3: break;

                    }
                    break;
            }

        }

        private void inputBack_Click(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    Application.Exit();
                    break;
                case 2:
                    mode = 1;
                    Refresh();
                    break;
                case 3:
                    switch (attackPhase)
                    {
                        case 1:
                            break;
                        case 2:
                            attackPhase = 1;
                            inputOne.Text = $"Attack Menu";
                            inputTwo.Text = $"Defend";
                            inputThree.Text = $"Heal";
                            inputFour.Text = $"Escape";
                            inputBack.Text = "";
                            break;
                        case 3: break;

                    }
                    break;
                case 4:
                    mode = 1;
                    inputOne.Text = "New Game";
                    inputTwo.Text = "Continue";
                    inputThree.Text = "Rules";
                    inputFour.Text = "Credits";
                    inputBack.Text = "Exit";
                    HeaderLabel.Text = "RPG Dungeaon";
                    inputOne.Visible = true;
                    inputTwo.Visible = true;
                    inputThree.Visible = true;
                    inputFour.Visible = true;
                    outputLabel.Visible = true;
                    Variable_Reset();
                    Refresh();
                    break;
            }

        }
        #endregion

        private void Step_Tick(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    playerLabel.Visible = false;
                    enemyLabel.Visible = false;
                    enemyNameLabel.Visible = false;
                    enemyOne.Visible = false;
                    enemyTwo.Visible = false;
                    enemyThree.Visible = false;
                    enemyFour.Visible = false;
                    HeaderLabel.Visible = true;
                    pictureLabel.Visible = true;
                    rulesLabel.Visible = true;
                    pictureLabel.Image = Properties.Resources.title;
                    inputOne.Text = "New Game";
                    inputTwo.Text = "Continue";
                    inputThree.Text = "Rules";
                    inputFour.Text = "Credits";
                    inputBack.Text = "Exit";
                    break;
                case 2:
                    playerLabel.Visible = false;
                    enemyLabel.Visible = false;
                    enemyNameLabel.Visible = false;
                    enemyOne.Visible = true;
                    enemyTwo.Visible = true;
                    enemyThree.Visible = true;
                    enemyFour.Visible = true;
                    HeaderLabel.Visible = false;
                    pictureLabel.Visible = false;
                    rulesLabel.Visible = false;
                    inputOne.Text = "Crab";
                    inputTwo.Text = "Baby Yoda";
                    inputThree.Text = "Covid-19";
                    inputFour.Text = "Vampire";
                    inputBack.Text = "Menu";
                    break;
                case 3:
                    playerLabel.Visible = true;
                    enemyLabel.Visible = true;
                    enemyNameLabel.Visible = true;
                    enemyOne.Visible = false;
                    enemyTwo.Visible = false;
                    enemyThree.Visible = false;
                    enemyFour.Visible = false;
                    HeaderLabel.Visible = false;
                    pictureLabel.Visible = false;
                    rulesLabel.Visible = false;
                    if (attackPhase == 3)
                    {
                        // finish player turn
                        if (!healed)
                        {
                            if (!failed)
                            {
                                if (!defended)
                                {
                                    outputLabel.Text = $"{playerAttack}";
                                    missed = randGen.Next(1, 101);
                                    if (missed <= playerMoveChance[weaponChoice])
                                    {
                                        if (currentEnemy == enemy3)
                                        {
                                            if (weaponChoice == 0 || weaponChoice == 1)
                                            {
                                                chances = randGen.Next(1, 101);
                                                if (chances <= 6)
                                                {
                                                    playerHealth -= enemyDamage4[currentEnemy];
                                                    outputLabel.Text = $"An Infction Killed You";
                                                    Refresh();
                                                    Thread.Sleep(1000);
                                                }
                                                else outputLabel.Text = $"You Survived An Infection";
                                                currentEnemtyHealthDiffrence = enemyMaxHealth[currentEnemy] - enemyHealth[currentEnemy];
                                                Refresh();
                                                Thread.Sleep(1000);
                                            }
                                        }
                                        enemyHealth[currentEnemy] -= playerDamage[weaponChoice];
                                        heroAttack.PlaySync();
                                        switch (currentEnemy)
                                        {
                                            case 0:
                                                crabHurt.Play();
                                                break;
                                            case 1:
                                                BabyYodaHurt.Play();
                                                break;
                                            case 2:
                                                covidHurt.Play();
                                                break;
                                            case 3:
                                                vampireHurt.Play();
                                                break;
                                        }
                                    }
                                    else outputLabel.Text = "You Missed";
                                }
                                else outputLabel.Text = "Your are Defeneded";
                            }
                            else failed = false;
                        }
                        else healed = false;
                        if (currentEnemy == enemy1 && enemyHealth[currentEnemy] <= 0)
                        {
                            enemy1Defeat = true;
                            mode = 2;
                            Refresh();
                            break;
                        }
                        if (currentEnemy == enemy2 && enemyHealth[currentEnemy] <= 0)
                        {
                            enemy2Defeat = true;
                            mode = 2;
                            Refresh();
                            break;
                        }
                        if (currentEnemy == enemy3 && enemyHealth[currentEnemy] <= 0)
                        {
                            enemy3Defeat = true;
                            mode = 2;
                            Refresh();
                            break;
                        }
                        if (currentEnemy == enemy4 && enemyHealth[currentEnemy] <= 0)
                        {
                            enemy4Defeat = true;
                            mode = 2;
                            Refresh();
                            break;
                        }
                        currentEnemtyHealthDiffrence = enemyMaxHealth[currentEnemy] - enemyHealth[currentEnemy];
                        Refresh();
                        Thread.Sleep(1000);
                        //enemy attacks


                        if (!defended)
                        {
                            enemyMissed = randGen.Next(1, 101);
                            if (enemyMissed <= enemyChance)
                            {
                                enemyMoveChoice = randGen.Next(0, 4);
                                switch (enemyMoveChoice)
                                {
                                    case 0:
                                        outputLabel.Text = $"{enemyMove1[currentEnemy]}";
                                        playerHealth -= enemyDamage1[currentEnemy];
                                        break;
                                    case 1:
                                        outputLabel.Text = $"{enemyMove2[currentEnemy]}";
                                        playerHealth -= enemyDamage2[currentEnemy];
                                        break;
                                    case 2:
                                        if (enemyMove3[currentEnemy] == "nible" && enemyHealth[currentEnemy] <= 16)
                                        {
                                            playerHealth -= enemyDamage3[currentEnemy];
                                            enemyHealth[currentEnemy] += enemyDamage3[currentEnemy];
                                            outputLabel.Text = $"{enemyMove3[currentEnemy]}";
                                        }
                                        else if (enemyMove3[currentEnemy] == "mutate" && enemyHealth[currentEnemy] <= 42)
                                        {
                                            enemyHealth[currentEnemy] += enemyDamage3[currentEnemy];
                                            outputLabel.Text = $"{enemyMove3[currentEnemy]}";
                                        }
                                        else if (enemyMove3[currentEnemy] == "Blood Suck")
                                        {
                                            playerHealth -= enemyDamage3[currentEnemy];
                                            if (enemyHealth[currentEnemy] <= 24) enemyHealth[currentEnemy] += enemyDamage3[currentEnemy];
                                            outputLabel.Text = $"{enemyMove3[currentEnemy]}";
                                        }
                                        else
                                        {
                                            outputLabel.Text = $"{enemyMove3[currentEnemy]}";
                                            playerHealth -= enemyDamage3[currentEnemy];
                                        }
                                        break;
                                    case 3:
                                        if (enemyMove4[currentEnemy] == "magic stare down")
                                        {
                                            playerHealth -= enemyDamage4[currentEnemy];
                                            outputLabel.Text = $"{enemyMove4[currentEnemy]}";
                                            Refresh();
                                            Thread.Sleep(1000);
                                            enemyMoveChoice = randGen.Next(0, 4);
                                            switch (enemyMoveChoice)
                                            {
                                                case 0:
                                                    playerHealth -= enemyDamage1[currentEnemy];
                                                    outputLabel.Text = $"{enemyMove1[currentEnemy]}";
                                                    break;
                                                case 1:
                                                    playerHealth -= enemyDamage2[currentEnemy];
                                                    outputLabel.Text = $"{enemyMove2[currentEnemy]}";
                                                    break;
                                                case 2:
                                                    playerHealth -= enemyDamage3[currentEnemy];
                                                    if (enemyHealth[currentEnemy] <= 26) enemyHealth[currentEnemy] += enemyDamage3[currentEnemy];
                                                    outputLabel.Text = $"{enemyMove3[currentEnemy]}";
                                                    break;
                                                case 3:
                                                    playerHealth -= enemyDamage4[currentEnemy];
                                                    outputLabel.Text = $"{enemyMove4[currentEnemy]}";
                                                    break;
                                            }

                                        }
                                        else if (enemyMove4[currentEnemy] == "infect")
                                        {
                                            chances = randGen.Next(1, 101);
                                            if (chances <= 6) playerHealth -= enemyDamage4[currentEnemy];
                                            outputLabel.Text = $"{enemyMove4[currentEnemy]}";
                                        }
                                        else if (enemyMove4[currentEnemy] == "boiling water")
                                        {
                                            playerHealth -= enemyDamage4[currentEnemy];
                                            enemyHealth[currentEnemy] -= enemyDamage4[currentEnemy];
                                            outputLabel.Text = $"{enemyMove4[currentEnemy]}";
                                        }
                                        else
                                        {
                                            outputLabel.Text = $"{enemyMove4[currentEnemy]}";
                                            playerHealth -= enemyDamage4[currentEnemy];
                                        }
                                        break;
                                }
                                switch (currentEnemy)
                                {
                                    case 0:
                                        crabAttack.Play();
                                        break;
                                    case 1:
                                        BabyYodaAttack.Play();
                                        break;
                                    case 2:
                                        covidAttack.Play();
                                        break;
                                    case 3:
                                        vampireAttack.Play();
                                        break;
                                }
                            }
                            else outputLabel.Text = "They Missed!";
                        }
                        else
                        {
                            defended = false;
                            outputLabel.Text = "You defended yourself!";
                        }
                        if (playerHealth <= 0)
                        {
                            playerDefeat = true;
                            mode = 4;
                            Refresh();
                            break;
                        }
                        if (currentEnemy == enemy1 && enemyHealth[currentEnemy] <= 0)
                        {
                            enemy1Defeat = true;
                            mode = 2;
                            Refresh();
                            break;
                        }
                        attackPhase = 1;
                    }
                    currentEnemtyHealthDiffrence = enemyMaxHealth[currentEnemy] - enemyHealth[currentEnemy];
                    Refresh();
                    break;
                case 4:
                    playerLabel.Visible = false;
                    enemyLabel.Visible = false;
                    enemyNameLabel.Visible = false;
                    enemyOne.Visible = false;
                    enemyTwo.Visible = false;
                    enemyThree.Visible = false;
                    enemyFour.Visible = false;
                    HeaderLabel.Visible = true;
                    pictureLabel.Visible = true;
                    rulesLabel.Visible = true;
                    outputLabel.Visible = false;
                    inputOne.Visible = false;
                    inputTwo.Visible = false;
                    inputThree.Visible = false;
                    inputFour.Visible = false;
                    pictureLabel.Image = Properties.Resources.title;
                    inputBack.Text = "contiune";

                    if (playerDefeat)
                    {
                        HeaderLabel.Text = "You Lose";
                    }
                    else
                    {
                        HeaderLabel.Text = "You Win";
                    }
                    break;
            }
            if (enemy1Defeat && enemy2Defeat && enemy3Defeat && enemy4Defeat)
            {
                mode = 4;
                rulesLabel.Text = "";
                Refresh();
            }
            enemyTwo.Image = Properties.Resources.yoda1;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            switch (mode)
            {
                case 1:
                    break;
                case 2:
                    e.Graphics.FillRectangle(grayBrush, 12, 462, playerMaxHealth * 5, 23);
                    e.Graphics.FillRectangle(healthBar, 12, 462, playerHealth * 5, 23);
                    break;
                case 3:
                    e.Graphics.FillRectangle(grayBrush, 12, 462, playerMaxHealth * 5, 23);
                    e.Graphics.FillRectangle(healthBar, 12, 462, playerHealth * 5, 23);
                    e.Graphics.FillRectangle(grayBrush, 822, 68, enemyMaxHealth[currentEnemy] * 5, 23);
                    e.Graphics.FillRectangle(healthBar, 822 + currentEnemtyHealthDiffrence * 5, 68, enemyHealth[currentEnemy] * 5, 23);
                    break;
            }


        }
        #region //mouse hover
        private void inputOne_MouseHover(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    outputLabel.Text = "Start A New Game";
                    break;
                case 2:
                    outputLabel.Text = $"Fight A Crab\n{enemyHealth[enemy1]} Health\nIt Can Claw At You But It Is Pretty Weak";
                    break;
                case 3:
                    switch (attackPhase)
                    {
                        case 1:
                            outputLabel.Text = "Go To The Attack Menu";
                            break;
                        case 2:
                            outputLabel.Text = "Sword Attack\n99% Hit Rate\n4 damage";
                            break;
                    }
                    break;
            }
        }

        private void inputTwo_MouseHover(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    outputLabel.Text = "Continue From Where You Left Off";
                    break;
                case 2:
                    outputLabel.Text = $"Fight Baby Yoda\n{enemyHealth[enemy2]} Health\nHe Has Low Health But He Has Very Powerful Moves\nWatch Out For His Dad";
                    break;
                case 3:
                    switch (attackPhase)
                    {
                        case 1:
                            outputLabel.Text = "Defend yourself from an attack";
                            break;
                        case 2:
                            outputLabel.Text = "Axe Attack\n70% hit rate\n8 damage";
                            break;
                    }
                    break;
            }
        }

        private void inputThree_MouseHover(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    outputLabel.Text = "See The Rules";
                    break;
                case 2:
                    outputLabel.Text = $"Fight Covid-19\n{enemyHealth[enemy3]}\nCovid-19 Has The Most Health, But Its Attacks Are Weak\nWatch Out For Its Infection, It Has A 6% Chance Of Killing You\nSowrd And Axe Attacks Will Exposs You So Try And Avoid Those Attacks";
                    break;
                case 3:
                    switch (attackPhase)
                    {
                        case 1:
                            outputLabel.Text = "Heal Yourself";
                            break;
                        case 2:
                            outputLabel.Text = "Bow Attack\n85% hit rate\n5 damage";
                            break;
                    }
                    break;
            }
        }

        private void inputFour_MouseHover(object sender, EventArgs e)
        {
            switch (mode)
            {
                case 1:
                    outputLabel.Text = "See The Credits";
                    break;
                case 2:
                    outputLabel.Text = $"Fight A Vampire\n{enemyHealth[enemy4]} Health\nHe Can Suck Your Blood To Regain Health, And His Stare Down Will Activate Another Move";
                    break;
                case 3:
                    switch (attackPhase)
                    {
                        case 1:
                            outputLabel.Text = "Get Away From Battle";
                            break;
                        case 2:
                            outputLabel.Text = "Spear Attack\n60% hit rate\n10 damage";
                            break;
                    }
                    break;
            }
        }
        #endregion

        private void ModeTwo_Choose(int temp)
        {
            currentEnemy = temp;
            mode = 3;
            attackPhase = 1;
            inputOne.Text = "Attack Menu";
            inputTwo.Text = "Defend";
            inputThree.Text = "Heal";
            inputFour.Text = "Escape";
            inputBack.Text = "";
            enemyNameLabel.Text = $"{enemyName[currentEnemy]}";
            if (temp == 0) enemyLabel.Image = Properties.Resources.crab;
            if (temp == 1) enemyLabel.Image = Properties.Resources.yoda1;
            if (temp == 2) enemyLabel.Image = Properties.Resources.covid_19;
            if (temp == 3) enemyLabel.Image = Properties.Resources.spike;
            Refresh();
        }

        private void Variable_Reset()
        {
            playerHealth = playerMaxHealth;
            enemyHealth[0] = enemyMaxHealth[0];
            enemyHealth[1] = enemyMaxHealth[1];
            enemyHealth[2] = enemyMaxHealth[2];
            enemyHealth[3] = enemyMaxHealth[3];

            enemy1Defeat = false;
            enemy2Defeat = false;
            enemy3Defeat = false;
            enemy4Defeat = false;
            playerDefeat = false;
        }
    }
}
