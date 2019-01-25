using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Validation
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public int Erro { get; set; }
        public string Mensagem{ get; set; }
    }
}
