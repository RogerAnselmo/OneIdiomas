using System.Collections.Generic;
using One.Application.Adapter;
using One.Application.Interfaces;
using One.Application.UoW;
using One.Application.ViewModels;
using One.Application.ViewModels.ACAlunoVM;
using One.Application.ViewModels.ACProfessorVM;
using One.Application.ViewModels.ACResponsavelVM;
using One.Application.ViewModels.ACTurmaVM;
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
        private readonly IACProfessorService _iACProfessorService;
        private readonly IACNivelService _iACNivelService;
        private readonly IACTurmaService _iACTurmaService;
        private readonly IGEEnderecoService _iGEEnderecoService;
        private readonly ISEGUsuarioService _iSEGUsuarioService;
        private readonly IGETelefoneService _iGETelefoneService;
        #endregion

        #region Seção: Construtor
        public AcademicoAppService(
            IACAlunoService iACAlunoService,
            IACResponsavelService iACResponsavelService,
            IACAlunoResponsavelService iACAlunoResponsavelService,
            IACProfessorService iACProfessorService,
            IACNivelService iACNivelService,
            IACTurmaService iACTurmaService,
            ISEGUsuarioService iSEGUsuarioService,
            IGEEnderecoService iGEEnderecoService,
            IGETelefoneService iGETelefoneService,
            IUnitOfWorkTransaction uow) : base(uow)
        {
            _iACAlunoService = iACAlunoService;
            _iACResponsavelService = iACResponsavelService;
            _iACAlunoResponsavelService = iACAlunoResponsavelService;
            _iACProfessorService = iACProfessorService;
            _iACNivelService = iACNivelService;
            _iACTurmaService = iACTurmaService;
            _iGEEnderecoService = iGEEnderecoService;
            _iSEGUsuarioService = iSEGUsuarioService;
            _iGETelefoneService = iGETelefoneService;
        }
        #endregion

        #region Seção: ACAluno
        public ValidationResults SalvarAluno(CadastroAlunoViewModel cadastroAlunoViewModel)
        {
            BeginTransaction();

            #region Salva o usuário do Aluno
            var SEGUsuario = _iSEGUsuarioService.Salvar(ACAlunoAdapter.ExtractSEGUsuario(cadastroAlunoViewModel));

            if (!SEGUsuario.ValidationResult.IsValid)
                return SEGUsuario.ValidationResult;
            #endregion

            #region salva o Aluno
            cadastroAlunoViewModel.CodigoUsuario = SEGUsuario.CodigoUsuario;
            ACAluno ACAluno = _iACAlunoService.Salvar(ACAlunoAdapter.ExtractACAluno(cadastroAlunoViewModel));

            if (!ACAluno.ValidationResult.IsValid)
                return ACAluno.ValidationResult;
            #endregion

            #region salva o endereço
            var GEEndereco = _iGEEnderecoService.Salvar(ACAlunoAdapter.ExtractGEEndereco(cadastroAlunoViewModel));
            if (!GEEndereco.ValidationResult.IsValid)
                return GEEndereco.ValidationResult;
            #endregion

            #region vincula endereço ao usuário do Aluno
            var GEUsuarioEndereco = _iGEEnderecoService.SalvarUsuarioEndereco(new GEUsuarioEndereco(SEGUsuario.CodigoUsuario, GEEndereco.CodigoEndereco));
            if (!GEUsuarioEndereco.ValidationResult.IsValid)
                return GEUsuarioEndereco.ValidationResult;
            #endregion

            #region salva o telefone
            var GETelefone = _iGETelefoneService.Salvar(ACAlunoAdapter.ExtractTelefone(cadastroAlunoViewModel));
            if (!GETelefone.ValidationResult.IsValid)
                return GETelefone.ValidationResult;
            #endregion

            SaveChange();
            Commit();

            return  new ValidationResults(true, "Aluno salvo com sucesso!");
        }

        public ValidationResults AlterarAluno(CadastroAlunoViewModel cadastroAlunoViewModel)
        {
            BeginTransaction();

            #region Salva o usuário do Aluno
            var SEGUsuario = _iSEGUsuarioService.Alterar(ACAlunoAdapter.ExtractSEGUsuario(cadastroAlunoViewModel));

            if (!SEGUsuario.ValidationResult.IsValid)
                return SEGUsuario.ValidationResult;
            #endregion

            #region salva o Aluno
            cadastroAlunoViewModel.CodigoUsuario = SEGUsuario.CodigoUsuario;
            ACAluno ACAluno = _iACAlunoService.Alterar(ACAlunoAdapter.ExtractACAluno(cadastroAlunoViewModel));

            if (!ACAluno.ValidationResult.IsValid)
                return ACAluno.ValidationResult;
            #endregion

            #region salva o endereço
            var GEEndereco = _iGEEnderecoService.Alterar(ACAlunoAdapter.ExtractGEEndereco(cadastroAlunoViewModel));
            if (!GEEndereco.ValidationResult.IsValid)
                return GEEndereco.ValidationResult;
            #endregion

            #region vincula endereço ao usuário do Aluno
            var GEUsuarioEndereco = _iGEEnderecoService.AlterarUsuarioEndereco(new GEUsuarioEndereco(SEGUsuario.CodigoUsuario, GEEndereco.CodigoEndereco));
            if (!GEUsuarioEndereco.ValidationResult.IsValid)
                return GEUsuarioEndereco.ValidationResult;
            #endregion

            #region salva o telefone
            var GETelefone = _iGETelefoneService.Alterar(ACAlunoAdapter.ExtractTelefone(cadastroAlunoViewModel));
            if (!GETelefone.ValidationResult.IsValid)
                return GETelefone.ValidationResult;
            #endregion

            SaveChange();
            Commit();

            return new ValidationResults(true, "Aluno alterado com sucesso!");
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

        public IEnumerable<ACAlunoViewModel> ObterAlunosPorNome(string nome) => ACAlunoAdapter.DomainToViewModel(_iACAlunoService.ObterPorNome(nome));

        public CadastroAlunoViewModel ObterAlunoParaEdicao(int id) 
            => ACAlunoAdapter.ConvertAcAlunoToCadastroAlunoViewModel(_iACAlunoService.ObterAlunoParaEdicao(id));
        #endregion

        #region Seção: ACResponsavel
        public ValidationResults SalvarResponsavel(CadastroResponsavelViewModel cadastroResponsavelViewModel)
        {
            BeginTransaction();

            #region Salva o usuário do responsável
            var SEGUsuario = _iSEGUsuarioService.Salvar(ACResponsavelAdapter.ExtractSEGUsuario(cadastroResponsavelViewModel));

            if (!SEGUsuario.ValidationResult.IsValid)
                return SEGUsuario.ValidationResult;
            #endregion

            #region salva o responsável
            cadastroResponsavelViewModel.CodigoUsuario = SEGUsuario.CodigoUsuario;
            ACResponsavel ACResponsavel = _iACResponsavelService.Salvar(ACResponsavelAdapter.ExtractACResponsavel(cadastroResponsavelViewModel));

            if (!ACResponsavel.ValidationResult.IsValid)
                return ACResponsavel.ValidationResult;
            #endregion

            #region salva o endereço
            var GEEndereco = _iGEEnderecoService.Salvar(ACResponsavelAdapter.ExtractGEEndereco(cadastroResponsavelViewModel));
            if (!GEEndereco.ValidationResult.IsValid)
                return GEEndereco.ValidationResult;
            #endregion

            #region vincula endereço ao usuário do responsável
            var GEUsuarioEndereco = _iGEEnderecoService.SalvarUsuarioEndereco(new GEUsuarioEndereco(SEGUsuario.CodigoUsuario, GEEndereco.CodigoEndereco));
            if (!GEUsuarioEndereco.ValidationResult.IsValid)
                return GEUsuarioEndereco.ValidationResult;
            #endregion

            #region salva o telefone
            var GETelefone = _iGETelefoneService.Salvar(ACResponsavelAdapter.ExtractTelefone(cadastroResponsavelViewModel));
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
            var SEGUsuario = _iSEGUsuarioService.Alterar(ACResponsavelAdapter.ExtractSEGUsuario(cadastroResponsavelViewModel));

            if (!SEGUsuario.ValidationResult.IsValid)
                return SEGUsuario.ValidationResult;
            #endregion

            #region salva o responsável
            ACResponsavel ACResponsavel = _iACResponsavelService.Alterar(ACResponsavelAdapter.ExtractACResponsavel(cadastroResponsavelViewModel));

            if (!ACResponsavel.ValidationResult.IsValid)
                return ACResponsavel.ValidationResult;
            #endregion

            #region salva o endereço
            var GEEndereco = _iGEEnderecoService.Alterar(ACResponsavelAdapter.ExtractGEEndereco(cadastroResponsavelViewModel));
            if (!GEEndereco.ValidationResult.IsValid)
                return GEEndereco.ValidationResult;
            #endregion

            #region vincula endereço ao usuário do responsável
            var GEUsuarioEndereco = _iGEEnderecoService.AlterarUsuarioEndereco(new GEUsuarioEndereco(SEGUsuario.CodigoUsuario, GEEndereco.CodigoEndereco));
            if (!GEUsuarioEndereco.ValidationResult.IsValid)
                return GEUsuarioEndereco.ValidationResult;
            #endregion

            #region salva o telefone
            var GETelefone = _iGETelefoneService.Alterar(ACResponsavelAdapter.ExtractTelefone(cadastroResponsavelViewModel));
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

            #region Exclui o responsavel
            var ACResponsavel = _iACResponsavelService.Excluir(id);

            if (!ACResponsavel.ValidationResult.IsValid)
                return ACResponsavel.ValidationResult;
            #endregion

            SaveChange();
            Commit();
            return new ValidationResults(true, "Responsável excluído com sucesso");
        }

        public IEnumerable<ACResponsavelViewModel> ObterResponsavelPorNome(string nome)
           => ACResponsavelAdapter.DomainToViewModel(_iACResponsavelService.ObterPorNome(nome));

        public CadastroResponsavelViewModel ObterResponsavelParaEdicao(int id) 
            => ACResponsavelAdapter.ConvertToCadastroResponsavelViewModel(_iACResponsavelService.ObterPorId(id));
        #endregion

        #region Seção: ACProfessor
        public ValidationResults SalvarProfessor(CadastroProfessorViewModel cadastroProfessorViewModel)
        {
            BeginTransaction();

            #region Salva o usuário do Professor
            var SEGUsuario = _iSEGUsuarioService.Salvar(ACProfessorAdapter.ExtractSEGUsuario(cadastroProfessorViewModel));

            if (!SEGUsuario.ValidationResult.IsValid)
                return SEGUsuario.ValidationResult;
            #endregion

            #region salva o Professor
            cadastroProfessorViewModel.CodigoUsuario = SEGUsuario.CodigoUsuario;
            ACProfessor ACProfessor = _iACProfessorService.Salvar(ACProfessorAdapter.ExtractACProfessor(cadastroProfessorViewModel));

            if (!ACProfessor.ValidationResult.IsValid)
                return ACProfessor.ValidationResult;
            #endregion


            SaveChange();
            Commit();

            return new ValidationResults(true, "Professor salvo com sucesso!");
        }

        public ValidationResults AlterarProfessor(CadastroProfessorViewModel cadastroProfessorViewModel)
        {
            BeginTransaction();

            #region altera o usuário do Professor
            var SEGUsuario = _iSEGUsuarioService.Alterar(ACProfessorAdapter.ExtractSEGUsuario(cadastroProfessorViewModel));

            if (!SEGUsuario.ValidationResult.IsValid)
                return SEGUsuario.ValidationResult;
            #endregion

            #region altera o Professor
            cadastroProfessorViewModel.CodigoUsuario = SEGUsuario.CodigoUsuario;
            ACProfessor ACProfessor = _iACProfessorService.Alterar(ACProfessorAdapter.ExtractACProfessor(cadastroProfessorViewModel));

            if (!ACProfessor.ValidationResult.IsValid)
                return ACProfessor.ValidationResult;
            #endregion

            SaveChange();
            Commit();

            return new ValidationResults(true, "Professor alterado com sucesso!");
        }

        public ValidationResults ExcluirProfessor(int id)
        {
            BeginTransaction();

            #region Exclui o professor
            var ACProfessor = _iACProfessorService.Excluir(id);

            if (!ACProfessor.ValidationResult.IsValid)
                return ACProfessor.ValidationResult;
            #endregion

            SaveChange();
            Commit();
            return new ValidationResults(true, "Professor excluído com sucesso");
        }

        public IEnumerable<ACProfessorViewModel> ObterProfessorPorNome(string nome) 
            => ACProfessorAdapter.DomainToViewModel(_iACProfessorService.ObterProfessorPorNome(nome));

        public CadastroProfessorViewModel ObterProfessorParaEdicao(int id)
            => ACProfessorAdapter.ConvertToCadastroProfessorViewModel(_iACProfessorService.ObterProfessorParaEdicao(id));
        #endregion

        #region Seção: ACNivel
        public IEnumerable<ACNivelViewModel> ObterNiveisAtivos() => ACNivelAdapter.DomainToViewModel(_iACNivelService.ObterTodosAtivos());
        #endregion

        #region Seção: ACTurma
        public ValidationResults SalvarTurma(CadastroTurmaViewModel cadastroTurmaViewModel)
        {
            BeginTransaction();

            ACTurma aCTurma = ACTurmaAdapter.ExtractACTurma(cadastroTurmaViewModel);
            aCTurma = _iACTurmaService.Salvar(aCTurma);
            SaveChange();
            Commit();

            return new ValidationResults(true, "Turma salva com sucesso");
        }

        public ValidationResults AlterarTurma(CadastroTurmaViewModel cadastroTurmaViewModel)
        {
            BeginTransaction();

            ACTurma aCTurma = ACTurmaAdapter.ExtractACTurma(cadastroTurmaViewModel);
            aCTurma = _iACTurmaService.Alterar(aCTurma);
            SaveChange();
            Commit();

            return new ValidationResults(true,"Turma alterada com sucesso");
        }

        public IEnumerable<ACTurmaViewModel> ObterTurmasAtivas() => ACTurmaAdapter.DomainToViewModel(_iACTurmaService.ObterTodos());

        public CadastroTurmaViewModel ObterTurmaParaEdicao(int id) => ACTurmaAdapter.ConvertToCadastroTurmaViewModel(_iACTurmaService.ObterPorId(id));
        #endregion
    }
}
