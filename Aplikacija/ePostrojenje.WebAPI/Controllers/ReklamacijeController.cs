using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Recommenders;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ePostrojenje.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReklamacijeController : ControllerBase
    {
        private readonly IReklamacijeService _service;
        private readonly IMapper _mapper;
        public ReklamacijeController(IReklamacijeService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        
        [HttpGet]
        public List<Model.Reklamacije> Get([FromQuery]ReklamacijeSearchRequest request)
        {
            return _service.Get(request);
        }
        
        [HttpGet("{reklamacijaID}")]
        //[Route("api/[controller]")]
        public List<Model.Reklamacije> RecommendReklamacija (int reklamacijaID)
        {
            Recommender r = new Recommender();
            return _mapper.Map<List<Model.Reklamacije>>(r.GetSlicneReklamacije(reklamacijaID));
        }

        [HttpPost]
        public Model.Reklamacije Insert(ReklamacijeInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "1,3")]
        [HttpPut("{id}")]
        public Model.Reklamacije Update(int id, [FromBody]ReklamacijeInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}