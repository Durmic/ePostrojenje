using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Database;

namespace ePostrojenje.WebAPI.Services
{
    public class RacuniService : BaseCRUDService<Model.Racuni, RacuniSearchRequest, Database.Racuni, RacuniInsertRequest, RacuniInsertRequest>
    {
        public RacuniService(_150217Context context, IMapper mapper) : base(context, mapper)
        {
        }

    }
}
