namespace CardGameManager.Runtime.Deck
{
    public class CardDealer<T>
    {
        private readonly DeckBox<T> _box;
        private readonly DeckController<T> _controller;

        public CardDealer(DeckBox<T> holder, DeckController<T> controller)
        {
            _box = holder;
            _controller = controller;
        }

        public void InitDeck(T[] cards) =>
            _box.Deck = _controller.GetDeck(cards);

        public T Draw() => _box.Deck.Pop();

        public void Discard(T card) => _box.Discarded.Push(card);

    }
}