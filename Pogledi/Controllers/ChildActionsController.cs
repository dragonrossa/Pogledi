using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pogledi.Controllers
{
    public class ChildActionsController : Controller
    {
        // GET: ChildActions
        public ViewResult ChildActionView()
        {
            string[] proizvodi = new string[] { "Banana", "Brokula", "Mandarina", "Limun" , "Mrkva" };
            return View(proizvodi);
        }

        [ChildActionOnly]
        public string OdrediGrupuProizvoda(string proizvod)
        {
            switch (proizvod)
            {
                case "Banana":
                case "Limun":
                    return "Voće";
                case "Brokula":
                case "Mrkva":
                    return "Povrce";
                default:
                    return "Nepoznato";

            }
            
        }
    }
}