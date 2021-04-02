using System.Collections;
using System.Collections.Generic;

namespace Blackjack
{
    public class Hand
    {
        public ArrayList Cards = new ArrayList();

        public Hand()
        {
            
        }

        public void AddCard(int card)
        {
            this.Cards.Add(card);
        }

        public int SumHand()
        {
            return 0;
        }
    }
}
