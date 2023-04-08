using System.Collections.Generic;

namespace CardGameManager.Runtime.Deck
{
    public class Holder<T>
    {
        public Stack<T> Deck { get; set; }
        public Stack<T> Discarded { get; set; }

        public Holder(Stack<T> deck, Stack<T> discarded)
        {
            Deck = deck;
            Discarded = discarded;
        }
    }
}