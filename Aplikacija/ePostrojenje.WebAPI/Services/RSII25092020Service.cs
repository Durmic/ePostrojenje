using AutoMapper;
using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public class RSII25092020Service : IRSII25092020Service
    {
        private readonly _150217Context _context;
        private readonly IMapper _mapper;
        public RSII25092020Service(_150217Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Model.RSII25092020> Get(RSII25092020SearchRequest request)
        {
            var query = _context.Rsii25092020.AsQueryable();

            if (request.DatumOd != DateTime.MinValue && request.DatumDo != DateTime.MaxValue && request.DatumOd.Ticks < request.DatumDo.Ticks)
            {
                query = query.Where(x => x.DatumLogiranja.Ticks <= request.DatumDo.Ticks && x.DatumLogiranja.Ticks >= request.DatumOd.Ticks);
            }

            query = query.Where(x => x.KupacId == request.KupacId);

            query = query.Where(x => x.PotencijalnoMaliciozan == request.PotencijalnoMaliciozan);

            var list = query.ToList();

            return _mapper.Map<List<Model.RSII25092020>>(list);
        }

        public Model.RSII25092020 GetById(int id)
        {
            var entity = _context.Rsii25092020.Find(id);

            return _mapper.Map<Model.RSII25092020>(entity);
        }

        public RSII25092020 Insert(RSII25092020InsertRequest request)
        {
            var entity = _mapper.Map<Database.Rsii25092020>(request);


            _context.Rsii25092020.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.RSII25092020>(entity);
        }

        public RSII25092020 Update(int id, RSII25092020InsertRequest request)
        {
            var entity = _context.Rsii25092020.Find(id);
            _context.Rsii25092020.Attach(entity);
            _context.Rsii25092020.Update(entity);
            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.RSII25092020>(entity);
        }
    }
}
