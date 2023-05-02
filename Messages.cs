namespace CMP1903M_A02_2223
{

    class Messages  //Class for all the messages in the program so they can be easily changed, called, reused and so no other classes output messages
    {
        public static void welcome()
        {
            Console.WriteLine("Welcome to the card game\n");
        }

        public static void goodbye()
        {
          Console.WriteLine("Goodbye");
        }

        public static void menu()
        {
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Instructions");
            Console.WriteLine("3. Scoreboard");
            Console.WriteLine("4. Tutorial");
            Console.WriteLine("5. Shuffle The Deck");
            Console.WriteLine("6. New Pack");
            Console.WriteLine("7. Exit\n");
        }

        public static void instructions()
        {
            Console.WriteLine("Instructions\n");
            Console.WriteLine("The game will deal two cards from the deck and ask you to perform an operation on the two values");
            Console.WriteLine("The game will then ask you to enter the answer to the operation");
            Console.WriteLine("If you get the answer correct you will be awarded a point");
            Console.WriteLine("If you get the answer incorrect you will be shown the correct answer and your score");
            Console.WriteLine("All anwsers should be rounded to the nearest whole number\n");
        }

        public static void questionNum(int i)
        {
            Console.WriteLine("Question " + (i + 1) + "\n");
        }

        public static void suit(int num, string card)
        {
            Console.WriteLine("Card " + num + " Suit: " + card );
        }

        public static void value(int num, string card)
        {
            Console.WriteLine("Card " + num + " Value: " + card + "\n");
        }

        public static void val(int num, int val)
        {
            string word = "";

            switch (val)
            {
                case 1:
                    word = "first";
                    break;

                case 2:
                    word = "second";
                    break;

            }

            Console.WriteLine("So this means the " + word + " value will be " + val + "\n");

        }

        public static void op(string op)
        {
            Console.WriteLine("The operator will be " + op + "\n");
        }

        public static void question(int val1, string op, int val2)
        {
            Console.WriteLine("What is " + val1 + " " + op + " " + val2 + "?\n");
        }

        public static void question(int val1, string op1, int val2, string op2, int val3)
        {
            Console.WriteLine("What is " + val1 + " " + op1 + " " + val2 + " " + op2 + " " + val3 + "?\n");
        }

        public static void correct()
        {
            Console.WriteLine("Correct!\n");
        }

        public static void incorrect(int correctAnswer)
        {
            Console.WriteLine("Incorrect!");
            Console.WriteLine("The correct answer was " + correctAnswer);
        }

        public static void score(int i)
        {
            Console.WriteLine("Your score was " + i + "\n");
        }

        public static void nextLn()
        {
            Console.WriteLine();
        }

        public static void difficulty()
        {
            Console.WriteLine("Please enter a difficulty level");
            Console.WriteLine("1. Easy");
            Console.WriteLine("2. Hard\n");
        }

        public static void incorrectInput()
        {
            Console.WriteLine("Incorrect Input\n");
        }

        public static void enterName()
        {
            Console.WriteLine("Please enter your name\n");
        }

        public static void scoreBoard(string[] lines)
        {
            Console.WriteLine("Scoreboard\n");
            foreach (string line in lines)  //For each line in the array of lines output the line
            {
                Console.WriteLine(line);
            }
            nextLn();
        }

        public static void tutorial()
        {
            Console.WriteLine("Welcome to the tutorial\n");
            Console.WriteLine("This tutorial will teach you how to play the game\n");
            Console.WriteLine("This game has 2 modes easy and hard\n");
            Console.WriteLine("Easy mode will give you 2 cards and ask you to perform an operation on them\n");
            Console.WriteLine("Hard mode will give you 3 cards and ask you to perform an operation on them but for hard mode you will need to use BODMAS to obtain the correct anwser\n");
            Console.WriteLine("BODMAS stands for Brackets, Orders, Division, Multiplication, Addition and Subtraction\n");
            Console.WriteLine("This means that you will need to perform the operations in that order\n");
            Console.WriteLine("For example if you were given the cards 2, 3 and 4 and were asked to perform the operation 2 + 3 * 4\n");
            Console.WriteLine("You would first perform the multiplication operation as it is the first operation in BODMAS\n");
            Console.WriteLine("This would give you the anwser 2 + 12\n");
            Console.WriteLine("You would then perform the addition operation as it is the second operation in BODMAS\n");
            Console.WriteLine("This would give you the anwser 14\n");
            Console.WriteLine("This is the correct anwser\n");
            Console.WriteLine("All anwsers should be rounded to the nearest whole number\n");
            Console.WriteLine("Now that you know how to play the game you can now play the game\n");
        }

        public static void noName()
        {
            Console.WriteLine("Name cannot be blank enter name again\n");
        }

        public static void fileNotFound()
        {
            Console.WriteLine("File not found in location, check program folder for EasyScores.txt and HardScores.txt\n");
        }
    }
}