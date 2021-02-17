using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePostrojenje.WebAPI.Controllers
{
    public class OcjeneController : BaseCRUDController<Model.Ocjene, Model.Ocjene, OcjeneUpdateRequest, OcjeneUpdateRequest>
    {
        public OcjeneController(ICRUDService<Ocjene, Ocjene, OcjeneUpdateRequest, OcjeneUpdateRequest> service) : base(service)
        {
        }
    }
}