﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace EXP.Model
{
    /// <summary>
    /// Objet pour le traitement métier.
    /// </summary>
    public class ObjContact
    {
        public int? Id { get;set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Telephone { get; set; }
    }
}
