using System.Collections;

namespace Blackjack
{
    public class Deck
    {
        public ArrayList Cards = new ArrayList();
        
        public Deck()
        {
        }

        private void BuildDeck()
        {
            for (var i = 2; i < 11; i++)
            {
                var temp = ArrayList.Repeat(i, 4);
                this.Cards.AddRange(temp);
            }

            var face = ArrayList.Repeat("K", 12);
            var ace = ArrayList.Repeat("A", 4);
            this.Cards.AddRange(face);
            this.Cards.AddRange(ace);
        }
    }
}