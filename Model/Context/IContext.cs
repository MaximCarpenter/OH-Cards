using System.Linq;

namespace Model.Context
{
    public interface IContext
    {
        IQueryable<T> Get<T>() where T : class;
        void Add<T>(T value) where T : class;
        void Update<T>(T value) where T : class;
        void Delete(int id);
    }
}
