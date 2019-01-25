using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Interfaces.Service
{
    public interface IACAlunoReponsavelService: IDisposable
    {
        void SalvarAlunoReponsavel(ACAlunoResponsavel ACAlunoResponsavel);
    }
}
