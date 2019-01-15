using One.Domain.Entities;
using System;

namespace One.Domain.Interfaces.Service
{
    public interface ISEGUsuarioService: IDisposable
    {
        SEGUsuario AutenticarUsuario(SEGUsuario pUsuario);
        SEGUsuario ObterUsuarioPorLogin(string login);
        void SalvarUsuario(SEGUsuario usuario);
    }
}
