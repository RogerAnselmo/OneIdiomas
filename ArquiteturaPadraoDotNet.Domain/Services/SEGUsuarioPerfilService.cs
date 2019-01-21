using System.Collections.Generic;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;

namespace One.Domain.Services
{
    public class SEGUsuarioPerfilService : ISEGUsuarioPerfilService
    {
        #region Interface - IoC
        private readonly ISEGUsuarioPerfilRepository _iSEGUsuarioPerfilRepository;
        #endregion

        #region Construtor
        public SEGUsuarioPerfilService(ISEGUsuarioPerfilRepository iSEGUsuarioPerfilRepository)
        {
            _iSEGUsuarioPerfilRepository = iSEGUsuarioPerfilRepository;
        }
        #endregion

        #region Métodos
        public void Dispose()
        {
        }

        public IEnumerable<SEGUsuarioPerfil> ObterUsuarioPerfilPorCodigoUsuario(int CodigoUsuario)
        {
            return _iSEGUsuarioPerfilRepository.ObterUsuarioPerfilPorCodigoUsuario(CodigoUsuario);
        }
        #endregion
    }
}
