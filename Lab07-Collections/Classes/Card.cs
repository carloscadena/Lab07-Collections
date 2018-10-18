using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Card
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

    }
    
    public enum Suit
    {
        Diamonds,
        Hearts,
        Clubs,
        Spades
    }

    public enum Value
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
}
