using One.Domain.Entities;

namespace One.Domain.Interfaces.Repository
{
    public interface ISEGUsuarioRepository : IRepository<SEGUsuario>
    {
        SEGUsuario ObterUsuarioPorLogin(string pLogin);
        void SalvarUsuario(SEGUsuario usuario);
    }
}
