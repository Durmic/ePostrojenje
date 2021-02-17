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

    public class UgovoriController : BaseCRUDController<Model.Ugovori, Model.Ugovori, UgovoriUpdateRequest, UgovoriUpdateRequest>
    {
        public UgovoriController(ICRUDService<Ugovori, Ugovori, UgovoriUpdateRequest, UgovoriUpdateRequest> service) : base(service)
        {
        }
    }
}