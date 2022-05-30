using System;
using System.Collections.Generic;

namespace TeReoMaoriQuizProject // name of quiz
{
    class MaoriQuiz // class called MaoriQuiz
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args) // main
#pragma warning restore IDE0060 // Remove unused parameter
        {
            /* Psudo Code
            This program is a 30 question quiz on Te Reo Maori.
            Use System and System.Collections.Generic.
            Have a Class called MaoriQuiz.
            Use static void Main with string parameters with args.
            Include MainMenu Method with string choose level variable. Display Welcome Message. Display the levels with switch statements. Switch statements redirects to the level chosen by user and clears MainMenu.
            If user has chosen Basic Level. Display basicLevelQuestions array and options array and read the users answers and display if it's correct or incorrct by using the answers array. Play a sound if it's incorrect. Go to next question if correct. While the user is only allowed to type 1, 2, 3, 4.
            Display how much the user answered correctly and is only allowed to move to MediumLevel if only scored 80%. If not passed user can try again or Exit.
            If the user has passed or has chosen Level 2. Display mediumLevelQuestions array and options array and read the users answers and display if it's correct or incorrct by using answers array. Play a sound if it's incorrect. Go to next question if correct. While the user is only allowed to type 1, 2, 3, 4.
            Display how much the user answered correctly and is only allowed to move to ExtremeLevel if only scored 70%. If not passed user can try again or Exit.
            If the user has passed or has chosen Level 3. Display extremeLevelQuestions and options and read the users answers and display if it's correct or incorrct. Play a sound if it's incorrect. Go to next question if correct. While the user is only allowed to type 1, 2, 3, 4.
            Display how much the user answered correctly and display Congrats Message. If not scored 70% user can try again or exit the program. If passed user can go back to MainMenu to try the quiz again.
            */

            MainMenu(); // method MainMenu
            static void MainMenu()
            {
                string chooseLevel;
                Console.WriteLine("========================================================");
                Console.WriteLine("Kia Ora And Welcome To My Te Reo Maori Quiz. \nThere Will Be 30 Questions In This Quiz.\n10 Questions Per Level."); // Welcome Message
                Console.WriteLine("========================================================");
                Console.WriteLine("\nEnter Any Key To Continue! Or Enter E To Exit!\n");
                Console.WriteLine("========================================================");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                if (Console.ReadLine().ToLower() == "e") // if statement if the user wants to continue or exit.
                {
                    Console.WriteLine("\nGoodBye");
                    Environment.Exit(0);
                }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                Console.WriteLine("========================================================"); 
                Console.WriteLine("ENTER 1 FOR BASIC LEVEL.\n\nENTER 2 FOR MEDIUM LEVEL.\n\nENTER 3 FOR EXTREME LEVEL."); // prompts user for a level
                Console.WriteLine("========================================================");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                chooseLevel = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                switch (chooseLevel) // switch statement for the levels then the mainmenu will be cleared
                {
                    case "1":
                        Console.Clear();
                        BasicLevel();
                        break;
                    case "2":
                        Console.Clear();
                        MediumLevel();
                        break;
                    case "3":
                        Console.Clear();
                        ExtremeLevel();
                        break;
                    default:
                        Console.WriteLine("PLEASE ENTER A VALID OPTION:\n");
                        MainMenu();
                        break;
                }

            }

            static void BasicLevel() // method BasicLevel which has been chosen by user
            {
                // declare variables
                int score = 0;
                int question = 0;
                int userInput;

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Know Are Answering Basic Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: "); 
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ReadLine();
                Console.WriteLine("========================================================\n");
                do
                {
                    string[] basicLevelQuestions = new string[7] { "Question 1:\nWhat is Guardian in Te Reo Maori:", "Question 2:\nWhat is Prayer in Te Reo Maori:", "Question 3:\nWhat is Sovereighty in Te Reo Maori:", "Question 4:\nWhat is Crying in Te Reo Maori:", "Question 5:\nWhat is Ancestry in Te Reo Maori:", "Question 6:\nWhat is Embarrassed in Te Reo Maori:", "Question 7:\nWhat is Treasure in Te Reo Maori:" };
                    string[] options = new string[7] { "\n1) Tane\n2) Kaitiaki\n3) Taniwha\n4) Ruru", "\n1) Karakia\n2) Rongoa\n3) Raupo\n4) Raupatu", "\n1) Rangatahi\n2) Rangatira\n3) Rahui\n4) Rangatiratanga", "\n1) Porohe\n2) Tangihanga\n3) Piharau\n4) Patiki", "\n1) Panui\n2) Pa Tuna\n3) Whakapapa\n4) Ngawha", "\n1) Whakama\n2) Wairua\n3) Korowai\n4) Korimako", "\n1) Korero\n2) Kokopu\n3) Tangi\n4) Taonga" };
                    int[] basicLevelAnswers = new int[7] { 2, 1, 4, 2, 3, 1, 4 };

                    Console.WriteLine($"{basicLevelQuestions[question]} {options[question]}\n");
                    while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0 || userInput >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
                    {
                        Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
                    }
                    if (userInput == basicLevelAnswers[question])
                    {
                        Console.WriteLine("\nCorrect Answer!\n");
                        score++;
                        question++;
                    }
                    else if (userInput != basicLevelAnswers[question])
                    {
                        Console.WriteLine("\nIncorrect Answer!\n");
                        Console.Beep(350, 600);
                        question++;
                    }
                    Console.WriteLine("==========================================================\n");
                }
                while (question < 5);
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"\nYour Total Score Was {score}/10\n");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                if (score == 5)
                {
                    Console.WriteLine("\nCongratulations On Passing This Level!\n");
                    Console.WriteLine("==========================================================\n" +
                    "\nEnter Y To Continue On To Next Level:\n\nEnter Any Other Key To EXIT:\n");
                    Console.WriteLine("========================================================");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Console.Clear();
                        MediumLevel();
                    }
                    else
                    {
                        Console.WriteLine("GoodBye!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
                else
                {
                    Console.WriteLine("\nUnfortunately, You Have Not Passed This Level!\nBetter Luck Next Time!\n");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("\nPress Y To Try Again:\n\nEnter Any Other Key To EXIT:\n");
                    Console.WriteLine("==========================================================");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Console.Clear();
                        BasicLevel();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }

            }

            static void MediumLevel() // method Medium level which has either been chosen by the user or the user passed the previous level
            {
                // declare variables
                int score = 0;
                int question = 0;
                int userInput;

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Now Are Answering Medium Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ReadLine();
                Console.WriteLine("========================================================\n");
                do
                {
                    string[] mediumLevelQuestions = new string[7] { "Question 1:\nWhat is Guardian in Te Reo Maori:", "Question 2:\nWhat is Prayer in Te Reo Maori:", "Question 3:\nWhat is Sovereighty in Te Reo Maori:", "Question 4:\nWhat is Crying in Te Reo Maori:", "Question 5:\nWhat is Ancestry in Te Reo Maori:", "Question 6:\nWhat is Embarrassed in Te Reo Maori:", "Question 7:\nWhat is Treasure in Te Reo Maori:" };
                    string[] options = new string[7] { "\n1) Tane\n2) Kaitiaki\n3) Taniwha\n4) Ruru", "\n1) Karakia\n2) Rongoa\n3) Raupo\n4) Raupatu", "\n1) Rangatahi\n2) Rangatira\n3) Rahui\n4) Rangatiratanga", "\n1) Porohe\n2) Tangihanga\n3) Piharau\n4) Patiki", "\n1) Panui\n2) Pa Tuna\n3) Whakapapa\n4) Ngawha", "\n1) Whakama\n2) Wairua\n3) Korowai\n4) Korimako", "\n1) Korero\n2) Kokopu\n3) Tangi\n4) Taonga" };
                    int[] mediumLevelAnswers = new int[7] { 2, 1, 4, 2, 3, 1, 4 };

                    Console.WriteLine($"{mediumLevelQuestions[question]} {options[question]}\n");
                    while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0 || userInput >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
                    {
                        Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
                    }
                    if (userInput == mediumLevelAnswers[question])
                    {
                        Console.WriteLine("\nCorrect Answer!\n");
                        score++;
                        question++;
                    }
                    else if (userInput != mediumLevelAnswers[question])
                    {
                        Console.WriteLine("\nIncorrect Answer!\n");
                        Console.Beep(350, 600);
                        question++;
                    }
                    Console.WriteLine("==========================================================\n");
                }
                while (question < 5);
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"\nYour Total Score Was {score}/10\n");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                if (score == 5)
                {
                    Console.WriteLine("\nCongratulations On Passing This Level!\n");
                    Console.WriteLine("==========================================================\n" +
                    "\nEnter Y To Continue On To Final Level:\n\nEnter Any Other Key To EXIT:\n");
                    Console.WriteLine("========================================================");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Console.Clear();
                        ExtremeLevel();
                    }
                    else
                    {
                        Console.WriteLine("GoodBye!");
                        Environment.Exit(0);
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
                else
                {
                    Console.WriteLine("\nUnfortunately, You Have Not Passed This Level!\nBetter Luck Next Time!\n");
                    Console.WriteLine("==========================================================");
                    Console.WriteLine("\nPress Y To Try Again:\n\nEnter Any Other Key To EXIT:\n");
                    Console.WriteLine("==========================================================");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Console.Clear();
                        MediumLevel();
                    }
                    else
                    {
                        Console.WriteLine("GoodBye!");
                        Environment.Exit(0);
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }

            static void ExtremeLevel() // method ExtremeLevel which has either been chosen by the user or the user passed the previous 2 levels
            {
                int score = 0;
                int question = 0;
                int userInput;

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Now Are Answering Extreme Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ReadLine();
                Console.WriteLine("========================================================");
                do
                {
                    string[] extremeLevelQuestions = new string[7] { "Question 1:\nWhat is Guardian in Te Reo Maori:", "Question 2:\nWhat is Prayer in Te Reo Maori:", "Question 3:\nWhat is Sovereighty in Te Reo Maori:", "Question 4:\nWhat is Crying in Te Reo Maori:", "Question 5:\nWhat is Ancestry in Te Reo Maori:", "Question 6:\nWhat is Embarrassed in Te Reo Maori:", "Question 7:\nWhat is Treasure in Te Reo Maori:" };
                    string[] options = new string[7] { "\n1) Tane\n2) Kaitiaki\n3) Taniwha\n4) Ruru", "\n1) Karakia\n2) Rongoa\n3) Raupo\n4) Raupatu", "\n1) Rangatahi\n2) Rangatira\n3) Rahui\n4) Rangatiratanga", "\n1) Porohe\n2) Tangihanga\n3) Piharau\n4) Patiki", "\n1) Panui\n2) Pa Tuna\n3) Whakapapa\n4) Ngawha", "\n1) Whakama\n2) Wairua\n3) Korowai\n4) Korimako", "\n1) Korero\n2) Kokopu\n3) Tangi\n4) Taonga" };
                    int[] extremeLevelAnswers = new int[7] { 2, 1, 4, 2, 3, 1, 4 };

                    Console.WriteLine($"{extremeLevelQuestions[question]} {options[question]}\n");
                    while (!int.TryParse(Console.ReadLine(), out userInput) || userInput <= 0 || userInput >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
                    {
                        Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
                    }
                    if (userInput == extremeLevelAnswers[question])
                    {
                        Console.WriteLine("\nCorrect Answer!\n");
                        score++;
                        question++;
                    }
                    else if (userInput != extremeLevelAnswers[question])
                    {
                        Console.WriteLine("\nIncorrect Answer!\n");
                        Console.Beep(350, 600);
                        question++;
                    }
                    Console.WriteLine("==========================================================\n");
                }
                while (question < 5);
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"\nYour Total Score Was {score}/10\n");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                if (score == 5)
                {
                    Console.WriteLine("\nCongratulations For Completing My Quiz!\nWould You Like To Play Again!\n");
                    Console.WriteLine("==========================================================" +
                    "\nEnter Y To Go Back To Main Menu:\n\nEnter Any Other Key To EXIT!\n");
                    Console.WriteLine("==========================================================\n");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Console.Clear();
                        MainMenu();
                    }
                    else
                    {
                        Console.WriteLine("GoodBye!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
                else
                {
                    Console.WriteLine("\nUnfortunately, You Have Not Passed This Level!\nBetter Luck Next Time!\n");
                    Console.WriteLine("==========================================================\n");
                    Console.WriteLine("\nPress Y To Try Again:\n\nEnter Any Other Key To EXIT:\n");
                    Console.WriteLine("==========================================================");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    if (Console.ReadLine().ToLower() == "y")
                    {
                        Console.Clear();
                        ExtremeLevel();
                    }
                    else
                    {
                        Console.WriteLine("GoodBye!");
                        Environment.Exit(0); 
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }
            }
        }
    }
}