using System;
using System.Collections;

namespace Blackjack
{
    public class Deck<T>
    {
        private ArrayList _cards;
        private static Random _rnd = new Random();
        
        public Deck()
        {
            this._cards = BuildDeck();
        }

        private static ArrayList BuildDeck()
        {
            var cards = new ArrayList();
            for (var i = 2; i < 11; i++)
            {
                var temp = ArrayList.Repeat(i, 4);
                cards.AddRange(temp);
            }

            var face = ArrayList.Repeat("K", 12);
            var ace = ArrayList.Repeat("A", 4);
            cards.AddRange(face);
            cards.AddRange(ace);
            return cards;
        }

        public T DrawCard()
        {
            var r = _rnd.Next(0, this._cards.Count);
            var card = (T) this._cards[r];
            this._cards.RemoveAt(r);
            return card;
        }
    }
}