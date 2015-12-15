using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core;
using MKS.Core.Presenter.UI;
using MKS.Core.Presenter.Interfaces;

namespace EXP.Presenter
{
    /// <summary>
    /// Définition de la vue pour l'interface utilisateur. Elle doit correspondre à ce que l'on veut transmettre et lire de l'interface utilisateur.
    /// Le IView contient des opérations de base utiles au Processus de présentation.    
    /// 
    /// Les éléments UI définit (Label, Input, Button...) son simplement des facilitants d'intégration avec l'interface utilisateur.
    /// </summary>
    /// <remarks>
    /// La vue est necéssaire et peut importe le pattern d'intégration de l'interface utilisateur (MVP, MVC, MVVM etc..)     
    /// </remarks>
    public interface IModelVue:IView
    {
        Label LabelIdentifiant { get; set; }
        Label LabelNom { get; set; }
        Label LabelPrenom { get; set; }
        Label LabelTelephone { get; set; }
        Input Nom { get; set; }
        Input Prenom { get; set; }
        Input Telephone { get; set; }
        Button Sauvegarder { get; set; }
        Button About { get; set; }
    }
}
