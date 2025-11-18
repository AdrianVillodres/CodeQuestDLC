using System;
using System.Text;
namespace CodeQuestDLC
{
    class Program
    {
        // para la array temporal mas grande crear una array con la lenght the la anterior +1
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            const string MenuTitle = "===== MAIN MENU - CODEQUEST =====";
            const string MenuWNameTitile = "===== Welcome {0} the {1} with level {2} =====";
            const string MenuOption1 = "1. Train your wizard";
            const string MenuOption2 = "2. Increase level";
            const string MenuOption3 = "3. Loot the mine";
            const string MenuOption4 = "4. Show inventory";
            const string MenuOption5 = "5. Buy items";
            const string MenuOption6 = "6. Show attacks by level";
            const string MenuOption7 = "7. Decode ancient Scroll";
            const string MenuOptionExit = "0. Exit game";
            const string MenuPrompt = "Choose an option (1-3) - (0) to exit: ";
            const string InputErrorMessage = "Invalid input. Please enter a number between 0 and 3.";
            const string IntroductionMessageC1 = "Hey you! You're finally awake. Rise and shine! Its your first day in the academy. You will learn about the arcane arts and alchemy. But first things first, what's your name?";
            const string TrainingMessageC1 = "Alright! Let's go. Before you can go outside the academy, you must train your mind and spells. So you will need to meditate for 5 days. I recommend you do it from 1 to 10 hours, the choice is yours. See you in five days. Good luck!";
            const string TrainingCompleteMessageC1 = "Hello! I came back to see how you are doing and evaluate your power. Let me see through your soul...";
            const string TrainingResultMessageC1_1 = "You repeat on the 2nd convocatory";
            const string TrainingResultMessageC1_2 = "You still confuse the wand with a spoon.";
            const string TrainingResultMessageC1_3 = "You are a Summoner of Magical Breezes.";
            const string TrainingResultMessageC1_4 = "Wow! You can summon dragons without burning down the lab!";
            const string TrainingResultMessageC1_5 = "You have reached the rank of Arcane Master!";
            const string MageLevel1 = "Raoden the Elantrion";
            const string MageLevel2 = "Zyn the bugged";
            const string MageLevel3 = "Arka Nullpointer";
            const string MageLevel4 = "Elarion of Flames";
            const string MageLevel5 = "ITB-Wizard the Grey";
            const string EnemyBattleIntroMsg = "A wild {0} appears! Rolling dice to determine the outcome of the battle...";
            const string EnemyInfoMsg = "The {0} has {1} HP.";
            const string NumberRolledMsg = "You rolled a {0}!";
            const string EnemyTakesDamageMsg = "The enemy takes damage!";
            const string EnemyDefeatedMsg = "The {0} has been defeated!";
            const string PressKeyMsg = "Press any key to roll the dice again...";
            const string Dice1 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n |       | |\r\n |   o   | /\r\n |       |/ \r\n '-------'\r\n";
            const string Dice2 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n |       | |\r\n | o   o | /\r\n |       |/ \r\n '-------'\r\n";
            const string Dice3 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n |     o | |\r\n |   o   | /\r\n | o     |/ \r\n '-------'\r\n";
            const string Dice4 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |       | /\r\n | o   o |/ \r\n '-------'\r\n";
            const string Dice5 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n |   o   | /\r\n | o   o |/ \r\n '-------'\r\n";
            const string Dice6 = "   ________\r\n  /       /|   \r\n /_______/ |\r\n | o   o | |\r\n | o   o | /\r\n | o   o |/ \r\n '-------'\r\n";
            const string IntroductionMessageC3 = "Congratulations, You are a true Dragonslayer. Now, you are in front of a bitcoin mine. You have to dig and collect the bitcoins, but maybe you will find no bitcoins, so be careful! ";
            const string NotFoundBitcoins = "Today's not your lucky day, you found 0 bitcoins";
            const string EnoughBitcoins = "You’ve unlocked the gold GPU! Your spells now run at 120 FPS!";
            const string NotEnoughBitcoins = "Your magic card is still integrated. It's time to defeat another dragon!";
            const string MsgBitcoins = "Nice! You found {0} bitcoins";
            const int ROWS = 5;
            const int COLS = 5;
            const string NotDigged = "➖";
            const string Coin = "🪙";
            const string Cross = "❌";
            const string BeginDiggingMsg = "You have {0} tries to dig for bitcoins";
            const string XAxisInputMsg = "Put the X axis(0-4): ";
            const string YAxisInputMsg = "Put the Y axis(0-4): ";
            const string AxisErrorMsg = "Error, you have to put an integer number between 0 and 4";
            const string EmptyInventory = "Your inventory is empty";

