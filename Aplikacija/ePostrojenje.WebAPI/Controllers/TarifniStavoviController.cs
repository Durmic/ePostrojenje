using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ePostrojenje.Model;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePostrojenje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarifniStavoviController : BaseController<Model.TarifniStavovi, object>
    {
        public TarifniStavoviController(IService<TarifniStavovi, object> service) : base(service)
        {
        }
    }
}