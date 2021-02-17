using ePostrojenje.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public interface IRSII25092020Service
    {
        List<Model.RSII25092020> Get(RSII25092020SearchRequest request);
        Model.RSII25092020 GetById(int id);
        Model.RSII25092020 Insert(RSII25092020InsertRequest request);
        Model.RSII25092020 Update(int id, RSII25092020InsertRequest request);
    }
}
