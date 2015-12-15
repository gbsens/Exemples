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
        public ObjContact Ajouter(ObjContact objModel)
        {
            //Déclaration du métier à appeler
            BusinessMetierContact b = new BusinessMetierContact();
            //Execution de la fonction CRUD supporté par le séquenceur.
            
            return b.Add(objModel);
        }
    }
}
