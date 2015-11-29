using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Mapping;
using EXP.Model;

namespace EXP.Mapping
{
    public class MapObjetModel:DataMap<ObjetModel>
    {
        public override ObjetModel Add(ObjetModel myObject)
        {

            //Code de pour l'ajout dans la base de donnée
            //...
            return myObject; 
        }
    }
}
