using System.Collections.Generic;
using One.Application.Adapter;
using One.Application.Extractors;
using One.Application.Interfaces;
using One.Application.UoW;
using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Application.ViewModels.ACResponsavelVM;
using One.Domain.Entities;
using One.Domain.Interfaces.Service;
using One.Domain.Validation;
using One.Infra.Data.Interface;

namespace One.Application.Services
{
    public class AcademicoAppService : ApplicationServiceTransaction, IAcademicoAppService
    {
        #region Seção: Interface - IoC
        private ValidationResults validationResult;
        private readonly IACAlunoService _iACAlunoService;
        private readonly IACResponsavelService _iACResponsavelService;
        private readonly IACAlunoResponsavelService _iACAlunoResponsavelService;
        private readonly IGEEnderecoService _iGEEnderecoService;
        private readonly ISEGUsuarioService _iSEGUsuarioService;
        private readonly IGETelefoneService _iGETelefoneService;
        #endregion

        #region Seção: Construtor
        public AcademicoAppService(
            IACAlunoService iACAlunoService,
            IACResponsavelService iACResponsavelService,
            IACAlunoResponsavelService iACAlunoResponsavelService,
            ISEGUsuarioService iSEGUsuarioService,
            IGEEnderecoService iGEEnderecoService,
            IGETelefoneService iGETelefoneService,
            IUnitOfWorkTransaction uow) : base(uow)
        {
            _iACAlunoService = iACAlunoService;
            _iACResponsavelService = iACResponsavelService;
            _iACAlunoResponsavelService = iACAlunoResponsavelService;
            _iGEEnderecoService = iGEEnderecoService;
            _iSEGUsuarioService = iSEGUsuarioService;
            _iGETelefoneService = iGETelefoneService;
        }
        #endregion

        #region Seção: ACAluno
        public ValidationResults SalvarAluno(CadastroAlunoViewModel cadastroAlunoViewModel)
        {
            BeginTransaction();



            SaveChange();
            Commit();

            return new ValidationResults(true, "Aluno salvo com sucesso!");
        }

        public ValidationResults AlterarAluno(EditarAlunoViewModel editarAlunoViewModel)
        {
            BeginTransaction();

            validationResult = _iACAlunoService.Alterar(EditarAlunoExtractor.ExtractACAluno(editarAlunoViewModel)).ValidationResult;
            if (!validationResult.IsValid)
                return validationResult;

            validationResult = _iSEGUsuarioService.Alterar(EditarAlunoExtractor.ExtractSEGUsuario(editarAlunoViewModel)).ValidationResult;
            if (!validationResult.IsValid)
                return validationResult;

            validationResult = _iGEEnderecoService.Alterar(EditarAlunoExtractor.ExtractEnderecoAluno(editarAlunoViewModel)).ValidationResult;
            if (!validationResult.IsValid)
                return validationResult;

            SaveChange();
            Commit();

            return new ValidationResults(true, "Aluno alterado com sucesso");
        }

        public ValidationResults ExcluirAluno(int id)
        {
            BeginTransaction();
            validationResult = _iACAlunoService.Excluir(id).ValidationResult;

            if (!validationResult.IsValid)
                return validationResult;

            SaveChange();
            Commit();

            return new ValidationResults(true, "Aluno alterado com sucesso");
        }

        public IEnumerable<ACAlunoViewModel> ObterAlunosPorNome(string nome)
        {
            return ACAlunoAdapter.DomainToViewModel(_iACAlunoService.ObterPorNome(nome));
        }

        public EditarAlunoViewModel ObterAlunoParaEdicao(int id)
        {
            return EditarAlunoExtractor.ConvertAcAlunoToEditarAlunoViewModel(_iACAlunoService.ObterAlunoParaEdicao(id));
        }
        #endregion

