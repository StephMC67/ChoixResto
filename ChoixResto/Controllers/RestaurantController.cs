using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChoixResto.Models;

namespace ChoixResto.Controllers
{
    public class RestaurantController : Controller
    {
        // GET: Restaurant
        public ActionResult Index()
        {
            using (IDal dal = new Dal())
            {
                List<Resto> listeDesRestaurants = dal.ObtientTousLesRestaurants();
                return View(listeDesRestaurants);
            }
        }

        //public ActionResult ModifierRestaurant()
        //{
        //    string id = Request.Url.AbsolutePath.Split('/').Last();
        //    ViewBag.Id = id;
        //    return View();
        //}   

        //public ActionResult ModifierRestaurant(string id)
        //{
        //    ViewBag.Id = id;
        //    return View();
        //}

        //public ActionResult ModifierRestaurant(int? id)
        //{
        //    if (id.HasValue)
        //    {
        //        ViewBag.Id = id;
        //        return View();
        //    }
        //    else
        //        return View("Error");
        //}

        //public ActionResult ModifierRestaurant()
        //{
        //    string idStr = Request.QueryString["id"];
        //    int id;
        //    if (int.TryParse(idStr, out id))
        //    {
        //        ViewBag.Id = id;
        //        return View();
        //    }
        //    else
        //        return View("Error");
        //}

        //public ActionResult ModifierRestaurant(int? id)
        //{
        //    if (id.HasValue)
        //    {
        //        using (IDal dal = new Dal())
        //        {
        //            if (Request.HttpMethod == "POST")
        //            {
        //                string nouveauNom = Request.Form["Nom"];
        //                string nouveauTelephone = Request.Form["Telephone"];
        //                dal.ModifierRestaurant(id.Value, nouveauNom, nouveauTelephone);
        //            }

        //            Resto restaurant = dal.ObtientTousLesRestaurants().FirstOrDefault(r => r.Id == id.Value);
        //            if (restaurant == null)
        //                return View("Error");
        //            return View(restaurant);
        //        }
        //    }
        //    else
        //        return View("Error");

        //}

        //public ActionResult ModifierRestaurant(int? id, string nom, string telephone)
        //{
        //    if (id.HasValue)
        //    {
        //        using (IDal dal = new Dal())
        //        {
        //            if (Request.HttpMethod == "POST")
        //            {
        //                dal.ModifierRestaurant(id.Value, nom, telephone);
        //            }

        //            Resto restaurant = dal.ObtientTousLesRestaurants().FirstOrDefault(r => r.Id == id.Value);
        //            if (restaurant == null)
        //                return View("Error");
        //            return View(restaurant);
        //        }
        //    }
        //    else
        //        return View("Error");
        //}


        public ActionResult ModifierRestaurant(int? id)
        {
            if (id.HasValue)
            {
                using (IDal dal = new Dal())
                {
                    Resto restaurant = dal.ObtientTousLesRestaurants().FirstOrDefault(r => r.Id == id.Value);
                    if (restaurant == null)
                        return View("Error");
                    return View(restaurant);
                }
            }
            else
                return View("Error");
        }

        //[HttpPost]
        //public ActionResult ModifierRestaurant(int? id, string nom, string telephone)
        //{
        //    if (id.HasValue)
        //    {
        //        using (IDal dal = new Dal())
        //        {
        //            dal.ModifierRestaurant(id.Value, nom, telephone);
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    else
        //        return View("Error");
        //}


            // binding de modele automatique MVC 4
        [HttpPost]
        public ActionResult ModifierRestaurant(Resto resto)
        {

            //if (string.IsNullOrWhiteSpace(resto.Nom))
            //{
            //    ViewBag.MessageErreur = "Le nom du restaurant doit être rempli";
            //    return View(resto);
            //}

            //if (!ModelState.IsValid)
            //{
            //    ViewBag.MessageErreur = ModelState["Nom"].Errors[0].ErrorMessage;
            //    return View(resto);
            //}

            if (!ModelState.IsValid)
                return View(resto);

            using (IDal dal = new Dal())
            {
                dal.ModifierRestaurant(resto.Id, resto.Nom, resto.Telephone);
                return RedirectToAction("Index");
            }
        }

    }
}