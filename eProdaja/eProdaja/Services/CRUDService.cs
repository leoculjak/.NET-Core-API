using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class CRUDService<Tdb, T, TSearch, Tinsert, Tupdate> : BaseReadService<Tdb, T, TSearch>, ICRUDService<T, TSearch, Tinsert, Tupdate> where Tdb : class where T : class where TSearch : class where Tinsert: class where Tupdate: class
    {
        public CRUDService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual T Insert(Tinsert request)
        {
            var set = _context.Set<Tdb>();

            var entity = _mapper.Map<Tdb>(request);

            set.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, Tupdate request)
        {
            var set = _context.Set<Tdb>();

            var entity = set.Find(id);

            _mapper.Map(request,entity);

            _context.SaveChanges();

            return _mapper.Map<T>(entity);
        }
    }
}
