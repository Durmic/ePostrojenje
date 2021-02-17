using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ePostrojenje.WebAPI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<Database.Osoblje, Model.Osoblje>();
            CreateMap<Database.Osoblje, Model.Requests.OsobljeInsertRequest>().ReverseMap();
            CreateMap<Database.Osoblje, Model.Requests.OsobljeUpdateRequest>().ReverseMap();

            CreateMap<Database.OdjeliOsoblje, Model.OdjeliOsoblje>();

            CreateMap<Database.Odjeli, Model.Odjeli>();

            CreateMap<Database.TarifniStavovi, Model.TarifniStavovi>();

            CreateMap<Database.Sluzbe, Model.Sluzbe>();

            CreateMap<Database.Obavjestenja, Model.Obavjestenja>();
            CreateMap<Database.Obavjestenja, Model.Requests.ObavjestenjaInsertRequest>().ReverseMap();

            CreateMap<Database.Kupci, Model.Kupci>();
            CreateMap<Model.Requests.KupciSearchRequest, Model.Kupci>().ReverseMap();
            CreateMap<Database.Kupci, Model.Requests.KupciInsertRequest>().ReverseMap();

            CreateMap<Database.Rsii25092020, Model.RSII25092020>();
            CreateMap<Model.Requests.RSII25092020SearchRequest, Model.RSII25092020>().ReverseMap();
            CreateMap<Database.Rsii25092020, Model.Requests.RSII25092020InsertRequest>().ReverseMap();

            CreateMap<Database.Reklamacije, Model.Reklamacije>();
            CreateMap<Database.Reklamacije, Model.Requests.ReklamacijeInsertRequest>().ReverseMap();

            CreateMap<Database.Racuni, Model.Racuni>();
            CreateMap<Database.Racuni, Model.Requests.RacuniInsertRequest>().ReverseMap();

            CreateMap<Database.VrstaAplikacije, Model.VrstaAplikacije>();
            CreateMap<Database.VrstaAplikacije, Model.Requests.VrstaAplikacijeInsert>().ReverseMap();

            CreateMap<Database.Ugovori, Model.Ugovori>();
            CreateMap<Database.Ugovori, Model.Requests.UgovoriUpdateRequest>().ReverseMap();

            CreateMap<Database.Ocjene, Model.Ocjene>();
            CreateMap<Database.Ocjene, Model.Requests.OcjeneUpdateRequest>().ReverseMap();
            //CreateMap<Model.Requests.UgovoriUpdateRequest, Model.Ugovori>();

        }
    }
}
