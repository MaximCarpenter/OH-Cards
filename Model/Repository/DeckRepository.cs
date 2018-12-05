using Model.Context;

namespace Model.Repository
{
    public class DeckRepository : RepositoryBase
    {
        private readonly IContext _context;

        public DeckRepository(IContext context) : base(context)
        {
            _context = context;
        }
    }
}
