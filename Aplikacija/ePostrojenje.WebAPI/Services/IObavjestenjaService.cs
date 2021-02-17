using ePostrojenje.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public interface IObavjestenjaService
    {
        List<Model.Obavjestenja> Get(ObavjestenjaSearchRequest request);
        Model.Obavjestenja GetById(int id);
        Model.Obavjestenja Insert(ObavjestenjaInsertRequest request);
        Model.Obavjestenja Update(int id, ObavjestenjaInsertRequest request);
    }
}
