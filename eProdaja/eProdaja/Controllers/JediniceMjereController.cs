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
    public class JediniceMjereController : BaseController<Model.JediniceMjere>
    {
        public JediniceMjereController(IJediniceMjereService service) : base(service)
        {
            
        }

        //[HttpGet]
        //public IEnumerable<Model.JediniceMjere> Get()
        //{
        //    return _service.Get();
        //}

        //[HttpGet("{Id}")]
        //public Model.JediniceMjere GetById(int Id)
        //{
        //    return _service.GetById(Id);
        //}
    }
}
