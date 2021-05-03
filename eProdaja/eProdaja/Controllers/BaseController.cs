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
    public class BaseController<T, TSearch> : ControllerBase where T: class where TSearch: class
    {
        protected readonly IBaseReadService<T, TSearch> _service;

        public BaseController(IBaseReadService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<T> Get([FromQuery]TSearch search = null)
        {
            return _service.Get(search);
        }

        [HttpGet("{Id}")]
        public T GetById(int Id)
        {
            return _service.GetById(Id);
        }
    }
}
