using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Services
{
    public class SEGUsuarioService : ISEGUsuarioService
    {
        private readonly ISEGUsuarioRepository _iSEGUsuarioRepository;

        public SEGUsuarioService(ISEGUsuarioRepository iSEGUsuarioRepository)
        {
            _iSEGUsuarioRepository = iSEGUsuarioRepository;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public SEGUsuario AutenticarUsuario(SEGUsuario pUsuario)
        {
            throw new NotImplementedException();
        }

        public SEGUsuario ObterUsuarioPorLogin(string login)
        {
            return _iSEGUsuarioRepository.ObterUsuarioPorLogin(login);
        }

        public void SalvarUsuario(SEGUsuario usuario)
        {
            _iSEGUsuarioRepository.SalvarUsuario(usuario);
        }
    }
}
