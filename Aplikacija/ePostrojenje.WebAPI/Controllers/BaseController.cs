using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ePostrojenje.WebAPI.Recommenders;
using ePostrojenje.WebAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
//using ePostrojenje.WebAPI.Mapper;

namespace ePostrojenje.WebAPI.Controllers
{
    //s[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        private readonly IService<T, TSearch> _service;
        private readonly IMapper _mapper;
        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }


        [HttpGet]
        public List<T> Get([FromQuery]TSearch search)
        {
            return _service.Get(search);
        }
        /*
        [HttpGet]
        //[Route("api/Reklamacije/{typeId}")]
        public List<Model.Reklamacije> RecommendReklamacija(int reklamacijaID)
        {
            Recommender r = new Recommender();
            return _mapper.Map<List<Model.Reklamacije>>(r.GetSlicneReklamacije(reklamacijaID));
        }*/

        [HttpGet("{id}")]
        public T GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}