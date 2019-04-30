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

            #region Salva o usuário do aluno
            SEGUsuario SEGUsuarioAluno = _iSEGUsuarioService.SalvarUsuario(CadastroAlunoExtractor.ExtractSEGUsuarioAluno(cadastroAlunoViewModel));

            if (!SEGUsuarioAluno.ValidationResult.IsValid)
                return SEGUsuarioAluno.ValidationResult;
            #endregion

            #region salva o endereço do aluno
            GEEndereco GEEnderecoAluno = _iGEEnderecoService.SalvarEndereco(CadastroAlunoExtractor.ExtractGEEnderecoAluno(cadastroAlunoViewModel));

            if (!GEEnderecoAluno.ValidationResult.IsValid)
                return GEEnderecoAluno.ValidationResult;


            GEUsuarioEndereco GEUsuarioEnderecoAluno = new GEUsuarioEndereco
            {
                CodigoEndereco = GEEnderecoAluno.CodigoEndereco,
                CodigoUsuario = SEGUsuarioAluno.CodigoUsuario
            };

            GEUsuarioEnderecoAluno = _iGEEnderecoService.SalvarUsuarioEndereco(GEUsuarioEnderecoAluno);

            if (!GEUsuarioEnderecoAluno.ValidationResult.IsValid)
                return GEUsuarioEnderecoAluno.ValidationResult;
            #endregion

            #region salva o aluno com os dados do usuário e endereço
            ACAluno ACAluno = CadastroAlunoExtractor.ExtractACAluno(cadastroAlunoViewModel);
            ACAluno.CodigoUsuario = SEGUsuarioAluno.CodigoUsuario;
            ACAluno = _iACAlunoService.Salvar(ACAluno);

            if (!ACAluno.ValidationResult.IsValid)
                return ACAluno.ValidationResult;

            #endregion

            #region salva o telefone do aluno
            GETelefone GETelefoneAluno = CadastroAlunoExtractor.ExtractTelefoneAluno(cadastroAlunoViewModel);
            GETelefoneAluno.CodigoUsuario = SEGUsuarioAluno.CodigoUsuario;
            GETelefoneAluno = _iGETelefoneService.SalvarTelefone(GETelefoneAluno);

            if (!GETelefoneAluno.ValidationResult.IsValid)
                return GETelefoneAluno.ValidationResult;

            #endregion

            #region Salva o usuário do responsável
            SEGUsuario SEGUsuarioResponsavel = null;

            if (!cadastroAlunoViewModel.AlunoÉOProprioResponsavel)
            {
                SEGUsuarioResponsavel = CadastroAlunoExtractor.ExtractSEGUsuarioResponsavel(cadastroAlunoViewModel);
                SEGUsuarioResponsavel = _iSEGUsuarioService.SalvarUsuario(SEGUsuarioResponsavel);

                if (!SEGUsuarioResponsavel.ValidationResult.IsValid)
                    return SEGUsuarioResponsavel.ValidationResult;
            }
            #endregion

            #region salva o endereço do responsável
            if (!cadastroAlunoViewModel.UsarEnderecoDoResponsavel)
            {
                GEEndereco GEEnderecoResponsavel = CadastroAlunoExtractor.ExtractGEEnderecoResponsavel(cadastroAlunoViewModel);
                GEEnderecoResponsavel = _iGEEnderecoService.SalvarEndereco(GEEnderecoResponsavel);

                if (!GEEnderecoResponsavel.ValidationResult.IsValid)
                    return GEEnderecoResponsavel.ValidationResult;
            }
            #endregion

            #region salva o responsável
            ACResponsavel ACResponsavel = CadastroAlunoExtractor.ExtractACResponsavel(cadastroAlunoViewModel);
            ACResponsavel.CodigoUsuario = cadastroAlunoViewModel.AlunoÉOProprioResponsavel ? SEGUsuarioAluno.CodigoUsuario : SEGUsuarioResponsavel.CodigoUsuario;
            ACResponsavel = _iACResponsavelService.Salvar(ACResponsavel);

            if (!ACResponsavel.ValidationResult.IsValid)
                return ACResponsavel.ValidationResult;
            #endregion

            #region salva o aluno responsavel
            ACAlunoResponsavel ACAlunoResponsavel = new ACAlunoResponsavel(
                ACAluno.CodigoAluno,
                ACResponsavel.CodigoResponsavel,
                cadastroAlunoViewModel.CodigoParentesco
            );

            ACAlunoResponsavel = _iACAlunoResponsavelService.Salvar(ACAlunoResponsavel);

            if (!ACAlunoResponsavel.ValidationResult.IsValid)
                return ACAlunoResponsavel.ValidationResult;

            #endregion

            #region salvar telefone do responsável
            if (!cadastroAlunoViewModel.AlunoÉOProprioResponsavel)
            {
                GETelefone GETelefoneresponsavel = CadastroAlunoExtractor.ExtractTelefoneAluno(cadastroAlunoViewModel);
                GETelefoneresponsavel.CodigoUsuario = SEGUsuarioResponsavel.CodigoUsuario;
                GETelefoneresponsavel = _iGETelefoneService.SalvarTelefone(GETelefoneresponsavel);

                if (!GETelefoneresponsavel.ValidationResult.IsValid)
                    return GETelefoneresponsavel.ValidationResult;
            }
            #endregion

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

            validationResult = _iSEGUsuarioService.AlterarUsuario(EditarAlunoExtractor.ExtractSEGUsuario(editarAlunoViewModel)).ValidationResult;
            if (!validationResult.IsValid)
                return validationResult;

            validationResult = _iGEEnderecoService.AlterarEndereco(EditarAlunoExtractor.ExtractEnderecoAluno(editarAlunoViewModel)).ValidationResult;
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
        public ValidationResults SalvarResponsavel(EditarResponsavelViewModel editarResponsavelViewModel)
        {
            //validationResult = _iACAlunoService.Alterar(EditarResponsavelExtractor.ExtractACResponsavel(editarResponsavelViewModel)).ValidationResult;
            //if (!validationResult.IsValid)
            //    return validationResult;

            //validationResult = _iSEGUsuarioService.AlterarUsuario(EditarAlunoExtractor.ExtractSEGUsuario(editarResponsavelViewModel)).ValidationResult;
            //if (!validationResult.IsValid)
            //    return validationResult;

            //validationResult = _iGEEnderecoService.AlterarEndereco(EditarAlunoExtractor.ExtractEnderecoAluno(editarResponsavelViewModel)).ValidationResult;
            //if (!validationResult.IsValid)
            //    return validationResult;

            return new ValidationResults(false, "não implementado!");
        }

        public ValidationResults AlterarResponsavel(EditarResponsavelViewModel editarResponsavelViewModel)
        {
            throw new System.NotImplementedException();
        }

        public ValidationResults ExcluirResponsavel(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ACResponsavelViewModel> ObterPorResponsavelNome(string nome)
           => ACReponsavelAdapter.DomainToViewModel(_iACResponsavelService.ObterPorNome(nome));

        public EditarResponsavelViewModel ObterResponsavelParaEdicao(int id)
            => EditarResponsavelExtractor.ConvertToEditarResponsavelViewModel(_iACResponsavelService.ObterPorId(id));
        #endregion
    }
}
