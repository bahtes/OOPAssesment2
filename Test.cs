using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A02_2223
{
    class Test  
    {

<<<<<<< HEAD
        Format format = new Format();  //Creates a new instance of the Format class
        Messages messages = new Messages();  //Creates a new instance of the Welcome class
        Game game = new Game(); //Creates a new instance of the Game class
=======
        Format format = new Format();
>>>>>>> parent of ee7f298 (Added some more comments)

        public void run()
        {
            bool playing = true;

            messages.welcome();

            while(playing)
            {
                format.shuffle(1, true);

                messages.menu();

                string menuInput = Console.ReadLine();
                messages.nextLn();

                if (menuInput == "1")
                {
                    game.run();
                }

                if (menuInput == "2")
                {
                    messages.instructions();
                }

                if (menuInput == "3")
                {
                    format.shuffle(1, false);
                }

                if (menuInput == "4")
                {
                    format.newPack();
                }

                if (menuInput == "5")
                {
                    messages.goodbye();
                    playing = false;
                }

                if (menuInput != "1" && menuInput != "2" && menuInput != "3" && menuInput != "4" && menuInput != "5")
                {
                    Console.WriteLine("Incorrect input");
                }
            }

        }

    }
}