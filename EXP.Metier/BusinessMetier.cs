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
    /// Classe pour faire l'assemblage des processus métier de l'objet ObjectModel
    /// Les opérations CRUD sont définient en fonction de l'héritage du Business. 
    /// Dans l'exemble les opérations sont : Add, Update, Delete, Select et Edit
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

            //Classe qui contien la connexion à la base de données
            //SetConfiguration<Config>();
        }
    }
}
