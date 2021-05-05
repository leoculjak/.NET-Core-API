using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Controllers;

namespace eProdaja.Services
{
    public interface IProizvodiService : ICRUDService<Model.Proizvodi, Model.ProizvodiSearchObject, Model.Requests.ProizvodiInsertRequest, Model.Requests.ProizvodiUpdateRequest>
    {
        
    }
}
