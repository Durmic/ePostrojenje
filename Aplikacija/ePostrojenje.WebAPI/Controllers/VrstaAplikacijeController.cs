using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePostrojenje.WebAPI.Controllers
{
    public class VrstaAplikacijeController : BaseCRUDController<Model.VrstaAplikacije, Model.VrstaAplikacije, Model.Requests.VrstaAplikacijeInsert, Model.Requests.VrstaAplikacijeInsert>
    {
        public VrstaAplikacijeController(ICRUDService<Model.VrstaAplikacije, Model.VrstaAplikacije, Model.Requests.VrstaAplikacijeInsert, Model.Requests.VrstaAplikacijeInsert> service) : base(service)
        {
        }
    }
}