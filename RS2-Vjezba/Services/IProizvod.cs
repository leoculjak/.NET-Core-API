using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Vjezba.Services
{
    public interface IProizvod
    {
        public IEnumerable<ProizvodService.Proizvod> Get();
    }
}
