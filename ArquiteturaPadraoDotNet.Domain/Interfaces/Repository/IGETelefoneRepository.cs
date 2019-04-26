using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Interfaces.Repository
{
    public interface IGETelefoneRepository: IRepository<GETelefone>
    {
        IEnumerable<GETelefone> ObterTelefonesPorUsuario(int CodigoUsuario);
        void SalvarTelefone(GETelefone GETelefone);
    }
}
