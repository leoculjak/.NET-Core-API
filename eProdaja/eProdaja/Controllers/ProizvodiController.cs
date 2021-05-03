using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eProdaja.Services;
using Microsoft.AspNetCore.Mvc;

namespace eProdaja.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProizvodiController : BaseController<Model.Proizvodi, Model.ProizvodiSearchObject>
    {
        public ProizvodiController(IProizvodiService proizvodiService) : base(proizvodiService)
        {
            
        }

    }
}
