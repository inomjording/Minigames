using System.Collections.Generic;

namespace Blackjack
{
    public class Hand
    {

        public List<int> Cards = new List<int>();

        public Hand()
        {
        }

        public void AddCard(int card)
        {
            this.Cards.Add(card);
        }
    }
}
