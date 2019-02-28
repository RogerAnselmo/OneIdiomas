using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Validation
{
    public class ValidationResult
    {
        public ValidationResult()
        {
            Erros = new List<ValidationResult>();
        }

        public string Name { get; set; }
        public string Message { get; set; }
        public bool IsValid { get; set; }

        public IList<ValidationResult> Erros { get; set; }

        public void Add(ValidationError error)
        {
            this.Message = error.Message;
        }
        public void Add(string name, string message, bool iSValid)
        {
            Erros.Add(new ValidationResult { Name = name, Message = message, IsValid = iSValid });

            IsValid = true;

            foreach (var erro in Erros)
                if (!erro.IsValid)
                    IsValid = erro.IsValid;
        }
    }
}
