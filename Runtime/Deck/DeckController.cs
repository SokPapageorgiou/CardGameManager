using System;
using System.Collections.Generic;

namespace CardGameManager.Runtime.Deck
{
    public class DeckController<T>
    {
        public Stack<T> GetDeck(T[] cards)
        {
            Shuffle(cards);
            return StackCards(cards);
        }

        public void Shuffle(T[] cards)
        {
            var random = new Random();
            var cardsCount = cards.Length;
            
            for (int i = cardsCount - 1; i > 0; i--)
            {
                var selectedCard = cards[i];
                int rndIndex = random.Next(0, i);

                cards[i] = cards[rndIndex];
                cards[rndIndex] = selectedCard;
            }
        }

        private Stack<T> StackCards(T[] cards)
        {
            var stack = new Stack<T>();
            
            foreach (var card in cards)
            {
                stack.Push(card);    
            }

            return stack;
        }
    }
}