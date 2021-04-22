using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Vjezba.Services
{
    public interface IProizvod
    {
        public IEnumerable<Proizvod> Get();
        public Proizvod GetById(int id);
        public Proizvod Add(Proizvod proizvod);
        public Proizvod Update(int id, Proizvod proizvod);
    }
}
