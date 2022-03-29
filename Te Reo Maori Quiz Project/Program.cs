
{
    {
        {
            // declare variable
            int option;
            int score = 0;
            // Introduction/ Menu
            Console.WriteLine("========================================================");
            Console.WriteLine("Kia Ora And Welcome To My Te Reo Maori Quiz.\n\nThere Will Be 20 Questions That You Will Be Answering.\nQuestion 1-5 Basic level.\nQuetions 6-12 Medium level.\nQuestion 15-20 Extreme level. ");
            Console.WriteLine("========================================================");
            // menu options need to be added
            // if or switch statements.
            // loops and arrays for menu and maybe repeat code again.
            // methods for adding up correct scores.
            // Basic Level Questions
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("You Know Are Answering Basic Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 1:\nWhat is Ocean in Te Reo Maori:\n1) Ocean\n2) Moana\n3) Awa\n4) River\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) Moana is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5) // While Loop So The User Is Only Allowed to Enter 1, 2, 3, 4
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question1 = 2;
            if (question1 != 2)
            {
                Console.Write("Incorrect Answer");
                score = score++;
            }
            else if (question1 == 2)
            {
                Console.Write("Correct Answer!");
                score = score--;
            }
            Console.ReadLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 2:\nWhat is Mother in Te Reo Maori:\n1) Whaea\n2) Whanau\n3) Tamaraki\n4) Mama\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) and 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question2 = 1 + 4;
            if (question2 == 1 || question2 == 4)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            else if (question2 != 2 || question2 !=3)
            {
                Console.WriteLine("Incorrect Answer! ");

            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 3:\nWhat is Children in Te Reo Maori:\n1) Tamaraki \n2) Children \n3) Tena Koe \n4) Ka Kite \nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            int question3 = 1;
            if (question3 == 1)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 4:\nWhat is Good Morning in Te Reo Maori:\n1) Ahiahi Pai \n2) Kia Ora \n3) Morena \n4) Ra Pai \nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            int question4 = 3;
            if (question4 == 3)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 5:\nWhat is School in Te Reo Maori:\n1) Whare\n2) Kura\n3) Hapu\n4) Tane\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) is correct answer  
            int question5 = 2;
            if (question5 == 2)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
                        while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }

            // Medium Level Questions
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("You Now Are Answering Medium Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();

            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 6:\nWhat is Guardian in Te Reo Maori:\n1) Tane\n2) Kaitiaki\n3) Taniwha\n4) Ruru\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question6 = 2;
            if (question6 == 2)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 7:\nWhat is Prayer in Te Reo Maori:\n1) Karakia\n2) Rongoa\n3) Raupo\n4) Raupatu\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question7 = 1;
            if (question7 == 1)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 8:\nWhat is Sovereighty in Te Reo Maori:\n1) Rangatahi\n2) Rangatira\n3) Rahui\n4) Rangatiratanga\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question8 = 4;
            if (question8 == 4)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 9:\nWhat is Crying in Te Reo Maori:\n1) Porohe\n2) Tangihanga\n3) Piharau\n4) Patiki\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question9 = 2;
            if (question9 == 2)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 10:\nWhat is Ancestry in Te Reo Maori:\n1) Panui\n2) Pa Tuna\n3) Whakapapa\n4) Ngawha\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question10 = 3;
            if (question10 == 3)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 11:\nWhat is Embarrassed in Te Reo Maori:\n1) Whakama\n2) Wairua\n3) Korowai\n4) Korimako\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question11 = 1;
            if (question11 == 1)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 12:\nWhat is Treasure in Te Reo Maori:\n1) Korero\n2) Kokopu\n3) Tangi\n4) Taonga\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question12 = 4;
            if (question12 == 4)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            // Extreme Level Questions
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("You Now Are Answering Extreme Level Questions, Good Luck.\nPRESS ENTER TO CONTINUE: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 13:\nWhat is Circle in Te Reo Maori:\n1) Pahu\n2) Ata Toro\n3) Porohita\n4) Meke\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question13 = 3;
            if (question13 == 3)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 14:\nWhat is Shiver in Te Reo Maori:\n1) Tungawiri\n2) Whakaoreone\n3) Totohu\n4) Kauhuri\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question14 = 1;
            if (question14 == 1)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 15:\nWhat is Slide in Te Reo Maori:\n1) Hinga\n2) Ngoki\n3) Ruru\n4) Koneke\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question15 = 4;
            if (question15 == 4)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 16:\nWhat is Thrust in Te Reo Maori:\n1) Hinga\n2) Takahi\n3) Kokiri\n4) Matike\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question16 = 3;
            if (question16 == 3)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 17:\nWhat is Bounce in Te Reo Maori:\n1) Matike\n2) Tupana\n3) Mawewe\n4) Takapori\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 2) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question17 = 2;
            if (question17 == 2)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 18:\nWhat is Freeze in Te Reo Maori:\n1) Wheta\n2) Iriri\n3) E Peke\n4) Kia Mau\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 4) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question18 = 4;
            if (question18 == 4)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 19:\nWhat is in Te Reo Maori:\n1) Wakaoreore\n2) Ruru\n3) Huri\n4) Pehi\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 1) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question19 = 1;
            if (question19 == 1)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            Console.WriteLine("=========================================================");
            Console.WriteLine("Question 20:\nWhat is Shimmy in Te Reo Maori:\n1) Hurokurku\n2) E Heke Ki Raro\n3) Titakataka\n4) Whakarewa\nType either 1, 2, 3, 4 in Keybord, PRESS ENTER TO CONFIRM: "); // 3) is correct answer
            while (!int.TryParse(Console.ReadLine(), out option) || option <= 0 || option >= 5)
            {
                Console.Write("\nPlease Enter Either 1, 2, 3, 4 In The Keyboard: ");
            }
            int question20 = 3;
            if (question20 == 3)
            {
                Console.WriteLine("Correct Answer");
                score = score++;
            }
            // Final Tally Of Score 
            Console.WriteLine("=================================================");
            Console.WriteLine("Your Total Amount of Correct Questions Answered: ");
            Console.WriteLine("=================================================");
            // Finished Quiz Message
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Congratulations You Have Completed My Te Reo Maori Quiz I Hope You Have Learnt Something About Te Re Maori.\nPRESS ENTER TO EXIT: ");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
