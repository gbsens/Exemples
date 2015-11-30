using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EXP.Model;
using EXP.Metier;

namespace EXP.Service
{
    /// <summary>
    /// Couche d'exposition du métier. 
    /// </summary>
    public class ServiceMetier:IServiceMetier
    {
        public ObjetModel Ajouter(ObjetModel objModel)
        {
            //Déclaration du métier à appeler
            BusinessMetier b = new BusinessMetier();
            //Execution de la fonction CRUD supporté par le séquenceur.
            
            return b.Add(objModel);
        }
    }
}
