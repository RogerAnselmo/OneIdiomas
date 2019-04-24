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
        }

        public SEGUsuario ObterUsuarioPorLogin(string login)
        {
            return _iSEGUsuarioRepository.ObterUsuarioPorLogin(login);
        }

        public void SalvarUsuario(SEGUsuario SEGUsuario)
        {
            SEGUsuario.CodigoUsuario = 0;//usuário novo sempre tem CodigoUsuario = 0
            SEGUsuario.flAtivo = "A";//usuário novo sempre tem flAtivo = "A"
            //_iSEGUsuarioRepository.SalvarUsuario(SEGUsuario);
            _iSEGUsuarioRepository.Salvar(SEGUsuario);
        }
    }
}
