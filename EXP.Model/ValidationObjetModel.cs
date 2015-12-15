using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core;
using MKS.Library;

namespace EXP.Model
{
    /// <summary>
    /// Classe de validation de contexte sur l'objet de traitement ObjContact
    /// Le sequenceur exécute la validation sur l'objet avant de continuer les différents processus
    /// </summary>
    public class ValidationObjetModel:Validation<ObjContact>
    {
        /// <summary>
        /// Liste des règles à valdier sur l'ObjContact
        /// </summary>
        /// <returns> Retourne la liste de règle à exécuter sur l'objet de traitement </returns>
        /// <remarks> Sur un erreur de règle, le sequenceur arrête le traitement et retourne une erreur de validation </remarks>
        public override ValidationRules GetRules()
        {
            ValidationRules lr = new ValidationRules();
            
            lr.Add(new RuleStringRequired("VAL_NOM", "Le nom est obligatoire", Rule.RuleSeverity.Error), Reflect<ObjContact>.GetName(c => c.Nom));

            return lr;

        }
    }
}
