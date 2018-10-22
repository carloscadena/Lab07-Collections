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

            Console.WriteLine("Cards in the deck are:");
            foreach (Card card in deck)
            {
                Console.WriteLine($"{card.Value}: {card.Suit}");
            }

            Card[] cardsOfSuit = deck.ReturnSuit(Suit.Hearts);
            Console.WriteLine("------------------------------");
            Console.WriteLine("Cards in deck that are of the suit Hearts:");
            foreach (Card card in cardsOfSuit)
            {
                Console.WriteLine(card.Value);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("The deck with the Hearts removed:");
            foreach (Card card in cardsOfSuit)
            {
                deck.Remove(card);
            }
            foreach (Card card in deck)
            {
                Console.WriteLine($"{card.Value}: {card.Suit}");
            }
        }
    }
}
