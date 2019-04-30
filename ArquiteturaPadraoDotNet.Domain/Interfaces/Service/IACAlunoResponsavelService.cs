using One.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Interfaces.Service
{
    public interface IACAlunoResponsavelService: IDisposable
    {
        ACAlunoResponsavel Salvar(ACAlunoResponsavel ACAlunoResponsavel);
    }
}
