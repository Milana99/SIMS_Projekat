using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Text.RegularExpressions;

namespace Bolnica.Validation
{
    class StringToDoubleValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                double r;
                if(double.TryParse(s,out r))
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Molimo unesite double vrednost.");
            }
            catch
            {
                return new ValidationResult(false, "Error.");
            }
        }
    }
    public class MinMaxValidationRule : ValidationRule
    {
        public double Min
        {
            get;
            set;
        }
        public double Max
        {
            get;
            set;
        }
        
        
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if(value is double)
            {
                double d = (double)value;
                if (d < Min) return new ValidationResult(false, "Vrednost je previse mala!");
                if (d > Max) return new ValidationResult(false, "Vrednost je previse velika.");
                return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false, "Error");
            }
        }
    }

    public class MinMaxValidationRuleString : ValidationRule
    {
        public double Min
        {
            get;
            set;
        }
        public double Max
        {
            get;
            set;
        }
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            if (value is string)
            {
                string d = (string)value;
                if (d.Length < Min) return new ValidationResult(false, "String je previše kratak!");
                if (d.Length > Max) return new ValidationResult(false, "String je previše dugačak!");
                return new ValidationResult(true, null);
            }
            else
            {
                return new ValidationResult(false, "Error");
            }
        }
    }

    public class CheckSpace : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                if (s=="")
                {
                    return new ValidationResult(false, "Polje ne sme da bude prazno."); 
                }
                return new ValidationResult(true, null);
            }
            catch
            {
                return new ValidationResult(false, "Error.");
            }
        }
    }

    public class StringToInt : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                var s = value as string;
                int r;
                if (int.TryParse(s, out r)) 
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Molimo unesite celobrojnu vrednost!");
            }
            catch
            {
                return new ValidationResult(false, "Error.");
            }
        }
    }
    public class StringToDateTime : ValidationRule
    {
        public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
        {
            try
            {
                
                var s = value as string;
                DateTime r;
                bool isOk = Regex.IsMatch(value.ToString(), @"[0-2][0-9]\:[0-6][0-9]\:[0-5][0-9]");
                var dt = DateTime.Parse(s);
                var time = dt.ToString("HH:mm:ss");
                
                if (isOk)
                {
                    return new ValidationResult(true, null);
                }
                return new ValidationResult(false, "Unesite vreme u formatu HH:MM:SS!");
            }
            catch
            {
                return new ValidationResult(false, "Error.");
            }
        }
    }


}
