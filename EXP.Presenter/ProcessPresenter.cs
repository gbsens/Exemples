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
    /// <summary>
    /// Le processs de présentation permet contient l'ensemble de la logique de présentation sans tenir compte de la technologie utilisé par l'interface utilisateur.
    /// </summary>
    public class ProcessPresenter:Process<IModelVue>
    {
        
        /// <summary>
        /// Processus d'initialisation d'une vue au démarrage du Presenteur.
        /// L'initialisation permet d'assigner les Libellés, les valeurs par défaut etc..
        /// Ce processus de présentation peut être utilisé dans n'importe quelle type d'interface utilisateur.        
        /// </summary>
        /// <param name="isInit">Indique si on doit initialiser certain appel au fonction. 
        /// Par exemple, dans ce cas si, une données par défaut est placé dans le numéro de téléphone.
        /// </param>
        /// <param name="view">Vue incluant les données en provenance de l'interface utilisateur</param>
        /// <param name="presenter">Offre un accès au présenteur parent</param>
        public override void Initialisation(bool isInit,IModelVue view, MKS.Core.Presenter.Interfaces.IPresenter presenter)
        {
            //Initialisation des controles libellés          
            view.LabelNom = new Label("Nom");
            view.LabelPrenom = new Label("Prénom");
            view.LabelTelephone = new Label("Téléphone");
            view.LabelIdentifiant = new Label("0");
            //Si true Charge les valeurs par défaut.
            if(isInit)
                view.Telephone = new Input("418-830-3407");

            
            Button bt = new Button("Sauvegarder");
            bt.Command = "Sauvegarder"; //Commande qui sera envoyer par l'interface utilisateur
            view.Sauvegarder = bt;

            Button btAbout = new Button("Apropos");
            btAbout.Command = "About";//Commande qui sera envoyer par l'interface utilisateur
            btAbout.Enabled = false;
            view.About = btAbout;


        }        
        /// <summary>
        /// Fonction appeler lorsque la commande du boutton sauvegardé est lancer. La signature dois être conforme, a celle présenté dans l'exemple.
        /// </summary>
        /// <param name="args">Arguments qui peuvent provenir de l'interface utilisateur lors de l'envois de la commande</param>
        /// <param name="view">Vue incluant les données en provenance de l'interface utilisateur</param>
        /// <param name="presenter">Offre un accès au présenteur parent</param>
        public void Sauvegarder(CommandEventArgsCustom args, IModelVue view, MKS.Core.Presenter.Interfaces.IPresenter presenter)
        {
            ObjContact obj = new ObjContact();
            obj.Nom = view.Nom.Text;
            obj.Prenom = view.Prenom.Text;
            obj.Telephone = view.Telephone.Text;

            ServiceMetier s = new ServiceMetier();
            obj=s.Ajouter(obj);

            //si il n'y a aucune erreur le processus continue et affiche le message suivant. 
            view.ShowMessage("Information","Ajout avec succes", Severity.Success);

            //Assigne l'identifiant à la vue.
            view.LabelIdentifiant = new Label(obj.Id.ToString());

            //Reactive le bouton About
            Button btAbout = new Button("Apropos");
            btAbout.Command = "About";
            btAbout.Enabled = true;
            view.About = btAbout;
        }
        
        //Fonction appelé lorsque la commande About est lancé
        public void About(CommandEventArgsCustom args, IModelVue view, MKS.Core.Presenter.Interfaces.IPresenter presenter)
        {
            //Permet de naviguer dans d'autre formulaire web, forms ou autres en fonction des la commandes.
            //La définition de la navigation est e fonction de la technologie d'interface utilisateur
            //Dans les deux exemples le Global.asax pour le UI TestPresenter contient la navigation            

            Dictionary<string,object> d=new Dictionary<string,object>();
            d.Add("VIEW",view);
            view.Navigate(view.About.Command,d);
        }
        
    }
}
