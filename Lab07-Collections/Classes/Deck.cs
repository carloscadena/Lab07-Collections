using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    class Deck<T> : IEnumerable
    {
        T[] cards = new T[5];
        int count = 0;

        public void Add(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[count++] = card;
        }

        public T[] ReturnSuit(Suit suit)
        {
            T[] sameSuit = new T[count];
            int idx = 0;
            for (int i = 0; i < count; i++)
            {
                Card card = (Card)Convert.ChangeType(cards[i], typeof(Card));
                if (card.Suit == suit)
                {
                    sameSuit[idx++] = (T)(object)card;
                }
            }
            return sameSuit;
        }
        // The purpose of these last two is still not completely clear to me
        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
