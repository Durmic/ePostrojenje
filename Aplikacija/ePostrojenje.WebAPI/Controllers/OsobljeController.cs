using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OsobljeController : ControllerBase
    {
        private readonly IOsobljeService _service;
        public OsobljeController(IOsobljeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Model.Osoblje> Get([FromQuery]OsobljeSearchRequest request)
        {
            return _service.Get(request);
        }


        [HttpGet("{id}")]
        public Model.Osoblje GetById(int id)
        {
            return _service.GetById(id);
        }

        [Authorize(Roles = "1")]
        [HttpPost]
        public Model.Osoblje Insert(OsobljeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize (Roles ="1")]
        [HttpPut("{id}")]
        public Model.Osoblje Update(int id, OsobljeInsertRequest request)
        {
            return _service.Update(id, request);
        }

    }
}
