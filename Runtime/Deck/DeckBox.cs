﻿using System.Collections.Generic;

namespace CardGameManager.Runtime.Deck
{
    public class DeckBox<T>
    {
        public Stack<T> Deck { get; set; }
        public Stack<T> Discarded { get; set; }

        public DeckBox(Stack<T> deck, Stack<T> discarded)
        {
            Deck = deck;
            Discarded = discarded;
        }
    }
}