using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;

namespace One.Infra.Data.Repository
{
    public class SEGUsuarioPerfilRepository : Repository<SEGUsuarioPerfil>, ISEGUsuarioPerfilRepository
    {
        public SEGUsuarioPerfilRepository(OneContext context) : base(context)
        {
        }

        public IEnumerable<SEGUsuarioPerfil> ObterUsuarioPerfilPorCodigoUsuario(int CodigoUsuario)
        {
            return Db.SEGUsuarioPerfil
                .Include(up => up.SEGUsuario)
                .Include(up => up.SEGPerfil)
                .Where(up => up.CodigoUsuario == CodigoUsuario)
                .AsNoTracking();
        }
    }
}
