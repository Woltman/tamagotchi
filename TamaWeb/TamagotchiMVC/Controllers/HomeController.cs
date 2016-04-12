using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TamagotchiMVC.Models;

namespace TamagotchiMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var client = new TamagotchiServiceClient.TamagotchiServiceClient())
            {
                var tamagotchiItems = client.GetAll();

                var tamagotchis = new List<TamagotchiItemViewModel>();

                foreach(var tam in tamagotchiItems)
                {
                    tamagotchis.Add(new TamagotchiItemViewModel(tam));
                }
                return View(tamagotchis);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AddTamagotchi model)
        {
            using (var client = new TamagotchiServiceClient.TamagotchiServiceClient())
            {
                if (ModelState.IsValid)
                {
                    if (model.Name.Length >= 3 && model.Name.Length <= 20)
                    {
                        client.AddTamagotchi(model.Name);
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Naam moet tussen de 3 en 20 karakters lang zijn");
                    }
                }
                return View();
            }
        }

        public ActionResult Details(int ID)
        {
            using (var client = new TamagotchiServiceClient.TamagotchiServiceClient())
            {
                var tamagotchiDTO = client.GetTamagotchiDTO(ID);
                var tamagotchi = new TamagotchiDTOViewModel(tamagotchiDTO);

                return View(tamagotchi);
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}