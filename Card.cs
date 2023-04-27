using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A02_2223
{
    class Card  //Base class for the Card class
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4
        //The 'set' methods for these properties could have some validation

        public Card(int s, int v)  //Constructor
        {
            Suit = s;
            Value = v;
        }

        public int Value { get; set; }  //Value of the card get and set
        public int Suit { get; set; }   //Suit of the card get and set

    }
}