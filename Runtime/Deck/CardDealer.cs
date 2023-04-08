namespace CardGameManager.Runtime.Deck
{
    public class CardDealer<T>
    {
        private readonly Holder<T> _holder;
        private DeckController<T> _cardHandler;

        public CardDealer(Holder<T> holder, DeckController<T> cardHandler)
        {
            _holder = holder;
            _cardHandler = cardHandler;
        }

        public void InitDeck(T[] cards) =>
            _holder.Deck = _cardHandler.GetDeck(cards);

        public T Draw() => _holder.Deck.Pop();

        public void Discard(T card) => _holder.Discarded.Push(card);

    }
}