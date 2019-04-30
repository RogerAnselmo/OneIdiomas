using One.Domain.Entities;
using System;

namespace One.Domain.Interfaces.Service
{
    public interface IGETelefoneService: IDisposable
    {
        GETelefone SalvarTelefone(GETelefone GETelefone);
    }
}
