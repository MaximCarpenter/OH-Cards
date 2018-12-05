using System.Collections.Generic;
using System.Linq;
using Model.Context;

namespace Model.Repository
{
    public class CardsRepository : RepositoryBase
    {
        private readonly IContext _context;

        public CardsRepository(IContext context) : base(context)
        {
            _context = context;
        }

        public List<Card.Card> GetByDeck(int id)
        {
            return _context.Get<Card.Card>().Where(c => c.DeckId == id).ToList();
        }
    }
}
