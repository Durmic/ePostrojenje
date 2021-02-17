using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Database;
using Microsoft.EntityFrameworkCore;

namespace ePostrojenje.WebAPI.Services
{
    public class OsobljeService : IOsobljeService
    {
        private readonly _150217Context _context;
        private readonly IMapper _mapper;
        public OsobljeService(_150217Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Osoblje Authenticiraj(string username, string pass)
        {
            var user = _context.Osoblje.FirstOrDefault(x => x.KorisnickoIme == username);
            var vrstaApp = _context.VrstaAplikacije.First();

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Osoblje>(user);
                }
            }
            return null;
        }

        public Model.Osoblje AuthenticirajOdgovor(string username, string odgovor)
        {
            var user = _context.Osoblje.FirstOrDefault(x => x.KorisnickoIme == username);
            //var vrstaApp = _context.VrstaAplikacije.First();

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, odgovor);

                if (newHash == user.Odgovor)
                {
                    return _mapper.Map<Model.Osoblje>(user);
                }
            }
            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }

        public List<Model.Osoblje> Get(OsobljeSearchRequest request)
        {
            var query = _context.Osoblje.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }

            if (!string.IsNullOrWhiteSpace(request?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.Equals(request.KorisnickoIme));
            }

            if (!string.IsNullOrWhiteSpace(request?.Odgovor))
            {
                query = query.Where(x => x.Ime.Equals(request.Odgovor));
            }

            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            if (request.DatumOd != DateTime.MinValue && request.DatumDo != DateTime.MaxValue && request.DatumOd.Ticks < request.DatumDo.Ticks)
            {
                query = query.Where(x => x.DatumRodjenja.Ticks <= request.DatumDo.Ticks && x.DatumRodjenja.Ticks >= request.DatumOd.Ticks);
            }

            /*if (request?.IsUlogeLoadingEnabled == true)
            {
                query = query.Include(x => x.OsobljeUloge);
            }*/

            var list = query.ToList();

            return _mapper.Map<List<Model.Osoblje>>(list);
        }

        public Model.Osoblje GetById(int id)
        {
            var entity = _context.Osoblje.Find(id);

            return _mapper.Map<Model.Osoblje>(entity);
        }

        public Model.Osoblje Insert(OsobljeInsertRequest request)
        {
            var entity = _mapper.Map<Database.Osoblje>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Osoblje.Add(entity);
            _context.SaveChanges();

            foreach(var odjel in request.Odjeli)
            {
                Database.OdjeliOsoblje odjeliOsoblje= new Database.OdjeliOsoblje();
                odjeliOsoblje.OsobljeId = entity.OsobljeId;
                odjeliOsoblje.OdjelId = odjel;
                _context.OdjeliOsoblje.Add(odjeliOsoblje);
            }

            _context.SaveChanges();

            return _mapper.Map<Model.Osoblje>(entity);
        }

        public Model.Osoblje Update (int id, OsobljeInsertRequest request)
        {
            var entity = _context.Osoblje.Find(id);
            _context.Osoblje.Attach(entity);
            _context.Osoblje.Update(entity);

            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordConfirmation)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            //entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Osoblje>(entity);
        }
    }
}
