using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePostrojenje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RSII25092020Controller : ControllerBase
    {
        private readonly IRSII25092020Service _service;
        public RSII25092020Controller(IRSII25092020Service service)
        {
            _service = service;
        }

        [AllowAnonymous]
        [HttpGet]
        public List<Model.RSII25092020> Get([FromQuery]RSII25092020SearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet("{id}")]
        public Model.RSII25092020 GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public Model.RSII25092020 Insert(RSII25092020InsertRequest request)
        {
            return _service.Insert(request);
        }

        [HttpPut("{id}")]
        public Model.RSII25092020 Update(int id, [FromBody]RSII25092020InsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}