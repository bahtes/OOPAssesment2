using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A02_2223
{
    class Format  //Class for formatting the output
    {

        Pack pack = new Pack();  //Creates a new instance of the Pack class

        public void newPack()  //Creates a new pack
        {
            Pack pack = new Pack();
            Pack.clearPack();
            pack = new Pack();
        }

        public void getPackCount()  //Gets the amount of cards left in the pack
        {
            Console.WriteLine("There are " + Pack.count() + " cards left in the pack\n");
        }

        public void shuffle(int typeOfShuffle, bool Silent)  //Shuffles the pack based on the type of shuffle
        {
            if (Pack.shuffleCardPack(typeOfShuffle))
            {
                if (!Silent)
                {
                    Console.WriteLine("Pack shuffled\n");
                }
            }
            else 
            {
                if (!Silent)
                {
                    Console.WriteLine("Shuffle unsuccessful suspected incorrect input\n");
                }
            } 
        }

        public string dealOne()  //Deals one card from the pack
        {

            Card d = Pack.deal();

            if (d.Suit != 0 || d.Value != 0)  //Checks if the card is not a null card
            {
                string v = aquireValue(d);
                string s = aquireSuit(d);

            return s + "," + v;
            }
            else
            {
                return "0";
            }

        }

        public string aquireValue(Card d)  //Aquires the value of the card and returns it as a string, eg. 1 = Ace, 11 = Jack, 12 = Queen, 13 = King
        {
            
            string v;

            switch (d.Value)
            {
                case 1:
                    v = "Ace";
                    break;
                case 11:

                    v = "Jack";
                    break;

                case 12:
                    v = "Queen";
                    break;

                case 13:
                    v = "King";
                    break;

                default:
                    v = d.Value.ToString();
                    break;
            }

            return v;

        }

        public string aquireSuit(Card d)  //Aquires the suit of the card and returns it as a string, eg. 1 = Hearts, 2 = Diamonds, 3 = Clubs, 4 = Spades
        {

            string s;

            switch (d.Suit)
            {
                case 1:
                    s = "Hearts";
                    break;

                case 2:
                    s = "Diamonds";
                    break;

                case 3:
                    s = "Clubs";
                    break;

                case 4:
                    s = "Spades";
                    break;

                default:
                    s = "Error";
                    break;
            }

            return s;

        }

    }
}