using System;
using Xunit;
using Lab07_Collections.Classes;

namespace Lab07_Test
{
    public class UnitTest1
    {
        static Card aceClubs = new Card(Suit.Clubs, Value.Ace);
        static Card ThreeDiamonds = new Card(Suit.Diamonds, Value.Three);
        static Card queenSpades = new Card(Suit.Spades, Value.Queen);
        static Card jackSpades = new Card(Suit.Spades, Value.Jack);
        static Card sevenClubs = new Card(Suit.Clubs, Value.Seven);
        static Card fourDiamonds = new Card(Suit.Diamonds, Value.Four);
        static Card fourClubs = new Card(Suit.Clubs, Value.Four);
        static Card nineHearts = new Card(Suit.Hearts, Value.Nine);
        static Card twoDiamonds = new Card(Suit.Diamonds, Value.Two);
        static Card kingHearts = new Card(Suit.Hearts, Value.King);

        Deck<Card> deck = new Deck<Card>
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
        [Fact]
        public void CardsCorrectlyAddedToDeck()
        {
            Assert.True(deck.count == 10);
        }

        [Fact]
        public void CheckSetCardPropertiesTest()
        {
            Card newCard = new Card(Suit.Spades, Value.Ace);
            Assert.True(newCard.Suit == Suit.Spades);
        }

        [Fact]
        public void CheckGetCardPropertiesTest()
        {
            Assert.True(fourDiamonds.Suit == Suit.Diamonds);
        }

        [Fact]
        public void RemoveCardFromDeckTest()
        {
            deck.Remove(kingHearts);
            Assert.False(deck.Contains(kingHearts));
        }

        [Fact]
        public void RemoveNonExistantCardFromDeck()
        {
            Card newCard = new Card(Suit.Spades, Value.Ace);
            Assert.False(deck.Contains(newCard));
        }
    }
}
