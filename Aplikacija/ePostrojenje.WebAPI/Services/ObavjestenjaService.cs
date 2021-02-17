using AutoMapper;
using ePostrojenje.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using ePostrojenje.Model;
using System.Threading.Tasks;
using ePostrojenje.Model.Requests;

namespace ePostrojenje.WebAPI.Services
{
    

    public class ObavjestenjaService : IObavjestenjaService
    {
        private readonly _150217Context _context;
        private readonly IMapper _mapper;

        public ObavjestenjaService(_150217Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.Obavjestenja> Get(ObavjestenjaSearchRequest request)
        {
            
            var query = _context.Obavjestenja.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Naslov))
            {
                query = query.Where(x => x.Naslov.StartsWith(request.Naslov));
            }

            

            if (request.DatumOd!=DateTime.MinValue && request.DatumDo!=DateTime.MaxValue && request.DatumOd.Ticks < request.DatumDo.Ticks)
            {
                query = query.Where(x => x.DatumPocetka.Ticks <= request.DatumDo.Ticks && x.DatumPocetka.Ticks >= request.DatumOd.Ticks);
            }

            /*if (request?.IsUlogeLoadingEnabled == true)
            {
                query = query.Include(x => x.OsobljeUloge);
            }*/

            var list = query.ToList();

            return _mapper.Map<List<Model.Obavjestenja>>(list);
        }

        public Model.Obavjestenja GetById(int id)
        {
            var entity = _context.Obavjestenja.Find(id);

            return _mapper.Map<Model.Obavjestenja>(entity);
        }

        public Model.Obavjestenja Insert(ObavjestenjaInsertRequest request)
        {
            var entity = _mapper.Map<Database.Obavjestenja>(request);


            _context.Obavjestenja.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Obavjestenja>(entity);
        }

        public Model.Obavjestenja Update(int id, ObavjestenjaInsertRequest request)
        {
            var entity = _context.Obavjestenja.Find(id);
            _context.Obavjestenja.Attach(entity);
            _context.Obavjestenja.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Obavjestenja>(entity);
        }
    }
}
