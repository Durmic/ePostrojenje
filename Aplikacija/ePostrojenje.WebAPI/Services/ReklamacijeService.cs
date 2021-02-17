using AutoMapper;
using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public class ReklamacijeService : IReklamacijeService
    {
        private readonly _150217Context _context;
        private readonly IMapper _mapper;
        public ReklamacijeService(_150217Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        public List<Model.Reklamacije> Get(ReklamacijeSearchRequest request)
        {
                var query = _context.Reklamacije.AsQueryable();

                var list = query.ToList();

                return _mapper.Map<List<Model.Reklamacije>>(list);
            

        }

        public Model.Reklamacije GetById(int id)
        {
            var entity = _context.Reklamacije.Find(id);

            return _mapper.Map<Model.Reklamacije>(entity);
        }

        public Model.Reklamacije Insert(ReklamacijeInsertRequest request)
        {
            var entity = _mapper.Map<Database.Reklamacije>(request);


            _context.Reklamacije.Add(entity);
            _context.SaveChanges();

            _context.SaveChanges();

            return _mapper.Map<Model.Reklamacije>(entity);
        }

        public Model.Reklamacije Update(int id, ReklamacijeInsertRequest request)
        {
            var entity = _context.Reklamacije.Find(id);
            _context.Reklamacije.Attach(entity);
            _context.Reklamacije.Update(entity);
            Database.Ocjene ocjena = new Database.Ocjene();
            ocjena.Ocjena = 1;
            ocjena.OsobljeId = request.OsobljeId;
            ocjena.ReklamacijaId = id;
            ocjena.Datum = DateTime.Today;
            var status = _context.Ocjene.Where(x => x.ReklamacijaId == id).ToList();
            if ((request.Status == true) && (status.Count() == 0))
                _context.Ocjene.Add(ocjena);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Reklamacije>(entity);
        }
    }

   
}
