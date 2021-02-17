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
    public class OdjeliController : BaseController<Model.Odjeli, object>
    {
        public OdjeliController(IService<Odjeli, object> service) : base(service)
        {
        }
    }
}