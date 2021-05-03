﻿using AutoMapper;
using eProdaja.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class BaseReadService<Tdb, T, TSearch> : IBaseReadService<T, TSearch> where T: class where Tdb: class where TSearch: class
    {
        public eProdajaContext _context { get; set; }
        protected readonly IMapper _mapper;

        public BaseReadService(eProdajaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual IEnumerable<T> Get(TSearch search = null)
        {
            var entity = _context.Set<Tdb>();

            return entity.ToList().Select(x => _mapper.Map<T>(x)).ToList();
        }

        public T GetById(int id)
        {
            var model = _context.Set<Tdb>();
            var entity = model.Find(id);

            return _mapper.Map<T>(entity);
        }
    }
}
