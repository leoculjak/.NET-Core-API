using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Vjezba.Services
{
    public class ProizvodService : IProizvod
    {
        public IEnumerable<Proizvod> Get()
        {
            // testna lista proizvoda
            List<Proizvod> p = new List<Proizvod>() { new Proizvod { Id = 1, Naziv = "Laptop" }, new Proizvod { Id = 2, Naziv = "Monitor" } };

            return p;
        }

        public class Proizvod
        {
            public int Id { get; set; }
            public string Naziv { get; set; }
        }
    }
}
