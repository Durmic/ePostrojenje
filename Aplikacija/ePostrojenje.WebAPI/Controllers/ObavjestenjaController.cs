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
    public class ObavjestenjaController : ControllerBase
    {
        private readonly IObavjestenjaService _service;
        public ObavjestenjaController(IObavjestenjaService service)
        {
            _service = service;
        }

       
        [HttpGet]
        public List<Model.Obavjestenja> Get([FromQuery]ObavjestenjaSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.Obavjestenja GetById(int id)
        {
            return _service.GetById(id);
        }
        [Authorize(Roles = "2")]
        [HttpPost]
        public Model.Obavjestenja Insert(ObavjestenjaInsertRequest request)
        {
            return _service.Insert(request);
        }
        [Authorize(Roles = "2")]
        [HttpPut("{id}")]
        public Model.Obavjestenja Update(int id, [FromBody]ObavjestenjaInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}
