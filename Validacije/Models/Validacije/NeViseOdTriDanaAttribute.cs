using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Validacije.Models.Validacije
{
    public class NeViseOdTriDanaAttribute : ValidationAttribute,IClientValidatable

    {
        public override bool IsValid(object value)
        {
            if (value is DateTime && (DateTime)value < DateTime.Today.AddDays(-3))
            {
                MetaRacun mr = (MetaRacun)value;
                if (mr.Datum < DateTime.Today.AddDays(-3))
                {
                    return false;
                }
                else if(value is MetaRacun )
                {
                    if (((MetaRacun)value).Datum < DateTime.Today.AddDays(-3))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public IEnumerable<ModelClientValidationRule>
            GetClientValidationRules(ModelMetadata metadata, ControllerContext context)
        {
            ModelClientValidationRule mvr = new ModelClientValidationRule();
            mvr.ErrorMessage = "Datum ne smije biti manji za više od 3 dana!";
            mvr.ValidationType = "validdatum";
            return new[] { mvr };
        }
    }
}