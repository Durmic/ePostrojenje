using AutoMapper;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public class OcjeneService : BaseCRUDService<Model.Ocjene, Model.Ocjene, Database.Ocjene, OcjeneUpdateRequest, OcjeneUpdateRequest>
    {
        public OcjeneService(_150217Context context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Ocjene> Get(Model.Ocjene search)
        {
            var query = _context.Ocjene.AsQueryable();

            if (search.OsobljeId!=null)
            
                query = query.Where(x => x.OsobljeId == search.OsobljeId);

            
            //return base.Get(search);
            var list = query.ToList();

            return _mapper.Map<List<Model.Ocjene>>(list);
        }
    }
}
