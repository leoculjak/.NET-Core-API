using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Controllers;
using eProdaja.Database;

namespace eProdaja.Services
{
    public class ProizvodiService : BaseReadService<Database.Proizvodi, Model.Proizvodi>, IProizvodiService
    {
        public ProizvodiService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
    }
}
