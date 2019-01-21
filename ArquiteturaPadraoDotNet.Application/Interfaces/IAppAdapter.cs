using System;
using System.Collections.Generic;
using System.Text;

namespace One.Application.Interfaces
{
    public interface IAppAdapter<TEntity, TEntityViewModel>
    {
        TEntityViewModel DomainToViewModel(TEntity domain);
        IEnumerable<TEntityViewModel> DomainToViewModel(IEnumerable<TEntity> listaDomain);

        TEntity ViewModelToDomain(TEntityViewModel viewModel);
        IEnumerable<TEntity> ViewModelToDomain(IEnumerable<TEntityViewModel> listaViewModel);
    }
}