        #region Seção: ACResponsavel
        public ValidationResults SalvarResponsavel(CadastroResponsavelViewModel cadastroResponsavelViewModel)
        {
            BeginTransaction();

            #region Salva o usuário do responsável
            var SEGUsuario = _iSEGUsuarioService.Salvar(ACReponsavelAdapter.ExtractSEGUsuario(cadastroResponsavelViewModel));

            if (!SEGUsuario.ValidationResult.IsValid)
                return SEGUsuario.ValidationResult;
            #endregion

            #region salva o responsável
            cadastroResponsavelViewModel.CodigoUsuario = SEGUsuario.CodigoUsuario;
            ACResponsavel ACResponsavel = _iACResponsavelService.Salvar(ACReponsavelAdapter.ExtractACResponsavel(cadastroResponsavelViewModel));

            if (!ACResponsavel.ValidationResult.IsValid)
                return ACResponsavel.ValidationResult;
            #endregion

            #region salva o endereço
            var GEEndereco = _iGEEnderecoService.Salvar(ACReponsavelAdapter.ExtractGEEndereco(cadastroResponsavelViewModel));
            if (!GEEndereco.ValidationResult.IsValid)
                return GEEndereco.ValidationResult;
            #endregion

            #region vincula endereço ao usuário do responsável
            var GEUsuarioEndereco = _iGEEnderecoService.SalvarUsuarioEndereco(new GEUsuarioEndereco(SEGUsuario.CodigoUsuario, GEEndereco.CodigoEndereco));
            if (!GEUsuarioEndereco.ValidationResult.IsValid)
                return GEUsuarioEndereco.ValidationResult;
            #endregion

            #region salva o telefone
            var GETelefone = _iGETelefoneService.Salvar(ACReponsavelAdapter.ExtractTelefone(cadastroResponsavelViewModel));
            if (!GETelefone.ValidationResult.IsValid)
                return GETelefone.ValidationResult;
            #endregion

            SaveChange();
            Commit();

            return new ValidationResults(true, "Responsável cadastrado com sucesso");
        }

        public ValidationResults AlterarResponsavel(CadastroResponsavelViewModel cadastroResponsavelViewModel)
        {

            BeginTransaction();
            #region Salva o usuário do responsável
            var SEGUsuario = _iSEGUsuarioService.Alterar(ACReponsavelAdapter.ExtractSEGUsuario(cadastroResponsavelViewModel));

            if (!SEGUsuario.ValidationResult.IsValid)
                return SEGUsuario.ValidationResult;
            #endregion

            #region salva o responsável
            ACResponsavel ACResponsavel = _iACResponsavelService.Alterar(ACReponsavelAdapter.ExtractACResponsavel(cadastroResponsavelViewModel));

            if (!ACResponsavel.ValidationResult.IsValid)
                return ACResponsavel.ValidationResult;
            #endregion

            #region salva o endereço
            var GEEndereco = _iGEEnderecoService.Alterar(ACReponsavelAdapter.ExtractGEEndereco(cadastroResponsavelViewModel));
            if (!GEEndereco.ValidationResult.IsValid)
                return GEEndereco.ValidationResult;
            #endregion

            #region vincula endereço ao usuário do responsável
            var GEUsuarioEndereco = _iGEEnderecoService.AlterarUsuarioEndereco(new GEUsuarioEndereco(SEGUsuario.CodigoUsuario, GEEndereco.CodigoEndereco));
            if (!GEUsuarioEndereco.ValidationResult.IsValid)
                return GEUsuarioEndereco.ValidationResult;
            #endregion

            #region salva o telefone
            var GETelefone = _iGETelefoneService.Alterar(ACReponsavelAdapter.ExtractTelefone(cadastroResponsavelViewModel));
            if (!GETelefone.ValidationResult.IsValid)
                return GETelefone.ValidationResult;
            #endregion

            SaveChange();
            Commit();

            return new ValidationResults(true, "Responsável alterado com sucesso");
        }

        public ValidationResults ExcluirResponsavel(int id)
        {
            BeginTransaction();

            #region Exclui o responsável
            var ACResponsavel = _iACResponsavelService.Excluir(id);

            if (!ACResponsavel.ValidationResult.IsValid)
                return ACResponsavel.ValidationResult;
            #endregion

            SaveChange();
            Commit();
            return new ValidationResults(true, "Responsável excluído com sucesso");
        }

        public IEnumerable<ACResponsavelViewModel> ObterPorResponsavelNome(string nome)
           => ACReponsavelAdapter.DomainToViewModel(_iACResponsavelService.ObterPorNome(nome));

        public CadastroResponsavelViewModel ObterResponsavelParaEdicao(int id) 
            => ACReponsavelAdapter.ConvertToCadastroResponsavelViewModel(_iACResponsavelService.ObterPorId(id));
        #endregion
    }
}
