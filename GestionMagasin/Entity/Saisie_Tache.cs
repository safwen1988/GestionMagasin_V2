using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace GestionMagasin.Entity
{
    public class Saisie_Tache : ValidationAttribute
    {
        private readonly string _parentFieldName;
        private readonly string _TypeField;
        private readonly string[] _ValidationTypes;

        public Saisie_Tache(string parentFieldName, string typeField, string[] validationTypes)
        {
            _parentFieldName = parentFieldName;
            _TypeField = typeField;
            _ValidationTypes = validationTypes;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationcontext)
        {
            if (validationcontext.ObjectInstance != null)
            {
                var parentFieldValueObject = validationcontext.ObjectInstance.GetType().GetProperty(_parentFieldName)
                    .GetValue(validationcontext.ObjectInstance, null);
                string currentFieldValue = value != null ? value as string : string.Empty;
                string parentFieldValue = parentFieldValueObject != null ? parentFieldValueObject as string : string.Empty;

                if (!string.IsNullOrWhiteSpace(parentFieldValue) && parentFieldValue.ToLower() == _TypeField.ToLower())
                {
                    if (!string.IsNullOrWhiteSpace(currentFieldValue) && _ValidationTypes.Any(x => x.ToLower() == "required"))
                    {
                        return new ValidationResult($"{validationcontext.DisplayName} est un champ nécessaire", new[] { validationcontext.MemberName });

                    }
                    else if(_ValidationTypes.Any(x => x.ToLower() == "Email"))
                    {
                        bool isemail=Regex.IsMatch(currentFieldValue, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
                        if(!isemail)
                        {
                            return new ValidationResult($"{validationcontext.DisplayName} n'est pas un Email Valide", new[] { validationcontext.MemberName });
                        }
                    
                    }
                    else if (_ValidationTypes.Any(x => x.ToLower() == "Telephone"))
                    {
                        bool isPhone = Regex.IsMatch(currentFieldValue, @"\+?[0-9]{10}");
                        if (!isPhone)
                        {
                            return new ValidationResult($"{validationcontext.DisplayName} n'est pas un numéro de téléphone valide", new[] { validationcontext.MemberName });
                        }
                    }

                }

                

            }

            return ValidationResult.Success;
        }
    }
}
