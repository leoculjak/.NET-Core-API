using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eProdaja.Controllers;
using eProdaja.Database;

namespace eProdaja.Services
{
    public class VrstaProizvodaService : BaseReadService<Database.VrsteProizvodum, Model.VrsteProizvodum, object>, IVrstaProizvodaService
    {
        public VrstaProizvodaService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
            
        }
    }
}
