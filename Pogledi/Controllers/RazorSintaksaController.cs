using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pogledi.Controllers
{
    public class RazorSintaksaController : Controller
    {
        // GET: RazorSintaksa
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult SwitchView()
        {
            return View();
        }

        public ViewResult ForView()
        {
            string[] voce = { "Jabuka", "Kruska", "Limun", "Banana" };
            return View(voce);
        }

        public ViewResult WhileView()
        {
            return View();
        }
    }
}