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

        public GEEndereco Salvar(GEEndereco GEEndereco)
        {
            if (GEEndereco.IsValid())
                _iGEEnderecoRepository.Salvar(GEEndereco);

            return GEEndereco;
        }

        public GEEndereco Alterar(GEEndereco GEEndereco)
        {
            if (GEEndereco.IsValid())
                _iGEEnderecoRepository.Alterar(GEEndereco);

            return GEEndereco;
        }

        public GEUsuarioEndereco SalvarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco)
        {
            if (GEUsuarioEndereco.IsValid())
                _iGEEnderecoRepository.SalvarUsuarioEndereco(GEUsuarioEndereco);

            return GEUsuarioEndereco;
        }

        public GEUsuarioEndereco AlterarUsuarioEndereco(GEUsuarioEndereco GEUsuarioEndereco)
        {
            if (GEUsuarioEndereco.IsValid())
                _iGEEnderecoRepository.AlterarUsuarioEndereco(GEUsuarioEndereco);

            return GEUsuarioEndereco;
        }

    }
}
