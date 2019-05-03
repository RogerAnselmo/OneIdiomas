using One.Domain.Entities;
using System;

namespace One.Domain.Interfaces.Service
{
    public interface ISEGUsuarioService: IDisposable
    {
        SEGUsuario ObterUsuarioPorLogin(string login);
        SEGUsuario Salvar(SEGUsuario usuario);
        SEGUsuario Alterar(SEGUsuario SEGUsuario); 
    }
}
