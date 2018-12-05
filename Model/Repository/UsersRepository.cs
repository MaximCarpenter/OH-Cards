using Model.Context;

namespace Model.Repository
{
    public class UsersRepository : RepositoryBase
    {
        private readonly IContext _context;

        public UsersRepository(IContext context) : base(context)
        {
            _context = context;
        }
    }
}
