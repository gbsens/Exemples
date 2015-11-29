using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Presenter;

namespace EXP.Presenter
{
    public class PresenterModelVue:Presenter<IModelVue,ProcessPresenter>
    {
        public PresenterModelVue(IModelVue view): base(view)
        {

        }
    }
}
