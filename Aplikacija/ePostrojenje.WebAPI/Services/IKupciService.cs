using ePostrojenje.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public interface IKupciService
    {
        List<Model.Kupci> Get(KupciSearchRequest request);
        Model.Kupci GetById(int id);
        Model.Kupci Insert(KupciInsertRequest request);
        Model.Kupci Authenticiraj(string username, string pass);

        Model.Kupci Update(int id, KupciInsertRequest request);
    }
}
