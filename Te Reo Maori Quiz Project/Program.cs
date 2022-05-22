using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TeReoMaoriQuizProject
{
    Menu();
    MediumLevel();
    ExtremeLevel();
    class MaoriQuiz
    {
        static void Main(string[] args)
        {

            // Psudo Code
            /* This program is a 30 Question Quiz On Te Reo Maori. 
             Use System, Class = MainClass, Public static void Main() = Can Be Called Without Object. 
             Add And Declare Int Variables For Option, Score And (Question = Answer).
             Add An Introduction Message. 
             10 Questions On Basic Level And Add Basic Level Message. 
             Add A While Loop To Each Question So The User Is Only Allowed To Type (1, 2, 3, 4). 
             Have If Statement For Correct Answer And Add 1 To The Score, Else Display Incorrect Answer If The User Dosen't Input The Right Answer To The Question. 
             10 Questions On Medium Level And Add Medium Level Message.
             Add A While Loop To Each Question So The User Is Only Allowed To Type (1, 2, 3, 4). 
             Have If Statement For Correct Answer And Add 1 To The Score, Else Display Incorrect Answer If The User Dosen't Input The Right Answer To The Question.
             10 Questions On Extreme Level And Add Extreme Level Message.
             Add A While Loop To Each Question So The User Is Only Allowed To Type (1, 2, 3, 4). 
             Have If Statement For Correct Answer And Add 1 To The Score, Else Display Incorrect Answer If The User Dosen't Input The Right Answer To The Question.
             Tally Up All The Correct Answers Out Of 20.
             Display End Message
            */

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


            // Add Array For Each Level To Replace Variables Into Shorter Length

            // Declare Variables
            char levelOption;
            char userOption;
            int option;
            int score = 0;
            int question1 = 2;
            int question2 = 1;
            int question2Ans2 = 4;
            int question3 = 1;
            int question4 = 3;
            int question5 = 2;
            int question6 = 2;
            int question7 = 1;
            int question8 = 4;
            int question9 = 2;
            int question10 = 3;
            int question11 = 1;
            int question12 = 4;
            int question13 = 3;
            int question14 = 1;
            int question15 = 4;
            int question16 = 3;
            int question17 = 2;
            int question18 = 4;
            int question19 = 1;
            int question20 = 3;

            static void Menu() { }
            // Introduction
            Console.WriteLine("========================================================");
            Console.WriteLine("Kia Ora And Welcome To My Te Reo Maori Quiz.\nThere Will Be 20 Questions That You Will Be Answering." +
            "\nQuestion 1-5 Basic level.\nQuetions 6-12 Medium level.\nQuestion 13-20 Extreme level.\n");
            Console.WriteLine("SELECT WHICH LEVEL YOU WANT TO DO:\nPress 1 For BASIC LEVEL.\nPress 2 FOR MEDIUM LEVEL.\nPress 3 FOR EXTREME LEVEL.");
            Console.WriteLine("========================================================");

            // Basic Level Questions
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("You Know Are Answering Basic Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();
            Console.WriteLine("=========================================================");
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

            // Medium Level Questions & Message
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("You Now Are Answering Medium Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();
            Console.WriteLine("=========================================================");
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
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("You Now Are Answering Extreme Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();
            Console.WriteLine("=========================================================");
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

        }
    }
}