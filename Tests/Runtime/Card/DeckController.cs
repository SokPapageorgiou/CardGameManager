using CardGameManager.Runtime.Deck;
using NUnit.Framework;

namespace CardGameManager.Tests.Runtime.Card
{
    public class DeckControllerTest
    {
       
        private readonly DeckController<int> _cardDealer = new();

        [Test]
        public void Shuffle_Assert_Shuffle_Changes_Order()
        {
            int[] sequence = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] shuffled = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            _cardDealer.Shuffle(shuffled);

            int count = 0;
            int minChangeThreshold = 3;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == shuffled[i]) count++;
            }
            
            Assert.Less(count, minChangeThreshold);
        }

        [Test]
        public void GetDeck_Stack_Has_Same_Amount_Of_Cards_Different_Order()
        {
            int[] sequence = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] shuffled = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var deck = _cardDealer.GetDeck(shuffled);

            bool hasShuffled = false;

            for (int i = 0; i < sequence.Length; i++)
            {
                int last = sequence.Length - i - 1;
                
                if (sequence[^last] != deck.Pop())
                {
                    hasShuffled = true;
                    break;
                }
            }
            
            Assert.True(hasShuffled);
        }
    }
}
