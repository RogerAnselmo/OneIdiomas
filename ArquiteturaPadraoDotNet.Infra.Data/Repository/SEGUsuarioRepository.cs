using Microsoft.EntityFrameworkCore;
using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Infra.Data.Context;
using System.Linq;

namespace One.Infra.Data.Repository
{
    public class SEGUsuarioRepositopry : Repository<SEGUsuario>, ISEGUsuarioRepository
    {
        public SEGUsuarioRepositopry(OneContext context) : base(context)
        { }

        public SEGUsuario ObterUsuarioPorLogin(string pLogin)
        {
            return Db.SEGUsuario
                .Where(u => u.Login.ToUpper().Equals(pLogin.ToUpper()))
                .AsNoTracking()
                .FirstOrDefault();
        }

        public void SalvarUsuario(SEGUsuario usuario)
        {
            Db.SEGUsuario.Add(usuario);
            Db.SaveChanges();
        }
    }
}
