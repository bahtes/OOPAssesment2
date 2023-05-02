using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A02_2223
{
    class Test  
    {
        Format format = new Format();  //Creates a new instance of the Format class
        Game game = new Game(); //Creates a new instance of the Game class

        public void run()  //Runs the program
        {
            bool playing = true;

            Messages.welcome();

            Messages.enterName();

            string name = Console.ReadLine();  //Gets the name of the player

            while (string.IsNullOrWhiteSpace(name))  //Checks if the name is null or whitespace and asks for a new name if it is
            {
                Messages.noName();
                name = Console.ReadLine();
            }

            Messages.nextLn();

            while(playing)  //This loop runs the menu and the game until the user chooses to exit
            {
                format.shuffle(1, true);  //Shuffles the pack of cards

                Messages.menu();

                string menuInput = Console.ReadLine();
                Messages.nextLn();
                
                switch (menuInput)  //Switch statement for the menu options 
                {
                    case "1":  //Starts the game and asks for the difficulty
                        Messages.difficulty();
                        int difficultyG = int.Parse(Console.ReadLine());
                        while (difficultyG != 1 && difficultyG != 2)
                        {
                            Messages.incorrectInput();
                            Messages.nextLn();
                            difficultyG = int.Parse(Console.ReadLine());
                        }
                        
                        FileInfo.setPath(difficultyG);
                        Messages.nextLn();
                        game.run(difficultyG, name);
                        Messages.nextLn();
                        break;

                    case "2":  //Displays the instructions
                        Messages.instructions();
                        break;

                    case "3":  //Shows the scores for the difficulty chosen
                        Messages.difficulty();
                        int difficultyS = int.Parse(Console.ReadLine());
                        while (difficultyS != 1 && difficultyS != 2)
                        {
                            Messages.incorrectInput();
                            Messages.nextLn();
                            difficultyS = int.Parse(Console.ReadLine());
                        }
                        FileInfo.setPath(difficultyS);
                        ReadFile.read();
                        break;

                    case "4":  //Shows the tutorial
                        Messages.tutorial();
                        break;

                    case "5":  //Shuffles the pack
                        format.shuffle(1, false);
                        break;

                    case "6":  //Creates a new pack
                        format.newPack();
                        break;

                    case "7":  //Gets the amount of cards left in the pack
                        Messages.goodbye();
                        System.Threading.Thread.Sleep(3000);
                        playing = false;
                        break;

                    default:
                        Messages.incorrectInput();
                        break;
                }

            }

        }

    }
}