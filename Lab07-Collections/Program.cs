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

            Deck<Card> deck = new Deck<Card>();

            deck.Add(aceClubs);
            deck.Add(ThreeDiamonds);
            deck.Add(queenSpades);
            deck.Add(jackSpades);
            deck.Add(sevenClubs);
            deck.Add(fourDiamonds);
            deck.Add(fourClubs);
            deck.Add(nineHearts);
            deck.Add(twoDiamonds);
            deck.Add(kingHearts);

            Card[] cardsOfSuit = deck.ReturnSuit(Suit.Hearts);

            foreach (Card card in cardsOfSuit)
            {
                Console.WriteLine(card.Value);
            }
        }
    }
}