            string[] enemies = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🟢", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍♂️", "Ancient Dragon 🐉" };
            string[] dices = { Dice1, Dice2, Dice3, Dice4, Dice5, Dice6 };
            int[] enemiesHP = { 3, 5, 10, 11, 18, 15, 20, 50 };
            int op = 0;
            int power = 0;
            int randNum;
            bool validInput;
            var rand = new Random();
            string playerName = "";
            string title = "";
            int level = 1;
            string enemy;
            int enemyHP;
            int rolledNumber;
            string dice;
            int bitcoinCounter;
            int bitcoinFound;
            int digCounter;
            int digXAxis;
            int digYAxis;
            string[,] map = new string[ROWS, COLS];
            string[,] hiddenMap = new string[ROWS, COLS];
            string[] inventory = new string[0];

            do
            {
                Console.WriteLine(MenuTitle);
                if (playerName.CompareTo("") != 0)
                {
                    Console.WriteLine(MenuWNameTitile, playerName, title, level);
                }
                Console.WriteLine(MenuOption1);
                Console.WriteLine(MenuOption2);
                Console.WriteLine(MenuOption3);
                Console.WriteLine(MenuOption4);
                Console.WriteLine(MenuOptionExit);
                Console.Write(MenuPrompt);

                validInput = true;

                try
                {
                    op = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine(InputErrorMessage);
                    validInput = false;
                }
                catch (Exception)
                {
                    Console.WriteLine(InputErrorMessage);
                    validInput = false;
                }

                if (validInput)
                {
                    switch (op)
                    {
                        case 1:
                            Console.WriteLine(IntroductionMessageC1);
                            playerName = Console.ReadLine();
                            for (int i = 0; i < playerName.Length; i++)
                            {
                                if (i == 0)
                                {
                                    playerName = playerName[i].ToString().ToUpper() + playerName.Substring(1);
                                }
                            }
                            Console.WriteLine($"Welcome to the academy, {playerName}!");
                            Thread.Sleep(1000);
                            Console.WriteLine(TrainingMessageC1);
                            Thread.Sleep(3000);
                            for (int ctr = 0; ctr <= 4; ctr++)
                            {
                                randNum = rand.Next(1, 25);
                                power += rand.Next(1, 11);
                                Console.WriteLine($"Today I meditated for {randNum} hours! My power might increase to {power}!");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine(TrainingCompleteMessageC1);
                            Thread.Sleep(2000);
                            if (power < 20)
                            {
                                Console.WriteLine(TrainingResultMessageC1_1);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine(MageLevel1);
                                title = MageLevel1;
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            else if (power >= 20 && power < 30)
                            {
                                Console.WriteLine(TrainingResultMessageC1_2);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine(MageLevel2);
                                title = MageLevel2;
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            else if (power >= 30 && power < 35)
                            {
                                Console.WriteLine(TrainingResultMessageC1_3);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine(MageLevel3);
                                title = MageLevel3;
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            else if (power >= 35 && power < 40)
                            {
                                Console.WriteLine(TrainingResultMessageC1_4);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine(MageLevel4);
                                title = MageLevel4;
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine(TrainingResultMessageC1_5);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine(MageLevel5);
                                title = MageLevel5;
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            break;
                        case 2:
                            randNum = rand.Next(0, 8);
                            enemy = enemies[randNum];
                            enemyHP = enemiesHP[randNum];
                            Console.WriteLine(EnemyBattleIntroMsg, enemy);
                            Console.WriteLine(EnemyInfoMsg, enemy, enemyHP);
                            while (enemyHP > 0)
                            {
                                rolledNumber = rand.Next(1, 7);
                                dice = dices[rolledNumber - 1];
                                Console.WriteLine(NumberRolledMsg, rolledNumber);
                                Console.WriteLine(dice);
                                enemyHP -= rolledNumber;
                                if (enemyHP < 0)
                                {
                                    enemyHP = 0;
                                }
                                Console.WriteLine(EnemyTakesDamageMsg);
                                Console.WriteLine(EnemyInfoMsg, enemy, enemyHP);
                                Console.WriteLine(PressKeyMsg);
                                Console.ReadKey();
                            }
                            Console.WriteLine(EnemyDefeatedMsg, enemy);
                            if (level < 5)
                            {
                                level++;
                            }
                            break;
                        case 3:
                            digCounter = 5;
                            bitcoinCounter = 0;
                            bitcoinFound = 0;
                            validInput = true;
                            digXAxis = 0;
                            digYAxis = 0;
                            Console.WriteLine(IntroductionMessageC3);
                            for (int i = 0; i < map.GetLength(0); i++)
                            {
                                for (int j = 0; j < map.GetLength(1); j++)
                                {
                                    map[i, j] = NotDigged;
                                }
                            }
                            for (int i = 0; i < hiddenMap.GetLength(0); i++)
                            {
                                for (int j = 0; j < hiddenMap.GetLength(1); j++)
                                {
                                    randNum = rand.Next(1, 4);
                                    if (randNum == 2)
                                    {
                                        hiddenMap[i, j] = Coin;
                                    }
                                    else
                                    {
                                        hiddenMap[i, j] = Cross;
                                    }
                                }
                                Console.WriteLine();
                            }

                            while (digCounter > 0)
                            {
                                for (int i = 0; i < map.GetLength(0); i++)
                                {
                                    for (int j = 0; j < map.GetLength(1); j++)
                                    {
                                        Console.Write(map[i, j]);
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine(BeginDiggingMsg, digCounter);
                                Console.WriteLine(XAxisInputMsg);
                                try
                                {
                                    digXAxis = Int32.Parse(Console.ReadLine());
                                }
                                catch (OverflowException)
                                {
                                    Console.WriteLine(AxisErrorMsg);
                                    validInput = false;
                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine(AxisErrorMsg);
                                    validInput = false;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(AxisErrorMsg);
                                    validInput = false;
                                }
                                if (validInput && digXAxis >= 0 && digXAxis <= 4)
                                {
                                    Console.WriteLine(YAxisInputMsg);
                                    try
                                    {
                                        digYAxis = Int32.Parse(Console.ReadLine());
                                    }
                                    catch (OverflowException)
                                    {
                                        Console.WriteLine(AxisErrorMsg);
                                        validInput = false;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine(AxisErrorMsg);
                                        validInput = false;
                                    }
                                    catch (Exception)
                                    {
                                        Console.WriteLine(AxisErrorMsg);
                                        validInput = false;
                                    }
                                    if (validInput && digYAxis >= 0 && digYAxis <= 4)
                                    {
                                        if (hiddenMap[digXAxis, digYAxis].Contains(Coin))
                                        {
                                            bitcoinFound = rand.Next(5, 51);
                                            bitcoinCounter += bitcoinFound;
                                            map[digXAxis, digYAxis] = Coin;
                                            Console.WriteLine(MsgBitcoins, bitcoinFound);
                                        }
                                        else
                                        {
                                            map[digXAxis, digYAxis] = Cross;
                                            Console.WriteLine(NotFoundBitcoins);
                                        }
                                        digCounter--;
                                    }
                                    else
                                    {
                                        Console.WriteLine(AxisErrorMsg);
                                    }
                                }
                                else
                                {
                                    Console.WriteLine(AxisErrorMsg);
                                }

                            }
                            if (bitcoinCounter > 200)
                            {
                                Console.WriteLine(EnoughBitcoins);
                            }
                            else
                            {
                                Console.WriteLine(NotEnoughBitcoins);
                            }
                            break;
                        case 4:


                            if (inventory.Length == 0)
                            {
                                Console.WriteLine(EmptyInventory);
                            }
                            else
                            {
                                for (int i = 0; i < inventory.Length; i++)
                                {
                                    Console.WriteLine(inventory[i]);
                                }
                            }
                            break;
                    }
                }


            } while (op != 0);
        }
    }
}