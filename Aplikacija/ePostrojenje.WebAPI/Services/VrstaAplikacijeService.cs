using AutoMapper;
using ePostrojenje.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public class VrstaAplikacijeService : BaseCRUDService<Model.VrstaAplikacije, Model.VrstaAplikacije, Database.VrstaAplikacije, Model.Requests.VrstaAplikacijeInsert, Model.Requests.VrstaAplikacijeInsert>
    {
        public VrstaAplikacijeService(_150217Context context, IMapper mapper) : base(context, mapper)
        {
        }

        /*public override List<Model.Racuni> Get(RacuniSearchRequest search = null)
        {
            var query = _context.Racuni.AsQueryable();

            if (search?.KupacId.HasValue == true)
            {
                query = query.Where(x => x.KupacId == search.KupacId);
            }

            var list = query.OrderByDescending(x => x.DatumRacuna).ToList();

            return _mapper.Map<List<Model.Racuni>>(list);
        }*/
    }
}
