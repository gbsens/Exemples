using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Business;
using EXP.Model;

namespace EXP.Metier
{
    internal class ProcessAdd:BusinessProcessAdd<ObjetModel>
    {
        public override List<RuleBusiness> GetProcessRules()
        {
            List<RuleBusiness> rl = new List<RuleBusiness>();
            rl.Add(new RuleBusiness("NOM_INTERDIT", "Il est interdit d'utiliser ce mot", MKS.Core.Rule.RuleSeverity.Error));
            return rl;
        }
        public override Process DoBusinessProcess(RuleBusiness rule, BusinessObjectAdd<ObjetModel> businessObject)
        {
            switch (rule.CodeMessage)
            {
                case "NOM_INTERDIT":
                    if (businessObject.Parameter.Nom.ToUpper() == "MECHANT")
                        return Process.FailedThrow;
                    break;
                default:
                    break;
            }
            return Process.Succeed;
        }


    }
}
