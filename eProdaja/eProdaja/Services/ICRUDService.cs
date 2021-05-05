using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public interface ICRUDService<T, TSearch, Tinsert, Tupdate> : IBaseReadService<T, TSearch> where T: class where TSearch: class where Tinsert : class where Tupdate : class
    {
        T Insert(Tinsert request);
        T Update(int id, Tupdate request);
    }
}
