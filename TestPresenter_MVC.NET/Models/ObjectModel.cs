using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MKS.Web;

namespace EXP.Presenter
{
    public class ObjectModel:View, IModelVue
    {
        public MKS.Core.Presenter.UI.Label LabelNom
        {
            get;
            set;
        }

        public MKS.Core.Presenter.UI.Label LabelPrenom
        {
            get;
            set;
        }

        public MKS.Core.Presenter.UI.Label LabelTelephone
        {
            get;
            set;
        }

        public MKS.Core.Presenter.UI.Input Nom
        {
            get;
            set;
        }

        public MKS.Core.Presenter.UI.Input Prenom
        {
            get;
            set;
        }

        public MKS.Core.Presenter.UI.Input Telephone
        {
            get;
            set;
        }

        public MKS.Core.Presenter.UI.Button Sauvegarder
        {
            get;
            set;
        }


        public MKS.Core.Presenter.UI.Button About
        {
            get;
            set;
        }
    }
}
