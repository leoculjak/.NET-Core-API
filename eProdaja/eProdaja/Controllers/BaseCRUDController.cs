using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Controllers
{
    public class BaseCRUDController<T, TSearch, Tinsert, Tupdate> : BaseController<T, TSearch> where T : class where TSearch : class where Tinsert : class where Tupdate : class
    {
        protected readonly ICRUDService<T, TSearch, Tinsert, Tupdate> _crudService;
        public BaseCRUDController(ICRUDService<T, TSearch, Tinsert, Tupdate> service) : base(service)
        {
            _crudService = service;
        }

        [HttpPost]
        public T Insert([FromBody] Tinsert request)
        {
            return _crudService.Insert(request);
        }

        [HttpPut("{id}")]
        public T Update(int id, [FromBody] Tupdate request)
        {
            return _crudService.Update(id, request);
        }
    }
}
