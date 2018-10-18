using System;
using System.Collections.Generic;
using Lab07_Collections.Classes;

namespace Lab07_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Deal();
        }
        static void Deal()
        {
            Card aceClubs = new Card(Suit.Clubs, Value.Ace);
            Card ThreeDiamonds = new Card(Suit.Diamonds, Value.Three);
            Card queenSpades = new Card(Suit.Spades, Value.Queen);
            Card jackSpades = new Card(Suit.Spades, Value.Jack);
            Card sevenClubs = new Card(Suit.Clubs, Value.Seven);
            Card fourDiamonds = new Card(Suit.Diamonds, Value.Four);
            Card fourClubs = new Card(Suit.Clubs, Value.Four);
            Card nineHearts = new Card(Suit.Hearts, Value.Nine);
            Card twoDiamonds = new Card(Suit.Diamonds, Value.Two);
            Card kingHearts = new Card(Suit.Hearts, Value.King);

            List<Card> cards = new List<Card>
            {
                aceClubs,
                ThreeDiamonds,
                queenSpades,
                jackSpades,
                sevenClubs,
                fourDiamonds,
                fourClubs,
                nineHearts,
                twoDiamonds,
                kingHearts
            };


            Deck<Card> deck = new Deck<Card>();

            foreach (Card card in cards)
            {
                deck.Add(card);
            }

            Card[] cardsOfSuit = deck.ReturnSuit(Suit.Hearts);

            foreach (Card card in cardsOfSuit)
            {
                Console.WriteLine(card.Value);
            }
        }
    }
}
