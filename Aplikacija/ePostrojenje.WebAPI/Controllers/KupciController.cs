using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePostrojenje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KupciController : ControllerBase
    {
        private readonly IKupciService _service;
        public KupciController(IKupciService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public List<Model.Kupci> Get([FromQuery]KupciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Kupci GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.Kupci Insert(KupciInsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.Kupci Update(int id, [FromBody]KupciInsertRequest request)
        {
            return _service.Update(id, request);
        }

    }
}