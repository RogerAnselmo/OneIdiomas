using One.Domain.Entities;
using System;

namespace One.Domain.Interfaces.Service
{
    public interface IGETelefoneService: IDisposable
    {
        GETelefone Salvar(GETelefone GETelefone);
        GETelefone Alterar(GETelefone GETelefone);
    }
}
