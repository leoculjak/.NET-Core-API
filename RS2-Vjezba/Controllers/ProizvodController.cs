using Microsoft.AspNetCore.Mvc;
using RS2_Vjezba.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS2_Vjezba.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ProizvodController : Controller
    {
        private readonly IProizvod _proizvod;

        public ProizvodController(IProizvod proizvod)
        {
            _proizvod = proizvod;
        }

        [HttpGet]
        public IEnumerable<Proizvod> Index()
        {
            return _proizvod.Get();
        }

        [HttpGet("{id}")]
        public Proizvod GetById(int id)
        {
            return _proizvod.GetById(id);
        }

        [HttpPost]
        public Proizvod Add(Proizvod p)
        {
            //return _proizvod.Add(new Proizvod() { Id = p.Id, Naziv=p.Naziv });
            return _proizvod.Add(p);
        }

        [HttpPut("{id}")]
        public Proizvod Update(int id, Proizvod p)
        {
            return _proizvod.Update(id, p);
        }
    }
}
