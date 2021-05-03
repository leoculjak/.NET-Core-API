using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Controllers;
using eProdaja.Database;
using Microsoft.EntityFrameworkCore;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseReadService<Database.Proizvodi, Model.Proizvodi, Model.ProizvodiSearchObject>, IProizvodiService
    {
        public ProizvodiService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
            
        }

        public override IEnumerable<Model.Proizvodi> Get(Model.ProizvodiSearchObject search)
        {
            var entity = _context.Set<Database.Proizvodi>().AsQueryable();

            if (!string.IsNullOrWhiteSpace(search.Naziv))
            {
                entity = entity.Where(x=>x.Naziv.Contains(search.Naziv));
            }

            if (search.JedinicaMjereId.HasValue)
            {
                entity = entity.Where(x => x.JedinicaMjereId == search.JedinicaMjereId);
            }

            if (search.VrstaId.HasValue)
            {
                entity = entity.Where(x => x.VrstaId == search.VrstaId);
            }

            if (search?.Connections?.Any() == true)
            {
                foreach (var c in search.Connections)
                {
                    entity = entity.Include(c);
                }
            }

            var list = entity.ToList();
            return list.Select(x => _mapper.Map<Model.Proizvodi>(x)).ToList();
        }
    }
}
