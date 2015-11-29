using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core;
using MKS.Core.Presenter;
using MKS.Core.Presenter.UI;

using EXP.Model;
using EXP.Service;

namespace EXP.Presenter
{
    public class ProcessPresenter:Process<IModelVue>
    {

        public override void Initialisation(bool isInit,IModelVue view, MKS.Core.Presenter.Interfaces.IPresenter presenter)
        {
            //Initialisation des controles libellés          
            view.LabelNom = new Label("Nom");
            view.LabelPrenom = new Label("Prénom");
            view.LabelTelephone = new Label("Téléphone");
            
            //Si true Charge les valeurs par défaut.
            if(isInit)
                view.Telephone = new Input("418-571-2268");

            
            Button bt = new Button("Sauvegarder");
            bt.Command = "Sauvegarder";
            view.Sauvegarder = bt;

            Button btAbout = new Button("Apropos");
            btAbout.Command = "About";
            btAbout.Enabled = false;
            view.About = btAbout;


        }
        //Fonction appeler lorsque la commande du boutton sauvegardé sera lancer.
        public void Sauvegarder(CommandEventArgsCustom args, IModelVue view, MKS.Core.Presenter.Interfaces.IPresenter presenter)
        {
            ObjetModel obj = new ObjetModel();
            obj.Nom = view.Nom.Text;
            obj.Prenom = view.Prenom.Text;
            obj.Telephone = view.Telephone.Text;

            ServiceMetier s = new ServiceMetier();
            s.Ajouter(obj);

            //si il n'y a aucune erreur le processus continue et affiche le message suivant. 
            view.ShowMessage("Information","Ajout avec succes", Severity.Success);
            
            //Reactive le bouton About
            Button btAbout = new Button("Apropos");
            btAbout.Command = "About";
            btAbout.Enabled = true;
            view.About = btAbout;
        }
        
        public void About(CommandEventArgsCustom args, IModelVue view, MKS.Core.Presenter.Interfaces.IPresenter presenter)
        {
            view.Navigate(view.About.Command,view);
            
        }
        
    }
}
