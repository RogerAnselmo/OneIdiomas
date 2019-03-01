using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Interfaces.Repository
{
    public interface IGEBairroRepository: IRepository<GEBairro>
    {
        IEnumerable<GEBairro> ObterBairroPorCidade();
    }
}
