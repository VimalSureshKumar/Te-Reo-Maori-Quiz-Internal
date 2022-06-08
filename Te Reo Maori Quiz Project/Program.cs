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
            This program is a 30 question vocab quiz on Te Reo Maori.
            Use System and System.Collections.Generic.
            Have a Class called MaoriQuiz.
            Use static void Main with string parameters with args.
            Include MainMenu Method with string choose level variable. Display Welcome Message. Display the levels with switch statements. Switch statements redirects to the level chosen by user and clears MainMenu.
            If user has chosen Basic Level. Display basicLevelQuestions array and options array and read the users answers and display if it's correct or incorrct by using the answers array. Play a sound if it's incorrect. Go to next question if correct. While the user is only allowed to type 1, 2, 3, 4.
            Display how much the user answered correctly and is only allowed to move to MediumLevel if only scored 70%. If not passed user can try again or Exit.
            If the user has passed Basic Level or has chosen Medium Levl. Display mediumLevelQuestions array and options array and read the users answers and display if it's correct or incorrct by using answers array. Play a sound if it's incorrect. Go to next question if correct. While the user is only allowed to type 1, 2, 3, 4.
            Display how much the user answered correctly and is only allowed to move to Extreme Level if only scored 70%. If not passed user can try again or Exit.
            If the user has passed Medium Levl or has chosen Extreme Level. Display extremeLevelQuestions and options and read the users answers and display if it's correct or incorrct. Play a sound if it's incorrect. Go to next question if correct. While the user is only allowed to type 1, 2, 3, 4.
            Display how much the user answered correctly and display congrats on completing my quiz. If not scored 70% user can try again or exit the program. If passed user can go back to MainMenu to try the quiz again.
            */

            MainMenu(); // calls method MainMenu
            static void MainMenu() // MainMenu Method
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
                    Console.WriteLine("\nGoodBye!");
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

            static void BasicLevel() // method BasicLevel 
            {
                // declare variables
                int score = 0;
                int question = 0;
                int userInput;

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Are Answering Basic Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: "); 
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ReadLine();
                Console.WriteLine("========================================================\n");
                do
                {
                    string[] basicLevelQuestions = new string[10] { "Question 1:\nWhat's Hello in Te Reo Maori:", "Question 2:\nWhat's Goodbye in Te Reo Maori:", "Question 3:\nWhat's School in Te Reo Maori:", "Question 4:\nWhat's Grandparents in Te Reo Maori:", "Question 5:\nWhat's Father in Te Reo Maori:", "Question 6:\nWhat's Sister in Te Reo Maori:", "Question 7:\nWhat's Family in Te Reo Maori:", "Question 8:\nWhat's Dog in Te Reo Maori:", "Question 9:\nWhat's House in Te Reo Maori:", "Question 10:\nWhat's Fish In Te Reo Maori:" };
                    string[] options = new string[10] { "\n1) Aroha\n2) Kia Ora\n3) Taniwha\n4) Whero", "\n1) Ka Kite\n2) Tena Koe\n3) Nga Mihi\n4) Raupatu", "\n1) Kuri\n2) Rori\n3) Rahui\n4) Kura", "\n1) Teina\n2) Tipuna\n3) Tuahine\n4) Tungane", "\n1) Tama\n2) Wahine\n3) Matua\n4) Koroua", "\n1) Teina\n2) Tuakana\n3) Kuia\n4) Matamua", "\n1) Tamariki\n2) Tane\n3) Whaea\n4) Whanau", "\n1) Manu\n2) Kuri\n3) Rapeti\n4) Ngeru", "\n1) Pakitara\n2) Kuaha\n3) Whare\n4) Moenga", "\n1) Ika\n2) Kiore Nui\n3) Kiore Iti\n4) Ika Koura" };
                    int[] basicLevelAnswers = new int[10] { 2, 1, 4, 2, 3, 1, 4 , 2, 3, 1 };

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
                    Console.WriteLine("========================================================\n");
                }
                while (question < 10);
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"\nYour Total Score Was {score}/10\n");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                if (score >= 7)
                {
                    Console.WriteLine("\nCongratulations On Passing This Level!\n");
                    Console.WriteLine("========================================================\n" +
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
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\nPress Y To Try Again:\n\nEnter Any Other Key To EXIT:\n");
                    Console.WriteLine("========================================================");
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

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Are Answering Medium Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ReadLine();
                Console.WriteLine("========================================================\n");
                do
                {
                    string[] mediumLevelQuestions = new string[10] { "Question 1:\nWhat's Beautiful in Te Reo Maori:", "Question 2:\nWhat's Milk in Te Reo Maori:", "Question 3:\nWhat's Mathematics in Te Reo Maori:", "Question 4:\nWhat's Play Ground in Te Reo Maori:", "Question 5:\nWhat's High School in Te Reo Maori:", "Question 6:\nWhat's Television in Te Reo Maori:", "Question 7:\nWhat's Vegetables in Te Reo Maori:", "Question 8:\nWhat's Utensils in Te Reo Maori:", "Question 9:\nWhat's Fruit in Te Reo Maori:", "Question 10:\nWhat's Drink in Te Reo Maori:" };
                    string[] options = new string[10] { "\n1) Poraka \n2) Kaitiaki\n3) Taniwha\n4) Ruru", "\n1) Hinu\n2) Raupatu\n3) Raupo\n4) Miraka", "\n1) Papama\n2) Pangarau\n3) Ropu Ako\n4) Kaupapa ", "\n1) Kaiako\n2) Papa Takakaro\n3) Pukapuka\n4) Ruri", "\n1) Kura Tuarua\n2) Kura Naenganui\n3) Kura Tuatahi\n4) Karaka", "\n1) Kakahu\n2) Wharekai\n3) Wharepukapuka\n4) Ponaka Whakaata", "\n1) Hamipeka\n2) Kumara\n3) Huawhenua\n4) Kapeti", "\n1) Taputapu\n2) Arani\n3) Hehei\n4) Kotakota Riwai", "\n1) Panana\n2) Huarakau\n3) Heki\n4) Paukena", "\n1) Pereti\n2) Pihikete\n3) Paraoa\n4) Inu" };
                    int[] mediumLevelAnswers = new int[10] { 3, 4, 2, 2, 1, 4, 3, 1, 2, 4 };

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
                    Console.WriteLine("========================================================\n");
                }
                while (question < 10);
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"\nYour Total Score Was {score}/10\n");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                if (score >= 7)
                {
                    Console.WriteLine("\nCongratulations On Passing This Level!\n");
                    Console.WriteLine("========================================================\n" +
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
                    Console.WriteLine("========================================================");
                    Console.WriteLine("\nPress Y To Try Again:\n\nEnter Any Other Key To EXIT:\n");
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

                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine("You Are Answering Extreme Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ReadLine();
                Console.WriteLine("========================================================");
                do
                {
                    string[] extremeLevelQuestions = new string[10] { "Question 1:\nWhat's Seafood in Te Reo Maori:", "Question 2:\nWhat's Church in Te Reo Maori:", "Question 3:\nWhat's Entertainment in Te Reo Maori:", "Question 4:\nWhat's Sports in Te Reo Maori:", "Question 5:\nWhat's Joyful in Te Reo Maori:", "Question 6:\nWhat's Summer in Te Reo Maori:", "Question 7:\nWhat's Laughing in Te Reo Maori:", "Question 8:\nWhat's Watching in Te Reo Maori:", "Question 9:\nWhat's Quater in Te Reo Maori:", "Question 10:\nWhat's Quiz in Te Reo Maori:" };
                    string[] options = new string[10] { "\n1) Kai Moana\n2) Whakata\n3) Painaina\n4) Hakari ", "\n1) Hararei\n2) Kauhoe\n3) Whare Karakia\n4) Tamanuitera", "\n1) Painaina\n2) Whakata\n3) Manuhiri\n4) Whakangahau", "\n1) Perehame\n2) Karekare\n3) Marino\n4) Hokinakina", "\n1) Tauera\n2) Whiti\n3) Harikoakoa \n4) Tahamoana", "\n1) Ramati \n2) Makariri\n3) Tatoto\n4) Takaro", "\n1) Tuhitahi\n2) Katakata\n3) Matakitaki\n4) Maranga", "\n1) Pikiniki\n2) Ahua\n3) Mahana\n4) Matakitaki", "\n1) Huawha\n2) Tatua\n3) Tarau Rao\n4) Panekoti", "\n1) Tauira\n2) Pataitai\n3) Putaiao\n4) Tikana-A-Iwi" };
                    int[] extremeLevelAnswers = new int[10] { 1, 3, 4, 4, 3, 1, 2, 4, 1, 2 };

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
                    Console.WriteLine("========================================================\n");
                }
                while (question < 10);
                {
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine($"\nYour Total Score Was {score}/10\n");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                }
                if (score >= 7)
                {
                    Console.WriteLine("\nCongratulations For Completing My Quiz!\nWould You Like To Play Again!\n");
                    Console.WriteLine("========================================================" +
                    "\nEnter Y To Go Back To Main Menu:\n\nEnter Any Other Key To EXIT!\n");
                    Console.WriteLine("========================================================\n");
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
                    Console.WriteLine("========================================================\n");
                    Console.WriteLine("\nPress Y To Try Again:\n\nEnter Any Other Key To EXIT:\n");
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
            }
        }
    }
}