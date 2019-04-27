using One.Domain.Entities;
using One.Domain.Interfaces.Repository;
using One.Domain.Interfaces.Service;
using System;

namespace One.Domain.Services
{
    public class GEEnderecoService : IGEEnderecoService
    {
        private readonly IGEEnderecoRepository _iGEEnderecoRepository;

        public GEEnderecoService(IGEEnderecoRepository iGEEnderecoRepository)
        {
            _iGEEnderecoRepository = iGEEnderecoRepository;
        }

        public void Dispose()
        {
        }

        public void SalvarEndereco(GEEndereco GEEndereco)
        {
            _iGEEnderecoRepository.Salvar(GEEndereco);
        }

        public void SalvarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco)
        {
            _iGEEnderecoRepository.SalvarUsuarioEndereco(GEUsuarioEndereco);
        }

        public void AlterarEndereco(GEEndereco GEEndereco) => _iGEEnderecoRepository.Alterar(GEEndereco);
    }
}
