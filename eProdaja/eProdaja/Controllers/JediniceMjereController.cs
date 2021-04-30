using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JediniceMjereController : Controller
    {
        private readonly IJediniceMjereService _service;
        public JediniceMjereController(IJediniceMjereService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<Model.JediniceMjere> Get()
        {
            return _service.Get();
        }

        [HttpGet("{Id}")]
        public Model.JediniceMjere GetById(int Id)
        {
            return _service.GetById(Id);
        }
    }
}
