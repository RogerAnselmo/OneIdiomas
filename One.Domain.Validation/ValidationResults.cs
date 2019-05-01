using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace One.Domain.Validation
{
    public class ValidationResults
    {
        #region Seção: Contstrutor
        protected ValidationResults()
        {
            Erros = new List<ValidationResults>();
            IsValid = false;
            Message = $"{GetType().Name} inválido";
        }

        public ValidationResults(bool isValid, string message) : this()
        {
            IsValid = isValid;
            Message = message;
        }
        #endregion

        #region Seção: Propriedades
        public string Name { get; set; }
        public string Message { get; set; }
        public bool IsValid { get; set; }

        public IList<ValidationResults> Erros { get; set; }
        #endregion

        #region Seção: Métodos
        public void Add(string name, string message, bool iSValid)
        {
            Erros.Add(new ValidationResults { Name = name, Message = message, IsValid = iSValid });
            IsValid = true;

            foreach (ValidationResults erro in from erro in Erros where !erro.IsValid select erro)
                IsValid = erro.IsValid;
        } 
        #endregion
    }
}