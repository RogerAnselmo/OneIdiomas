using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Interfaces.Service
{
    public interface IACResponsavelService: IDisposable
    {
        void SalvarResponsavel(ACResponsavel ACResponsavel);
    }
}
