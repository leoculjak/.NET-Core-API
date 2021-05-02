using AutoMapper;
using eProdaja.Database;
using eProdaja.Filters;
using eProdaja.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class KorisniciService : BaseReadService<Database.Korisnici, Model.Korisnici>, IKorisniciService
    {
        public KorisniciService(eProdajaContext context, IMapper mapper) : base(context, mapper)
        {
            
        }

        //public Model.Korisnici Insert(KorisniciInsertRequest request)
        //{
        //    //throw new NotImplementedException();
        //    throw new UserException("Lozinka nije ispravna");
        //}

        //GetById

        //private Model.Korisnici ToModel(Korisnici entity)
        //{
        //    return new Model.Korisnici()
        //    {
        //        KorisnikId = entity.KorisnikId,
        //        Ime = entity.Ime,
        //        Prezime = entity.Prezime,
        //        KorisnickoIme = entity.Ime,
        //        Email = entity.Email,
        //        Telefon = entity.Telefon
        //    };
        //}

    }
}
