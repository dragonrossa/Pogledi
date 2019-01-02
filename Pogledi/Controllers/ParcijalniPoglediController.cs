using Pogledi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pogledi.Controllers
{
    public class ParcijalniPoglediController : Controller
    {
        // GET: ParcijalniPogledi
        public ViewResult PrikaziKosaricu()
        {
            List<Artikl> lArtikl = new List<Artikl>()
            {
                new Artikl()  {Naziv = "Kruh", Cijena=8.9m, Kolicina=3},
                new Artikl()  { Naziv = "Mlijeko", Cijena = 9.9m, Kolicina = 2 },
                new Artikl()  { Naziv = "Jabuka", Cijena = 5m, Kolicina = 1 },

            };
            return View(lArtikl);
        }
    }
}