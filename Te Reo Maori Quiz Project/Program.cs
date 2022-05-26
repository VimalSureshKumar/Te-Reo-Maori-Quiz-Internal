using System;
using System.Collections.Generic;

namespace TeReoMaoriQuizProject
{
    class MaoriQuiz
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            /* Psudo Code
            This program is a 30 question quiz on Te Reo Maori.
            Use System and System and System.Collections.Generic.
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


            MainMenu();
            static void MainMenu()
            {
                string chooseLevel;
                Console.WriteLine("========================================================");
                Console.WriteLine("Kia Ora And Welcome To My Te Reo Maori Quiz. \nThere Will Be 30 Questions In This Quiz.\n10 Questions Per Level.");
                Console.WriteLine("========================================================");
                Console.WriteLine("\nEnter Any Key To Continue! Or Enter E To Exit!\n");
                Console.WriteLine("========================================================");
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                if (Console.ReadLine().ToLower() == "e")
                {
                    Console.WriteLine("\nGoodBye");
                    Environment.Exit(0);
                }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                Console.WriteLine("========================================================");
                Console.WriteLine("ENTER 1 FOR BASIC LEVEL.\n\nENTER 2 FOR MEDIUM LEVEL.\n\nENTER 3 FOR EXTREME LEVEL.");
                Console.WriteLine("========================================================");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                chooseLevel = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                switch (chooseLevel)
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

            static void BasicLevel()
            {
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
                        ExtremeLevel();
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                }

            }

            static void MediumLevel()
            {
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

            static void ExtremeLevel()
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
                    Console.WriteLine("\nUnfortunately, You Have Not Passed This Level!\nBetter Luck Next Time!");
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

// Feedback 
// Ashin: Add music/sound for incorrect answer.
// Thisara: Give second chance for 5 times and show what answers was wrong.
// Gilbert: The overall code is to my knowledge unbreakable and entering non answers leaves you with a message saying to reenter a number - between  1 - 4.I think it would be nice to only give the extreme level questions to anyone who has atleast
// scored 50 percent this would make it like levels in a game where if you fail level 1 you would not go onto level two. Overall the code is effective but plain and does not have a risk factor or different types of questions that would make the
// quiz more engaging instead of the same type of questions over and over, These questions could be tue or false questions or any other type of questions. That is my personal opinion.
// Teacher: There is no loop implemented. Give the option to the user to continue with the program. Use any looping concept. 
// Implement at least one method. You can create a method to the main menu. You might want to add some more questions and create different levels. Give options to the user to select the levels.Each level can be called by a method.  
// Perform the testing and include this in your AS91884 standard write-up. 
// Try and add some spacing between questions. 
// Try and implement a method to calculate the scores with a return type. 


/*
            Console.WriteLine("Question 1:\nWhat is Ocean in Te Reo Maori:\n1) Ocean\n2) Moana\n3) Awa\n4) River" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) Moana is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question1 == option) // This Statement Will Display Correct Answer If The User Inputed 2 And Adds 1 Else The User Doesn't Input 2 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 2:\nWhat is Mother in Te Reo Maori:\n1) Whaea\n2) Whanau\n3) Tamaraki\n4) Mama" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) and 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question2 == option || question2Ans2 == option) // This Statement Will Display Correct Answer If The User Inputed 1 Or 4 And Adds 1 Else The User Doesn't Input 1 Or 4 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
                Console.ReadLine();
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 3:\nWhat is Children in Te Reo Maori:\n1) Tamaraki \n2) Children \n3) Tena Koe \n4) Ka Kite" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question3 == option) // This Statement Will Display Correct Answer If The User Inputed 1 And Adds 1 Else The User Doesn't Input 1 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 4:\nWhat is Good Morning in Te Reo Maori:\n1) Ahiahi Pai \n2) Kia Ora \n3) Morena \n4) Ra Pai" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question4 == option) // This Statement Will Display Correct Answer If The User Inputed 3 And Adds 1 Else The User Doesn't Input 3 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 5:\nWhat is School in Te Reo Maori:\n1) Whare\n2) Kura\n3) Hapu\n4) Tane" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) is correct answer  
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question5 == option) // This Statement Will Display Correct Answer If The User Inputed 2 And Adds 1 Else The User Doesn't Input 2 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }

            Console.WriteLine("Question 6:\nWhat is Guardian in Te Reo Maori:\n1) Tane\n2) Kaitiaki\n3) Taniwha\n4) Ruru" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question6 == option) // This Statement Will Display Correct Answer If The User Inputed 2 And Adds 1 Else The User Doesn't Input 2 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 7:\nWhat is Prayer in Te Reo Maori:\n1) Karakia\n2) Rongoa\n3) Raupo\n4) Raupatu" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question7 == option) // This Statement Will Display Correct Answer If The User Inputed 1 And Adds 1 Else The User Doesn't Input 1 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 8:\nWhat is Sovereighty in Te Reo Maori:\n1) Rangatahi\n2) Rangatira\n3) Rahui\n4) Rangatiratanga" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question8 == option) // This Statement Will Display Correct Answer If The User Inputed 4 And Adds 1 Else The User Doesn't Input 4 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 9:\nWhat is Crying in Te Reo Maori:\n1) Porohe\n2) Tangihanga\n3) Piharau\n4) Patiki" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question9 == option) // This Statement Will Display Correct Answer If The User Inputed 2 And Adds 1 Else The User Doesn't Input 2 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 10:\nWhat is Ancestry in Te Reo Maori:\n1) Panui\n2) Pa Tuna\n3) Whakapapa\n4) Ngawha" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question10 == option) // This Statement Will Display Correct Answer If The User Inputed 3 And Adds 1 Else The User Doesn't Input 3 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 11:\nWhat is Embarrassed in Te Reo Maori:\n1) Whakama\n2) Wairua\n3) Korowai\n4) Korimako" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question11 == option) // This Statement Will Display Correct Answer If The User Inputed 1 And Adds 1 Else The User Doesn't Input 1 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 12:\nWhat is Treasure in Te Reo Maori:\n1) Korero\n2) Kokopu\n3) Tangi\n4) Taonga" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question12 == option) // This Statement Will Display Correct Answer If The User Inputed 4 And Adds 1 Else The User Doesn't Input 4 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }

            // Extreme Level Questions & Message & Message
            Console.WriteLine("Question 13:\nWhat is Circle in Te Reo Maori:\n1) Pahu\n2) Ata Toro\n3) Porohita\n4) Meke" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question13 == option) // This Statement Will Display Correct Answer If The User Inputed 3 And Adds 1 Else The User Doesn't Input 3 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 14:\nWhat is Shiver in Te Reo Maori:\n1) Tungawiri\n2) Whakaoreone\n3) Totohu\n4) Kauhuri" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question14 == option) // This Statement Will Display Correct Answer If The User Inputed 1 And Adds 1 Else The User Doesn't Input 1 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 15:\nWhat is Slide in Te Reo Maori:\n1) Hinga\n2) Ngoki\n3) Ruru\n4) Koneke" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question15 == option) // This Statement Will Display Correct Answer If The User Inputed 4 And Adds 1 Else The User Doesn't Input 4 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 16:\nWhat is Thrust in Te Reo Maori:\n1) Hinga\n2) Takahi\n3) Kokiri\n4) Matike" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question16 == option) // This Statement Will Display Correct Answer If The User Inputed 3 And Adds 1 Else The User Doesn't Input 3 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 17:\nWhat is Bounce in Te Reo Maori:\n1) Matike\n2) Tupana\n3) Mawewe\n4) Takapori" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question17 == option) // This Statement Will Display Correct Answer If The User Inputed 2 And Adds 1 Else The User Doesn't Input 2 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 18:\nWhat is Freeze in Te Reo Maori:\n1) Wheta\n2) Iriri\n3) E Peke\n4) Kia Mau" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question18 == option) // This Statement Will Display Correct Answer If The User Inputed 4 And Adds 1 Else The User Doesn't Input 4 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 19:\nWhat is Plane in Te Reo Maori:\n1) Wakarere\n2) Ruru\n3) Huri\n4) Pehi" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question19 == option) // This Statement Will Display Correct Answer If The User Inputed 1 And Adds 1 Else The User Doesn't Input 1 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 20:\nWhat is Shimmy in Te Reo Maori:\n1) Hurokurku\n2) E Heke Ki Raro\n3) Titakataka\n4) Whakarewa" +
            "\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter (1, 2, 3, 4)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            if (question20 == option) // This Statement Will Display Correct Answer If The User Inputed 3 And Adds 1 Else The User Doesn't Input 3 It Will Display Incorrect Answer 
            {
                Console.WriteLine("Correct Answer!");
                score++;
            }
            else
            {
                Console.WriteLine("Incorrect Answer!");
            }
            // Final Tally Of Score 
            Console.WriteLine("=================================================");
            Console.WriteLine("Your Total Amount of Correct Questions Answered: " + score + ("/20")); // This Will Add Up All The Correct Questions Out Of 20
            Console.WriteLine("=================================================");
            // Finished Quiz Message
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Congratulations You Have Completed My Te Reo Maori Quiz I Hope You Have Learnt Something About Te Re Maori." +
            "\nPRESS ENTER TO EXIT: "); // End Message
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();
            Console.Clear();
            */