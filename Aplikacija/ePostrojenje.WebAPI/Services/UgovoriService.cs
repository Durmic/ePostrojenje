using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Database;

namespace ePostrojenje.WebAPI.Services
{
    public class UgovoriService : BaseCRUDService<Model.Ugovori, Model.Ugovori, Database.Ugovori, UgovoriUpdateRequest, UgovoriUpdateRequest>
    {
        private readonly _150217Context _context;
        private readonly IMapper _mapper;
        public UgovoriService(_150217Context context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }



        public override List<Model.Ugovori> Get(Model.Ugovori search)
        {
            var query = _context.Ugovori.AsQueryable();


            if (search.DatumOd != DateTime.MinValue && search.DatumDo != DateTime.MaxValue && search.DatumOd.Ticks < search.DatumDo.Ticks)
            {
                query = query.Where(x => x.DatumSklapanja.Ticks <= search.DatumDo.Ticks && x.DatumSklapanja.Ticks >= search.DatumOd.Ticks);
            }
            //return base.Get(search);
            var list = query.ToList();

            return _mapper.Map<List<Model.Ugovori>>(list);
        }
    }
}
