using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Presenter;

namespace EXP.Presenter
{
    /// <summary>
    /// Fait le lien entre le processus de présentation et la vue pour l'interface utilisateur.
    /// </summary>
    public class PresenterModelVue:Presenter<IModelVue,ProcessPresenter>
    {
        public PresenterModelVue(IModelVue view): base(view)
        {
            
        }
    }
}
