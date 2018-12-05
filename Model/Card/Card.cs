using Model.Context;

namespace Model.Card
{
    public class Card: IEntity
    {
        public int Id { get; set; }
        public int DeckId { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public byte[] Image { get; set; }
        public int ShirtCardId { get; set; }
        public byte[] ShirtCard { get; set; }
        public bool Passive { get; set; }
    }
}
