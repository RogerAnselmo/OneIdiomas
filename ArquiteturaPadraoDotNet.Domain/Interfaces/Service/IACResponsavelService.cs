using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Interfaces.Service
{
    public interface IACResponsavelService: IDisposable
    {
        ACResponsavel Salvar(ACResponsavel ACResponsavel);
        ACResponsavel Alterar(ACResponsavel ACResponsavel);
        IEnumerable<ACResponsavel> ObterPorNome(string nome);
        ACResponsavel ObterPorId(int id);
    }
}
