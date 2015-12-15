using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Business;
using EXP.Model;
using MKS.Core.Business.Interfaces;

namespace EXP.Metier
{
    /// <summary>
    /// Processus pour l'opération Ajouter sur l'objet ObjContact
    /// </summary>
    internal class ProcessAdd:BusinessProcessAdd<ObjContact>
    {
        /// <summary>
        /// Le séquenceur du Business à besoin d'une liste de règles pour exécuter les processus
        /// </summary>
        /// <returns> Liste des règles à exécuter </returns>
        public override List<RuleBusiness> GetProcessRules()
        {
            List<RuleBusiness> rl = new List<RuleBusiness>();
            rl.Add(new RuleBusiness("NOM_INTERDIT", "Il est interdit d'utiliser ce mot", MKS.Core.Rule.RuleSeverity.Error));
            rl.Add(new RuleBusiness("NOM_EXISTANT", "Le nom et le prénom sont déjà existant dans la base de données", MKS.Core.Rule.RuleSeverity.Error));
            return rl;
        }
        /// <summary>
        /// Exécution des processus métiers en fonction de la liste des règles. 
        /// Pour chacune des règles le sequenceur va appeler le DoBusinessProcess afin d'exécuter chacune des règles
        /// </summary>
        /// <param name="rule">Règle à exécuter</param>
        /// <param name="businessObject">Objet de traitement d'affaire, il contient un ensmble d'information en provenance du Sequenceur</param>
        /// <returns>Retour un résultat en fonction de l'exécution</returns>
        public override Process DoBusinessProcess(RuleBusiness rule, BusinessObjectAdd<ObjContact> businessObject)
        {

            //Les règles sont exécutés en seéquence en fonction de l'ordre insctit dans le GetProcessRules
            switch (rule.CodeMessage)
            {
                case "NOM_INTERDIT": //Code de règle
                    //Traitement
                    if (businessObject.Parameter.Nom.ToUpper() == "MECHANT")
                        return Process.FailedThrow;//Indique qu'il y a un erreur.
                    break;
                case "NOM_EXISTANT":
                    EXP.Metier.BusinessMetierContact bm = new BusinessMetierContact();
                    if (bm.Select(businessObject.Parameter) != null)
                        return Process.FailedThrow;//Le nom est existant
                    break;
                    
                default:
                    break;
            }

            return Process.Succeed; 
        }


    }
}
