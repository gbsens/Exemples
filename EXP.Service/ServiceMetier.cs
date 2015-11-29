using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EXP.Model;
using EXP.Metier;

namespace EXP.Service
{
    public class ServiceMetier:IServiceMetier
    {
        public ObjetModel Ajouter(ObjetModel objModel)
        {
            BusinessMetier b = new BusinessMetier();
            return b.Add(objModel);
        }
    }
}
