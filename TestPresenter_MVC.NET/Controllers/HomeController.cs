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
            //
            p = new PresenterModelVue(model);
           

            //Valide si il faut executer une commande
            if (command != null)
            {

                //Démarre le présenteur et demande de ne pas réinitialiser certaine valeur
                p.Start(false); 
                //Appel à la fonction du processus de présentation en fonction de la commande, Le nom de la commande doit être identique à l'opération définit.
                model.ExecuteCommand(command); 
            }
            else
            {
                p.Start();
            }

            //Assigne le résultat du view logique qui contient l'ensemble des informations du résultat d'exécution du processus
            // Pour le passer au _layout.chtml qui détermine en fonction des résultats l'affichage des messages.
            ViewBag.ViewLogics = model.ViewLogics;

            //Execute les redirections si le processus de présentation à demandé une Navigation.
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
