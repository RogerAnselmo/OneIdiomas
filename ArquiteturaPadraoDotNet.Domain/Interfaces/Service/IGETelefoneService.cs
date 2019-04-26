using One.Domain.Entities;
using System;

namespace One.Domain.Interfaces.Service
{
    public interface IGETelefoneService: IDisposable
    {
        void SalvarTelefone(GETelefone GETelefone);
    }
}
