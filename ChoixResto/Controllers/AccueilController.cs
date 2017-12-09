using ChoixResto.Models;
using ChoixResto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChoixResto.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Accueil
        public ActionResult Index()
        {
            /*
            ViewData["message"] = "Bonjour depuis le contrôleur";
            ViewData["date"] = DateTime.Now;
            ViewData["resto"] = new Resto { Nom = "Choucroute party", Telephone = "1234" };
            
            //return View("Bonjour");
            return View();
            */
            //ViewData["message"] = "Bonjour depuis le contrôleur";
            //ViewData["date"] = DateTime.Now;
            //Resto r = new Resto { Nom = "La bonne fourchette", Telephone = "1234" };
            //return View(r);

            //AccueilViewModel vm = new AccueilViewModel
            //{
            //    Message = "Bonjour depuis le contrôleur",
            //    Date = DateTime.Now,
            //    Resto = new Resto { Nom = "La bonne fourchette", Telephone = "1234" }
            //};
            //return View(vm);

            //AccueilViewModel vm = new AccueilViewModel
            //{
            //    Message = "Bonjour depuis le <span style=\"color:red\">contrôleur</span>",
            //    Date = DateTime.Now,
            //    Login = "Stéphane",
            //    ListeDesRestos = new List<Resto>
            //    {
            //        new Resto { Nom = "Resto pinambour", Telephone = "1234" },
            //        new Resto { Nom = "Resto tologie", Telephone = "1234" },
            //        new Resto { Nom = "Resto ride", Telephone = "5678" },
            //        new Resto { Nom = "Resto toro", Telephone = "555" },
            //    }
            //};
            //return View(vm);

            //List<Models.Resto> listeDesRestos = new List<Resto>
            //{
            //    new Resto { Id = 1, Nom = "Resto pinambour", Telephone = "1234" },
            //    new Resto { Id = 2, Nom = "Resto tologie", Telephone = "1234" },
            //    new Resto { Id = 5, Nom = "Resto ride", Telephone = "5678" },
            //    new Resto { Id = 9, Nom = "Resto toro", Telephone = "555" },
            //};

            //ViewBag.ListeDesRestos = new SelectList(listeDesRestos, "Id", "Nom");

            //return View();

            AccueilViewModel vm = new AccueilViewModel
            {
                Message = "Bonjour depuis le <span style=\"color:red\">contrôleur</span>"
            };
            return View(vm);
        }

        [ChildActionOnly]
        public ActionResult AfficheListeRestaurant()
        {
            List<Models.Resto> listeDesRestos = new List<Resto>
    {
        new Resto { Id = 1, Nom = "Resto pinambour", Telephone = "1234" },
        new Resto { Id = 2, Nom = "Resto tologie", Telephone = "1234" },
        new Resto { Id = 5, Nom = "Resto ride", Telephone = "5678" },
        new Resto { Id = 9, Nom = "Resto toro", Telephone = "555" },
    };
            return PartialView(listeDesRestos);
        }
    }
}