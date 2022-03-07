using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Card
    {
        public Card(Suits suit, Values value)
        {
            this.value = value;
            this.suit = suit;
        }
        public enum Suits
        {
            Clubs,
            Diamonds,
            Hearts,
            Spades
        }

        public enum Values
        {
            A = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            J = 11,
            Q = 12,
            K = 13

        }

        private Suits suit;
        private Values value;

        public Suits Suit
        {
            get { return suit; }
        }
        public Values Value
        {
            get { return value; }
        }

        
    }
}
