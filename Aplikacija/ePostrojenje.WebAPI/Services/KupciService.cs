﻿using AutoMapper;
using ePostrojenje.Model;
using ePostrojenje.Model.Requests;
using ePostrojenje.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Services
{
    public class KupacService : IKupciService
    {
        private readonly _150217Context _context;
        private readonly IMapper _mapper;
        public KupacService(_150217Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.Kupci Authenticiraj(string username, string pass)
        {
            var user = _context.Kupci.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var newHash = GenerateHash(user.LozinkaSalt, pass);

                if (newHash == user.LozinkaHash)
                {
                    return _mapper.Map<Model.Kupci>(user);
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

        public List<Model.Kupci> Get(KupciSearchRequest request)
        {
            var query = _context.Kupci.AsQueryable();

            if (!string.IsNullOrWhiteSpace(request?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(request.Ime));
            }
            if (!string.IsNullOrWhiteSpace(request?.KorisnickoIme))
            {
                query = query.Where(x => x.KorisnickoIme.Equals(request.KorisnickoIme));
            }
            if (!string.IsNullOrWhiteSpace(request?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(request.Prezime));
            }

            /*if (request?.IsUlogeLoadingEnabled == true)
            {
                query = query.Include(x => x.KupciUloge);
            }*/

            var list = query.ToList();

            return _mapper.Map<List<Model.Kupci>>(list);
        }

        public Model.Kupci GetById(int id)
        {
            var entity = _context.Kupci.Find(id);

            return _mapper.Map<Model.Kupci>(entity);
        }

        public Model.Kupci Insert(KupciInsertRequest request)
        {
            var entity = _mapper.Map<Database.Kupci>(request);

            if (request.Password != request.PasswordConfirmation)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Kupci.Add(entity);
            _context.SaveChanges();

            return _mapper.Map<Model.Kupci>(entity);
        }

        public Model.Kupci Update(int id, KupciInsertRequest request)
        {
            var entity = _context.Kupci.Find(id);
            _context.Kupci.Attach(entity);
            _context.Kupci.Update(entity);
            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.Kupci>(entity);
        }
    }
}
