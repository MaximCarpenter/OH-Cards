using System;
using System.Collections.Generic;
using System.Linq;
using Model.Context;
using Model.Return;

namespace Model.Repository
{
    public abstract class RepositoryBase
    {
        private readonly IContext _context;

        public RepositoryBase(IContext context)
        {
            _context = context;
        }

        public List<IEntity> GetAll()
        {
            return _context.Get<IEntity>().ToList();
        }

        public List<IEntity> Get(int id)
        {
            return _context.Get<IEntity>().Where(c => c.Id == id).ToList();
        }

        public Return.Return Add(IEntity value)
        {
            try
            {
                _context.Add(value);
                return new Return.Return
                {
                    ReturnType = ReturnType.Success
                };
            }
            catch (Exception e)
            {
                return new Return.Return
                {
                    Message = e.Message,
                    ReturnType = ReturnType.Error
                };
            }
        }

        public Return.Return Update(IEntity value)
        {
            try
            {
                _context.Update(value);
                return new Return.Return
                {
                    ReturnType = ReturnType.Success
                };
            }
            catch (Exception e)
            {
                return new Return.Return
                {
                    Message = e.Message,
                    ReturnType = ReturnType.Error
                };
            }
        }

        public Return.Return Delete(int id)
        {
            try
            {
                _context.Delete(id);
                return new Return.Return
                {
                    ReturnType = ReturnType.Success
                };
            }
            catch (Exception e)
            {
                return new Return.Return
                {
                    Message = e.Message,
                    ReturnType = ReturnType.Error
                };
            }
        }
    }
}