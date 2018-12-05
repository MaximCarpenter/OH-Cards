using Model.Context;

namespace Model.Card
{
    public class Deck : IEntity
    {
        public int Id { get; set; }
        public int ParentDeckId { get; set; }
        public string Name { get; set; }
        public DeckType DeckType { get; set; }
        public string Comment { get; set; }
    }
}
