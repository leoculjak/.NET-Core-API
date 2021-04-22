using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Vjezba.Services
{
    public class ProizvodService : IProizvod
    {
        // testna lista proizvoda
        public static List<Proizvod> p = new List<Proizvod>() { new Proizvod { Id = 1, Naziv = "Laptop" }, new Proizvod { Id = 2, Naziv = "Monitor" } };


        public IEnumerable<Proizvod> Get()
        {
            return p;
        }


        public Proizvod GetById(int id)
        {
            return p.FirstOrDefault(x => x.Id == id);
        }

        public Proizvod Add(Proizvod proizvod)
        {
            p.Add(proizvod);
            return proizvod;
        }

        public Proizvod Update(int id, Proizvod proizvod)
        {
            var tmp = p.FirstOrDefault(x => x.Id == id);
            tmp.Naziv = proizvod.Naziv;

            return tmp;
        }
    }

    public class Proizvod
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
    }
}
