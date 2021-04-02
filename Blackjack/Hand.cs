using System.Collections;
using System.Collections.Generic;

namespace Blackjack
{
    public class Hand<T>
    {
        public ArrayList Cards = new ArrayList();

        public Hand()
        {
            
        }

        public void AddCard(T card)
        {
            if (card as string == "A")
            {
                this.Cards.Add(card);
            }

            else
            {
                this.Cards.Insert(0, card);
            }
            
        }

        public int SumHand()
        {
            var sum = 0;
            var aceCount = 0;
            foreach (var card in this.Cards)
            {
                
                switch (card)
                {
                    case "K":
                        sum += 10;
                        break;

                    case "A":
                        aceCount++;

                        break;
                        
                    default:
                        sum += (int) card;
                        break;
                }

                for (var i = 0; i < aceCount; i++)
                {
                    if (sum + 11 > 21)
                    {
                        sum += 1;
                        if (sum > 21 && i+1 < aceCount && i > 0)
                        {
                            sum -= 10;
                        }
                    }
    
                    else
                    {
                        sum += 11; 
                    }
                }
                
            }
            return sum;
        }
    }
}
