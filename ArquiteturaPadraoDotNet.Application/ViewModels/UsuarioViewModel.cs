using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.ViewModels
{
    public class UsuarioViewModel
    {
        public int CodigoUsuario { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Mensagem { get; set; }
        public bool Autenticado { get; set; }
    }
}
