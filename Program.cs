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
            const string MenuNameTitle = "===== Welcome {0} the {1} with level {2} =====";
            const string MenuOption1 = "1. Train your wizard";
            const string MenuOption2 = "2. Increase level";
            const string MenuOption3 = "3. Loot the mine";
            const string MenuOption4 = "4. Show inventory";
            const string MenuOption5 = "5. Buy items";
            const string MenuOption6 = "6. Show attacks by level";
            const string MenuOption7 = "7. Decode ancient Scroll";
            const string MenuOptionExit = "0. Exit game";
            const string MenuPrompt = "Choose an option (1-7) - (0) to exit: ";
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
            const string ShopGreetingMsg = "Welcome to the shop! We have all of this!";
            const string ShopOptionMsg = "Select from 1 to 5 to buy an item, 0 to exit";
            const string ShopError = "Sorry, we don't have that, select an integer number beetwen 0 and 5";
            const string BitsAvailableMsg = "You have {0} bits available";
            const string ShopExitMsg = "Thanks for coming!";
            const string NotEnoughMoneyMsg = "You don't have enough money to buy that";
            const string AvailableAttacksMsg = "Available attacks for level {0}:";
            const string IntroMsgCh7 = "You found an ancient scroll with encrypted messages!";
            const string ScrollsToDecode = "Scrolls to decode: ";
            const string FirstScroll = "The 🐲 sleeps in the mountain of fire 🔥";
            const string SecondScroll = "Ancient magic flows through the crystal caves";
            const string ThirdScroll = "Spell: Ignis 5 🔥, Aqua 6 💧, Terra 3 🌍, Ventus 8 🌪️";
            const string ScrollOperation = "Choose a decoding operation:";
            const string DecipherSpell = "Decipher spell (remove spaces)";
            const string CountRunes = "Count magical runes (vowels)";
            const string ExtractCode = "Extract secret code (numbers)";
            const string ScrollSelectionErrorMsg = "Error, you must put a integer number between 1 and 3";
            const string FirstScrollDone = "The first scroll says: {0}";
            const string SecondScrollDone = "The second scroll have {0} bowels";
            const string ThirdScrollDone = "The secret code is: ";

            string[] enemies = { "Wandering Skeleton 💀", "Forest Goblin 👹", "Green Slime 🟢", "Ember Wolf 🐺", "Giant Spider 🕷️", "Iron Golem 🤖", "Lost Necromancer 🧝‍♂️", "Ancient Dragon 🐉" };
            string[] dices = { Dice1, Dice2, Dice3, Dice4, Dice5, Dice6 };
            int[] enemiesHP = { 3, 5, 10, 11, 18, 15, 20, 50 };
            int op = 0;
            int power = 0;
            int totalpower = 0;
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
            int bitcoinCounter = 0;
            int bitcoinFound;
            int digCounter;
            int digXAxis;
            int digYAxis;
            string[,] map = new string[ROWS, COLS];
            string[,] hiddenMap = new string[ROWS, COLS];
            string[] inventory = { };
            string[] shopItems = {"Iron Dagger 🗡️", "Healing Potion ⚗️", "Ancient Key 🗝️", "Crossbow 🏹", "Metal Shield 🛡️"};
            int[] prices = {30, 10, 50, 40, 20};
            string ShopObjectTitle = ("Object");
            string ShopPricesTitle = ("Prices(bits)");
            int itemInput;
            string[] lvl1Attacks = { "Magic Spark 💫" };
            string[] lvl2Attacks = { "Fireball 🔥", "Ice Ray 🥏", "Arcane Shield ⚕️" };
            string[] lvl3Attacks = { "Meteor ☄️", "Pure Energy Explosion 💥", "Minor Charm 🎭", "Air Strike 🍃" };
            string[] lvl4Attacks = { "Wave of Light ⚜️", "Storm of Wings 🐦" };
            string[] lvl5Attacks = { "Cataclysm 🌋", "Portal of Chaos 🌀", "Arcane Blood Pact 🩸", "Elemental Storm ⛈️" };
            int scrollDecode = 0;
            string firstScrollDecoded;
            int secondScrollDecoded;
            char[] thirdScrollDecoded = new char[4];
            int arrayNumber;

            do
            {
                Console.WriteLine(MenuTitle);
                if (playerName.CompareTo("") != 0)
                {
                    Console.WriteLine(MenuNameTitle, playerName, title, level);
                }
                Console.WriteLine(MenuOption1);
                Console.WriteLine(MenuOption2);
                Console.WriteLine(MenuOption3);
                Console.WriteLine(MenuOption4);
                Console.WriteLine(MenuOption5);
                Console.WriteLine(MenuOption6);
                Console.WriteLine(MenuOption7);
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
                                power = rand.Next(1, 11);
                                totalpower += power;
                                Console.WriteLine($"Today I meditated for {randNum} hours! My power might increase to {power}!, my total power is {totalpower}");
                                Thread.Sleep(1000);
                            }
                            Console.WriteLine(TrainingCompleteMessageC1);
                            Thread.Sleep(2000);
                            if (totalpower < 20)
                            {
                                Console.WriteLine(TrainingResultMessageC1_1);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine(MageLevel1);
                                title = MageLevel1;
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            else if (totalpower >= 20 && totalpower < 30)
                            {
                                Console.WriteLine(TrainingResultMessageC1_2);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine(MageLevel2);
                                title = MageLevel2;
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            else if (totalpower >= 30 && totalpower < 35)
                            {
                                Console.WriteLine(TrainingResultMessageC1_3);
                                Thread.Sleep(1000);
                                Console.WriteLine();
                                Console.WriteLine(MageLevel3);
                                title = MageLevel3;
                                Thread.Sleep(1000);
                                Console.WriteLine();
                            }
                            else if (totalpower >= 35 && totalpower < 40)
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
                            }
                                Console.WriteLine();

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
                        case 5:
                            itemInput = 1;
                            validInput = true;
                            Console.WriteLine(ShopGreetingMsg);
                            while (itemInput != 0)
                            {
                                Console.WriteLine(BitsAvailableMsg, bitcoinCounter);
                                Console.WriteLine(ShopOptionMsg);
                                Console.WriteLine(ShopObjectTitle.PadRight(17) + ShopPricesTitle);
                                for (int i = 0; i < shopItems.Length; i++)
                                {
                                    Console.WriteLine(shopItems[i].PadRight(20) + prices[i].ToString().PadRight(10));
                                }
                                try
                                {
                                    itemInput = Convert.ToInt32(Console.ReadLine());

                                }
                                catch (FormatException)
                                {
                                    Console.WriteLine(ShopError);
                                    validInput = false;
                                }
                                catch (OverflowException)
                                {
                                    Console.WriteLine(ShopError);
                                    validInput = false;
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine(ShopError);
                                    validInput = false;
                                }
                                if (validInput && itemInput > 0 && itemInput <= 5)
                                {
                                    itemInput--;                          
                                    if (bitcoinCounter >= prices[itemInput])
                                    {
                                        bitcoinCounter -= prices[itemInput];
                                        string[] newInventory = new string[inventory.GetLength(0) + 1];
                                        for (int i = 0; i < inventory.GetLength(0); i++)
                                        {
                                            newInventory[i] = inventory[i];
                                        }
                                        newInventory[newInventory.GetLength(0) - 1] = shopItems[itemInput];
                                        inventory = newInventory;
                                    }
                                    else
                                    {
                                        Console.WriteLine(NotEnoughMoneyMsg);
                                    }
                                }
                                else if (validInput && itemInput == 0)
                                {
                                    Console.WriteLine(ShopExitMsg);
                                }
                                else
                                {
                                    Console.WriteLine(ShopError);
                                }
                            }
                                break;
                        case 6:
                            Console.WriteLine();
                            Console.WriteLine(AvailableAttacksMsg, level);
                            Console.WriteLine();
                            switch (level)
                            {
                                case 1:
                                    for(int i = 0; i < lvl1Attacks.GetLength(0); i++)
                                    {
                                        Console.WriteLine(lvl1Attacks[i]);
                                    }
                                    break;
                                case 2:
                                    for (int i = 0; i < lvl2Attacks.GetLength(0); i++)
                                    {
                                        Console.WriteLine(lvl2Attacks[i]);
                                    }
                                    break;
                                case 3:
                                    for (int i = 0; i < lvl3Attacks.GetLength(0); i++)
                                    {
                                        Console.WriteLine(lvl3Attacks[i]);
                                    }
                                    break;
                                case 4:
                                    for (int i = 0; i < lvl4Attacks.GetLength(0); i++)
                                    {
                                        Console.WriteLine(lvl4Attacks[i]);
                                    }
                                    break;
                                case 5:
                                    for (int i = 0; i < lvl5Attacks.GetLength(0); i++)
                                    {
                                        Console.WriteLine(lvl5Attacks[i]);
                                    }
                                    break;
                            }
                            Console.WriteLine();
                            break;
                        case 7:
                            Console.WriteLine(IntroMsgCh7);
                            Console.WriteLine();
                            Console.WriteLine(ScrollsToDecode);
                            Console.WriteLine(FirstScroll);
                            Console.WriteLine(SecondScroll);
                            Console.WriteLine(ThirdScroll);
                            Console.WriteLine(ScrollOperation);
                            Console.WriteLine(DecipherSpell);
                            Console.WriteLine(CountRunes);
                            Console.WriteLine(ExtractCode);
                            try
                            {
                                scrollDecode = Convert.ToInt32(Console.ReadLine());

                            }
                            catch (FormatException)
                            {
                                Console.WriteLine(ScrollSelectionErrorMsg);
                                validInput = false;
                            }
                            catch (OverflowException)
                            {
                                Console.WriteLine(ScrollSelectionErrorMsg);
                                validInput = false;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine(ScrollSelectionErrorMsg);
                                validInput = false;
                            }
                            if (scrollDecode < 1 || scrollDecode > 3)
                            {
                                validInput = false;
                            }
                            if (validInput == true)
                            {
                                switch (scrollDecode)
                                {
                                    case 1:
                                        firstScrollDecoded = FirstScroll.Replace(" ", "");
                                        Console.WriteLine(FirstScrollDone,firstScrollDecoded);
                                        break;
                                    case 2:
                                        secondScrollDecoded = SecondScroll.Length;
                                        Console.WriteLine(SecondScrollDone,secondScrollDecoded);
                                        break;
                                    case 3:
                                        arrayNumber = 0;
                                        char[] thirdScrollLetters = ThirdScroll.ToCharArray();
                                        for(int i = 0; i < thirdScrollLetters.GetLength(0); i++)
                                        {
                                            if (char.IsDigit(thirdScrollLetters[i]))
                                            {
                                                thirdScrollDecoded[arrayNumber] = thirdScrollLetters[i];
                                                arrayNumber++;
                                            }
                                        }
                                        Console.WriteLine(ThirdScrollDone);
                                        for (int i = 0; i < arrayNumber; i++)
                                        {
                                            Console.Write(thirdScrollDecoded[i]);
                                        }
                                        break;
                                }
                                Console.WriteLine();
                            }
                            break;
                    }
                    
                }
            } while (op != 0);
        }
    }
}