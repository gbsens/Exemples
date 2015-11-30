using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core.Configuration;

namespace EXP.Metier
{
    internal class Config:Configuration
    {
        public override System.Data.IDbConnection GetConnection()
        {
            //Mettre le code pour initier une base de données
            

            return null;
        }
    }
}
