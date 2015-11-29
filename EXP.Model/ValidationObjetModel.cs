﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MKS.Core;
using MKS.Library;

namespace EXP.Model
{
    public class ValidationObjetModel:Validation<ObjetModel>
    {

        public override ValidationRules GetRules()
        {
            ValidationRules lr = new ValidationRules();
            
            lr.Add(new RuleStringRequired("VAL_NOM", "Le nom est obligatoire", Rule.RuleSeverity.Error), Reflect<ObjetModel>.GetName(c => c.Nom));

            return lr;

        }
    }
}
