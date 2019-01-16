using One.Application.ViewModels;
using One.Domain.Entities;

namespace One.Application.Adapter
{
    public class SEGUsuarioAdapter
    {
        public SEGUsuario ViewModelToDomain(UsuarioViewModel usuarioViewModel)
        {
            return new SEGUsuario
            {
                CodigoUsuario = usuarioViewModel.CodigoUsuario,
                
            };
        }
    }
}
