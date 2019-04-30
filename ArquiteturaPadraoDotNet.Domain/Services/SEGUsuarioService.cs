using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;

namespace One.Domain.Services
{
    public class SEGUsuarioService : ISEGUsuarioService
    {
        #region Seção - Interface IoC
        private readonly ISEGUsuarioRepository _iSEGUsuarioRepository;
        #endregion

        #region Seção - Construtor
        public SEGUsuarioService(ISEGUsuarioRepository iSEGUsuarioRepository)
            => _iSEGUsuarioRepository = iSEGUsuarioRepository;
        #endregion

        #region Seção - Dispose
        public void Dispose() { }
        #endregion

        #region Seção - Serviços
        public SEGUsuario ObterUsuarioPorLogin(string login)
           => _iSEGUsuarioRepository.ObterUsuarioPorLogin(login);

        public SEGUsuario SalvarUsuario(SEGUsuario SEGUsuario)
        {
            if (SEGUsuario.IsValid())
                _iSEGUsuarioRepository.Salvar(SEGUsuario);

            return SEGUsuario;
        }

        public SEGUsuario AlterarUsuario(SEGUsuario SEGUsuario)
        {
            if (SEGUsuario.IsValid())
                _iSEGUsuarioRepository.Alterar(SEGUsuario);

            return SEGUsuario;
        } 
        #endregion
    }
}
