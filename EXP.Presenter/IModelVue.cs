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
    public interface IModelVue:IView
    {
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
