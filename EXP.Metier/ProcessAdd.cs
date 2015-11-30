using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Business;
using EXP.Model;

namespace EXP.Metier
{
    /// <summary>
    /// Processus pour l'opération Ajouter sur l'objet ObjetModel
    /// </summary>
    internal class ProcessAdd:BusinessProcessAdd<ObjetModel>
    {
        /// <summary>
        /// Le séquenceur du Business à besoin d'une liste de règles pour exécuter les processus
        /// </summary>
        /// <returns> Liste des règles à exécuter </returns>
        public override List<RuleBusiness> GetProcessRules()
        {
            List<RuleBusiness> rl = new List<RuleBusiness>();
            rl.Add(new RuleBusiness("NOM_INTERDIT", "Il est interdit d'utiliser ce mot", MKS.Core.Rule.RuleSeverity.Error));
            return rl;
        }
        /// <summary>
        /// Exécution des processus métiers en fonction de la liste des règles. 
        /// Pour chacune des règles le sequenceur va appeler le DoBusinessProcess afin d'exécuter chacune des règles
        /// </summary>
        /// <param name="rule">Règle à exécuter</param>
        /// <param name="businessObject">Objet de traitement d'affaire, il contient un ensmble d'information en provenance du Sequenceur</param>
        /// <returns>Retour un résultat en fonction de l'exécution</returns>
        public override Process DoBusinessProcess(RuleBusiness rule, BusinessObjectAdd<ObjetModel> businessObject)
        {
            switch (rule.CodeMessage)
            {
                case "NOM_INTERDIT": //Code de règle
                    //Traitement
                    if (businessObject.Parameter.Nom.ToUpper() == "MECHANT")
                        return Process.FailedThrow;//Indique qu'il y a un erreur.
                    break;
                default:
                    break;
            }

            return Process.Succeed; 
        }


    }
}
