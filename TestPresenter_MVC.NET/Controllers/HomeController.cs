using EXP.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestPresenter_MVC.NET.Controllers
{
    public class HomeController : Controller
    {
        PresenterModelVue p;
        

        [HttpGet]
        [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index(ObjectModel model, string command)
        {

            p = new PresenterModelVue(model);
           

            //Valide si il faut executer une commande
            if (command != null)
            {
                
                p.Start(false);
                model.ExecuteCommand(command);
            }
            else
            {
                p.Start();
            }


            ViewBag.ViewLogics = model.ViewLogics;

            //Execute les redirections si la logique de présentation à déterminer un GoForm en passant des donnees au formulaires
            if (model.ViewLogics.GoForm != null)
                return View(model.ViewLogics.GoForm.Item1, model.ViewLogics.GoForm.Item2[0]);

            return View(model);
        }
        
        
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
