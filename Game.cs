namespace CMP1903M_A02_2223
{
    class Game
    {

        Format format = new Format();  //Creates a new instance of the Format class

        public void run(int difficulty, string name)  //Run method
        {
            bool playing = true;
            int i = 0;

            while (playing)  //While loop for playing the game
            {

                Messages.questionNum(i);  //Displays the question number

                string card1 = format.dealOne();  //Deals a card

                string[] card1arr = card1.Split(",");  //Splits the string into an array so that the suit and value can be displayed separately

                Messages.suit(1, card1arr[0]);  //Displays the suit of the card
                Messages.value(1, card1arr[1]);  //Displays the value of the card

                switch (card1arr[1])  //Switch statement for changing the value of the card to an integer
                {
                    case "Jack":
                        card1arr[1] = "11";
                        break;

                    case "Queen":
                        card1arr[1] = "12";
                        break;

                    case "King":
                        card1arr[1] = "13";
                        break;

                    case "Ace":
                        card1arr[1] = "14";
                        break;
                }

                int val1 = Convert.ToInt32(card1arr[1]);  //Converts the value of the card to an integer

                Messages.val(1, val1);  //Displays the value of the card as an integer

                string card2 = format.dealOne();  //Deals a card

                string[] card2arr = card2.Split(",");  //Splits the string into an array so that the suit and value can be displayed separately

                Messages.suit(2, card2arr[0]);  //Displays the suit of the card
                Messages.value(2, card2arr[1]);  //Displays the value of the card

                switch (card2arr[0])  //Switch statement for changing the suit of the card to a mathematical operator
                {
                    case "Hearts":
                        card2arr[0] = "+";
                        break;

                    case "Diamonds":
                        card2arr[0] = "-";
                        break;

                    case "Clubs":
                        card2arr[0] = "*";
                        break;

                    case "Spades":
                        card2arr[0] = "/";
                        break;
                }

                Messages.op(card2arr[0]);  //Displays the mathematical operator

                string card3 = format.dealOne();   //Deals a card

                string[] card3arr = card3.Split(",");  //Splits the string into an array so that the suit and value can be displayed separately

                Messages.suit(3, card3arr[0]);  //Displays the suit of the card
                Messages.value(3, card3arr[1]);  //Displays the value of the card

                switch (card3arr[1])  //Switch statement for changing the value of the card to an integer
                {
                    case "Jack":
                        card3arr[1] = "11";
                        break;

                    case "Queen":
                        card3arr[1] = "12";
                        break;

                    case "King":
                        card3arr[1] = "13";
                        break;

                    case "Ace":
                        card3arr[1] = "14";
                        break;
                }

                int val2 = Convert.ToInt32(card3arr[1]);  //Converts the value of the card to an integer

                Messages.val(2, val2);  //Displays the value of the card as an integer

                int val3 = 0;  //Initialises val3 so that it can be used later and if the difficulty is set to 1, it will not be used

                string[] card4arr = new string[2];  //Initialises card4arr so that it can be used later and if the difficulty is set to 1, it will not be used

                if (difficulty == 2)  //If statement for if the difficulty is set to 2 so that the game will deal another card and display it
                {
                    string card4 = format.dealOne();  //Deals a card

                    card4arr = card4.Split(",");  //Splits the string into an array so that the suit and value can be displayed separately

                    Messages.suit(4, card4arr[0]);  //Displays the suit of the card
                    Messages.value(4, card4arr[1]);  //Displays the value of the card

                    switch (card4arr[0])  //Switch statement for changing the suit of the card to a mathematical operator
                    {
                        case "Hearts":
                            card4arr[0] = "+";
                            break;

                        case "Diamonds":
                            card4arr[0] = "-";
                            break;

                        case "Clubs":
                            card4arr[0] = "*";
                            break;

                        case "Spades":
                            card4arr[0] = "/";
                            break;
                    }

                    Messages.op(card4arr[0]);  //Displays the mathematical operator

                    string card5 = format.dealOne();   //Deals a card

                    string[] card5arr = card5.Split(",");  //Splits the string into an array so that the suit and value can be displayed separately

                    Messages.suit(5, card5arr[0]);  //Displays the suit of the card
                    Messages.value(5, card5arr[1]);  //Displays the value of the card

                    switch (card5arr[1])  //Switch statement for changing the value of the card to an integer
                    {
                        case "Jack":
                            card5arr[1] = "11";
                            break;

                        case "Queen":
                            card5arr[1] = "12";
                            break;

                        case "King":
                            card5arr[1] = "13";
                            break;

                        case "Ace":
                            card5arr[1] = "14";
                            break;
                    }

                    val3 = Convert.ToInt32(card5arr[1]);  //Converts the value of the card to an integer

                    Messages.val(5, val3);  //Displays the value of the card as an integer

                    Messages.question(val1, card2arr[0], val2, card4arr[0], val3);  //Displays the question if the difficulty is set to 2
                }
                else
                {
                    Messages.question(val1, card2arr[0], val2);  //Displays the question if the difficulty is set to 1
                }

                

                int answer = Convert.ToInt32(Console.ReadLine());  //Gets the answer from the user

                Messages.nextLn();

                int correctAnswer = 0;  //Initialises correctAnswer so that it can be used later

                

                switch (card2arr[0] + card4arr[0])  //Switch statement for calculating the correct answer
                {
                    case "+":
                        correctAnswer = val1 + val2;
                        break;

                    case "-":
                        correctAnswer = val1 - val2;
                        break;

                    case "*":
                        correctAnswer = val1 * val2;
                        break;

                    case "/":
                        correctAnswer = val1 / val2;
                        break;

                    case "++":
                        correctAnswer = val1 + val2 + val3;
                        break;
                    
                    case "+-":  
                        correctAnswer = val1 + val2 - val3;
                        break;

                    case "+*":
                        correctAnswer = val1 + val2 * val3;
                        break;

                    case "+/":
                        correctAnswer = val1 + val2 / val3;
                        break;

                    case "-+":
                        correctAnswer = val1 - val2 + val3;
                        break;

                    case "--":  
                        correctAnswer = val1 - val2 - val3;
                        break;

                    case "-*":  
                        correctAnswer = val1 - val2 * val3;
                        break;  

                    case "-/":
                        correctAnswer = val1 - val2 / val3;
                        break;

                    case "*+":
                        correctAnswer = val1 * val2 + val3;
                        break;

                    case "*-":
                        correctAnswer = val1 * val2 - val3;
                        break;

                    case "**":
                        correctAnswer = val1 * val2 * val3;
                        break;

                    case "*/":
                        correctAnswer = val1 * val2 / val3;
                        break;

                    case "/+":
                        correctAnswer = val1 / val2 + val3;
                        break;

                    case "/-":
                        correctAnswer = val1 / val2 - val3;
                        break;

                    case "/*":  
                        correctAnswer = val1 / val2 * val3;
                        break;

                    case "//":
                        correctAnswer = val1 / val2 / val3;
                        break;
                }

                
                if (answer == correctAnswer)  //If statement for if the user gets the answer correct it displays a message and increases i by 1 so the score can be displayed at the end
                {
                    Messages.correct();
                    i++; 
                }
                else  //Else statement for if the user gets the answer incorrect
                {
                    Messages.incorrect(correctAnswer);
                    Messages.score(i);
                    WriteFile.write(name, i, difficulty);
                    playing = false;
                }
            }
        }
    }
}