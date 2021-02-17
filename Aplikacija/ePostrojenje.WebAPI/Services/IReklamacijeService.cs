using ePostrojenje.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public interface IReklamacijeService
    {
        List<Model.Reklamacije> Get(ReklamacijeSearchRequest request);
        Model.Reklamacije GetById(int id);
        Model.Reklamacije Insert(ReklamacijeInsertRequest request);
        Model.Reklamacije Update(int id, ReklamacijeInsertRequest request);
    }
}
