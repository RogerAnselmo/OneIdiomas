using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Validation
{
    public class ValidationResults
    {
        protected ValidationResults() => Erros = new List<ValidationResults>();

        public ValidationResults(bool isValid, string message): this()
        {
            IsValid = isValid;
            Message = message;
        }

        public string Name { get; set; }
        public string Message { get; set; }
        public bool IsValid { get; set; }

        public IList<ValidationResults> Erros { get; set; }
        public void Add(ValidationError error) => Message = error.Message;

        public void Add(string name, string message, bool iSValid)
        {
            Erros.Add(new ValidationResults { Name = name, Message = message, IsValid = iSValid });

            IsValid = true;

            foreach (var erro in Erros)
                if (!erro.IsValid)
                    IsValid = erro.IsValid;
        }
    }
}
