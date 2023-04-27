namespace CMP1903M_A02_2223
{
    class Game
    {
        Format format = new Format();  //Creates a new instance of the Format class
        Messages messages = new Messages();  //Creates a new instance of the Welcome class

        public void run(int difficulty)
        {
            bool playing = true;
            int i = 0;

            while (playing)
            {

                messages.questionNum(i);

                string card1 = format.dealOne(); 

                string[] card1arr = card1.Split(",");

                messages.suit(1, card1arr[0]);
                messages.value(1, card1arr[1]);

                switch (card1arr[1])
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

                int val1 = Convert.ToInt32(card1arr[1]);

                messages.val(1, val1);

                string card2 = format.dealOne(); 

                string[] card2arr = card2.Split(",");

                messages.suit(2, card2arr[0]);
                messages.value(2, card2arr[1]);

                switch (card2arr[0])
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

                messages.op(card2arr[0]);

                string card3 = format.dealOne(); 

                string[] card3arr = card3.Split(",");

                messages.suit(3, card3arr[0]);
                messages.value(3, card3arr[1]);

                switch (card3arr[1])
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

                int val2 = Convert.ToInt32(card3arr[1]);

                messages.val(2, val2);

                int val3 = 0;

                string[] card4arr = new string[2];

                Console.WriteLine(card4arr[0]);

                if (difficulty == 2)
                {
                    string card4 = format.dealOne(); 

                    card4arr = card4.Split(",");

                    messages.suit(4, card4arr[0]);
                    messages.value(4, card4arr[1]);

                    switch (card4arr[0])
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

                    messages.op(card4arr[0]);

                    string card5 = format.dealOne(); 

                    string[] card5arr = card5.Split(",");

                    messages.suit(5, card5arr[0]);
                    messages.value(5, card5arr[1]);

                    switch (card5arr[1])
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

                    val3 = Convert.ToInt32(card5arr[1]);

                    messages.val(5, val3);

                    messages.question(val1, card2arr[0], val2, card4arr[0], val3);
                }
                else
                {
                    messages.question(val1, card2arr[0], val2);
                }

                

                int answer = Convert.ToInt32(Console.ReadLine());

                messages.nextLn();

                int correctAnswer = 0;

                

                switch (card2arr[0])
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
                }

                switch (card4arr[0])
                {
                    case "+":
                        correctAnswer = correctAnswer + val3;
                        break;

                    case "-":
                        correctAnswer = correctAnswer - val3;
                        break;

                    case "*":
                        correctAnswer = correctAnswer * val3;
                        break;

                    case "/":
                        correctAnswer = correctAnswer / val3;
                        break;
                }

                
                if (answer == correctAnswer)
                {
                    messages.correct();
                }
                else
                {
                    messages.incorrect(correctAnswer, i);
                    playing = false;
                }

                i++;

            }
        }
    }
}