using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A02_2223
{

    class Pack
    {
        public static List<Card> pack = new List<Card>();

        public Pack()  //Constructor
        {
            

            var suits = Enumerable.Range(1, 4).ToList();  //1 = Hearts, 2 = Diamonds, 3 = Clubs, 4 = Spades
            var values = Enumerable.Range(1, 13).ToList();  //1-10 normal values eg.(1 = ace, 2 = 2, 3 = 3...), 11 = Jack, 12 = Queen, 13 = King

            foreach (int suit in suits)
            {
                foreach (int value in values)
                {
                    pack.Add(new Card(suit, value));  //Adds a new card to the pack until all suits and values have been added
                }
            }
        }

        public static void clearPack()
        {
            pack.Clear();  //Clears the pack
        }

        public static string count()
        {
            return(pack.Count.ToString());
        }

        public static bool shuffleCardPack(int typeOfShuffle)  //Fisher-Yates = 1, Riffle Shuffle = 2, No Shuffle = 3  Returns true if shuffle is successful
        {
            //Shuffles the pack based on the type of shuffle

            switch(typeOfShuffle)
            {
                case 1:  //Fisher-Yates Shuffle, swaps the position of two random cards in the pack until the pack is shuffled
                    Random r = new Random();

                    int n = pack.Count;

                    while (n > 1)
                    {
                        n--;
                        int i = r.Next(n + 1);
                        Card card = pack[i];
                        pack[i] = pack[n];
                        pack[n] = card;
                    }
                    return true;

                case 2:  //Riffle Shuffle, splits the pack in half and then alternates the cards from each half until the pack is shuffled (Doesn't use any random as it is a perfect riffle shuffle but it is predictable)
                    List<Card> pack1 = new List<Card>();
                    List<Card> pack2 = new List<Card>();

                    pack1 = pack.GetRange(0, (pack.Count / 2));
                    pack2 = pack.GetRange((pack.Count / 2), (pack.Count / 2));

                    pack.Clear();

                    for( int i = 0; i < pack1.Count; i++)
                    {
                        pack.Add(pack1[i]);
                        pack.Add(pack2[i]);
                    }

                    return true;

                case 3:  //No Shuffle, returns the pack in the same order as it was created
                    return true;
                    
                default:  //If the user inputs an incorrect value for the type of shuffle
                    return false;
            }

        }
        public static Card deal()
        {
            //Deals one card

            try  //If there are no cards left in the pack, it will return a card with a value of 0 and a suit of 0, this is because you cannot return null due to the fact that the method is returning a card
            { 
                Card card = pack[0];
                pack.RemoveAt(0);
                return card;
            }
            catch(ArgumentOutOfRangeException)  
            {
                Card card = new Card(0, 0);
                return card;
            }
        }
        public static List<Card> dealCard(int amount)  //Returns a list of cards with the amount specified by the user in the parameter 'amount'
        {
            //Deals the number of cards specified by 'amount'

            List<Card> cards = new List<Card>();

            if (pack.Count >= amount)  //If there are enough cards left in the pack
            {

                while (amount > 0)
                {
                    cards.Add(deal());
                    amount--;
                }
                return cards;
            }
            else
            {
                return cards;
            }
        }
    }
}