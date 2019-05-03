using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;
using System.Linq;

namespace One.Infra.Data.Repository
{
    public class GEEndercoRepository : Repository<GEEndereco>, IGEEnderecoRepository
    {
        public GEEndercoRepository(OneContext context) : base(context)
        {
        }

        #region GEUsuarioEndereco
        public IQueryable<GEUsuarioEndereco> ObterEnderecosPorCodigoUsuario(int CodigoUsuario)
        {
            return Db.GEUsuarioEndereco
                .Where(ue => ue.CodigoUsuario == CodigoUsuario)
                .Include(ue => ue.SEGUsuario)
                .Include(ue => ue.GEEndereco)
                .Include(ue => ue.GEEndereco.GEBairro)
                .Include(ue => ue.GEEndereco.GEBairro.GECidade)
                .Include(ue => ue.GEEndereco.GEBairro.GECidade.GEUF)
                .AsNoTracking();
        }

        public void SalvarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco)
        {
            Db.GEUsuarioEndereco.Add(GEUsuarioEndereco);
            Db.SaveChanges();
        }

        public void AlterarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco)
        {
            Db.GEUsuarioEndereco.Update(GEUsuarioEndereco);
            Db.SaveChanges();
        }
        #endregion
    }
}
