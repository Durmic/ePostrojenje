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
    public class RacuniController : BaseCRUDController<Model.Racuni, RacuniSearchRequest, RacuniInsertRequest, RacuniInsertRequest>
    {
        public RacuniController(ICRUDService<Racuni, RacuniSearchRequest, RacuniInsertRequest, RacuniInsertRequest> service) : base(service)
        {
        }
    }
}