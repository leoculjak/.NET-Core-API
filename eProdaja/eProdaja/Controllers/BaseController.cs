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
    public class BaseController<T> : ControllerBase where T: class
    {
        protected readonly IBaseReadService<T> _service;

        public BaseController(IBaseReadService<T> service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<T> Get()
        {
            return _service.Get();
        }

        [HttpGet("{Id}")]
        public T GetById(int Id)
        {
            return _service.GetById(Id);
        }
    }
}
