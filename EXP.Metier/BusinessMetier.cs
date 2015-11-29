using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Business;

using EXP.Model;
using EXP.Mapping;

namespace EXP.Metier
{
    /// <summary>
    /// Classe métier pour l'objet ObjectModel
    /// </summary>
    public class BusinessMetier:Business<ObjetModel>
    {
        public BusinessMetier()
        {
            //Classe de validation de contexte sur l'objet ObjectModel
            SetValidation<ValidationObjetModel>();
            
            //Classe de porcessus qui est exécuté avant le mapping ver une couche de donnée
            SetPreProcessAdd<ProcessAdd>();

            //Classe qui fait la persistence vers une couche de donnée
            SetDataMap<MapObjetModel>();
        }
    }
}
