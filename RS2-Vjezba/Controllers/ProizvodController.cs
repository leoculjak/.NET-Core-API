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
        public IEnumerable<ProizvodService.Proizvod> Index()
        {
            return _proizvod.Get();
        }
    }
}
