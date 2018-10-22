using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Lab07_Collections.Classes
{
    public class Deck<T> : IEnumerable
    {
        T[] cards = new T[5];
        public int count = 0;

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
                Card card = (Card)(object)cards[i];
                if (card.Suit == suit)
                {
                    sameSuit[idx++] = (T)(object)card;
                }
            }
            Array.Resize(ref sameSuit, idx);

            return sameSuit;
        }

        public string Remove(T card)
        {
            Card remove = (Card)(object)card;
            for (int i = 0; i < count; i++)
            {
                Card current = (Card)(object)cards[i];
                if (current.Value == remove.Value && current.Suit == remove.Suit)
                {
                    cards[i] = cards[--count];

                    return "successfully removed";
                }
            }
            return "card does not exist in deck";
        }

        /// <summary>
        /// confirm is card is in deck
        /// </summary>
        /// <param name="card">card being searched for</param>
        /// <returns>return true if contained in, else false</returns>
        public bool Contains(T card)
        {
            for (int i = 0; i < count; i++)
            {
                if (cards[i].Equals(card))
                {
                    return true;
                }
            }
            return false;
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
