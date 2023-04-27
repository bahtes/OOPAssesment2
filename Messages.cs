namespace CMP1903M_A02_2223
{

    class Messages
    {
        public void welcome()
        {
            Console.WriteLine("Welcome to the card game\n");
        }

        public void goodbye()
        {
          Console.WriteLine("Goodbye");
        }

        public void menu()
        {
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. Instructions");
            Console.WriteLine("3. Shuffle The Deck");
            Console.WriteLine("4. New Pack");
            Console.WriteLine("5. Exit\n");
        }

        public void instructions()
        {
            Console.WriteLine("Instructions\n");
        }

        public void questionNum(int i)
        {
            Console.WriteLine("Question " + (i + 1) + "\n");
        }

        public void suit(int num, string card)
        {
            Console.WriteLine("Card " + num + " Suit: " + card );
        }

        public void value(int num, string card)
        {
            Console.WriteLine("Card " + num + " Value: " + card + "\n");
        }

        public void val(int num, int val)
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

        public void op(string op)
        {
            Console.WriteLine("The operator will be " + op + "\n");
        }

        public void question(int val1, string op, int val2)
        {
            Console.WriteLine("What is " + val1 + " " + op + " " + val2 + "?\n");
        }

        public void correct()
        {
            Console.WriteLine("Correct!\n");
        }

        public void incorrect(int correctAnswer, int i)
        {
            Console.WriteLine("Incorrect!");
            Console.WriteLine("The correct answer was " + correctAnswer);
            Console.WriteLine("Your score was " + i + "\n");
        }

        public void nextLn()
        {
            Console.WriteLine();
        }
    }

}