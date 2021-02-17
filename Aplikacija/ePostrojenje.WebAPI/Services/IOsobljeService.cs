using ePostrojenje.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public interface IOsobljeService
    {
        List<Model.Osoblje> Get(OsobljeSearchRequest request);
        Model.Osoblje GetById(int id);
        Model.Osoblje Insert(OsobljeInsertRequest request);
        Model.Osoblje Authenticiraj(string username, string pass);
        Model.Osoblje Update(int id, OsobljeInsertRequest request);
    }
}
