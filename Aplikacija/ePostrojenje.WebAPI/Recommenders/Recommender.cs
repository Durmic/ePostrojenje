using ePostrojenje.Model;
using ePostrojenje.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.AspNetCore.Hosting.Internal.HostingApplication;


namespace ePostrojenje.WebAPI.Recommenders
{
    public class Recommender
    {
         private readonly _150217Context _context = new _150217Context();
        
         Dictionary<int, List<Database.Ocjene>> reklamacije = new Dictionary<int, List<Database.Ocjene>>();
         // Reklamacije_Result
         public List<Database.Reklamacije> GetSlicneReklamacije(int reklamacijaID)
         {
             UcitajReklamacije(reklamacijaID);
             List<Database.Ocjene> ocjenePosmatraneReklamacije =  _context.Ocjene.Where(x => x.ReklamacijaId == reklamacijaID).OrderBy(x => x.OsobljeId).ToList();
             List<Database.Ocjene> zajednickeOcjene1 = new List<Database.Ocjene>();
             List<Database.Ocjene> zajednickeOcjene2 = new List<Database.Ocjene>();
             List<Database.Reklamacije> preporuceneReklamacije = new List<Database.Reklamacije>();

             foreach (var item in reklamacije)
             {

                 foreach (Database.Ocjene o in ocjenePosmatraneReklamacije)
                 {
                     if (item.Value.Where(x => x.OsobljeId == o.OsobljeId).Count() > 0)
                     {
                         zajednickeOcjene1.Add(o);
                         zajednickeOcjene2.Add(item.Value.Where(x => x.OsobljeId == o.OsobljeId).First());
                     }
                 }
                 double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);
                var param = new SqlParameter("@ReklamacijaID", item.Key);
                if (slicnost > 0.5)
                    preporuceneReklamacije.Add(_context.Reklamacije.FromSql("esp_Reklamacije_SelectById @ReklamacijaID", param).FirstOrDefault());
                    //preporuceneReklamacije.Add(_context.esp_Reklamacije_SelectById(item.Key).FirstOrDefault());
                 zajednickeOcjene1.Clear();
                 zajednickeOcjene2.Clear();
             }
             return preporuceneReklamacije;
         }

         private double GetSlicnost(List<Database.Ocjene> zajednickeOcjene1, List<Database.Ocjene> zajednickeOcjene2)
         {
             if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
                 return 0;

             double brojnik = 0, nazivnik1 = 0, nazivnik2 = 0;

             for (int i = 0; i < zajednickeOcjene1.Count; i++)
             {
                 brojnik = zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                 nazivnik1 = zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                 nazivnik2 = zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;
             }
             nazivnik1 = Math.Sqrt(nazivnik1);
             nazivnik2 = Math.Sqrt(nazivnik2);

             double nazivnik = nazivnik1 * nazivnik2;
             if (nazivnik == 0)
                 return 0;
             return brojnik / nazivnik;
         }

         private void UcitajReklamacije(int reklamacijaID)
         {
             // Reklamacije_Result
             List<Database.Reklamacije> aktivneReklamacije = _context.Reklamacije.Where(x => x.ReklamacijaId != reklamacijaID).ToList();
             // Model.Ocjene
             List<Database.Ocjene> ocjene = new List<Database.Ocjene>();

             foreach (Database.Reklamacije item in aktivneReklamacije)
             {
                 ocjene = _context.Ocjene.Where(x => x.ReklamacijaId == item.ReklamacijaId).OrderBy(x => x.OsobljeId).ToList();
                 if (ocjene.Count > 0)
                     reklamacije.Add(item.ReklamacijaId, ocjene);
             }
         }
    }
}
