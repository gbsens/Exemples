using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Mapping;
using EXP.Model;

namespace EXP.Mapping
{
    /// <summary>
    /// Transforme l'objet ObjectModel en fonction du support de données en fonction des opérations CRUD défini par le Business
    /// L'héritage du DataMap doit correspondre à l'héritage du Business dans la couche métier.
    /// </summary>
    public class MapObjetModel:DataMap<ObjetModel>
    {
        public override void Initialize(System.Data.IDbConnection connection)
        {
            //Code pour l'initialisation de la base de données
            //C'est le Business qui ouvre la base de données car c'est son rôle gérer les transactions.

        } 
        public override ObjetModel Add(ObjetModel myObject)
        {

            //Code pour l'ajout dans la base de donnée           
            return myObject; 
        }
    }
}
