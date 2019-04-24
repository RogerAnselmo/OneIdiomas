using One.Domain.Entities;
using System.Linq;

namespace One.Domain.Interfaces.Repository
{
    public interface IGEEnderecoRepository: IRepository<GEEndereco>
    {
        IQueryable<GEUsuarioEndereco> ObterEnderecosPorCodigoUsuario(int CodigoUsuario);
        void SalvarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco);
    }
}
