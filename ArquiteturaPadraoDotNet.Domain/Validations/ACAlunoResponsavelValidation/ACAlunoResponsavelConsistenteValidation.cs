using One.Domain.Entities;
using One.Domain.Validation;
using One.Domain.Specifications.ACAlunoResponsavelSpecification;

namespace One.Domain.Validations.ACAlunoResponsavelValidation
{
    public class ACAlunoResponsavelConsistenteValidation: Validator<ACAlunoResponsavel>
    {
        public ACAlunoResponsavelConsistenteValidation(ACAlunoResponsavel ACAlunoResponsavel)
        {
            var CodigoAlunoDeveSerMaiorQueZero = new CodigoAlunoDeveSerMaiorQueZero();
            var CodigoParentescoDeveSerMaiorQueZero = new CodigoParentescoDeveSerMaiorQueZero();
            var CodigoResponsavelDeveSerMaiorQueZero = new CodigoResponsavelDeveSerMaiorQueZero();

            base.Add("CodigoAlunoDeveSerMaiorQueZero ", new Rule<ACAlunoResponsavel>(CodigoAlunoDeveSerMaiorQueZero, "Código do aluno deve ser maior que Zero.", ACAlunoResponsavel));
            base.Add("CodigoResponsavelDeveSerMaiorQueZero ", new Rule<ACAlunoResponsavel>(CodigoResponsavelDeveSerMaiorQueZero, "Código do responsável deve ser maior que Zero.", ACAlunoResponsavel));
            base.Add("CodigoParentescoDeveSerMaiorQueZero", new Rule<ACAlunoResponsavel>(CodigoParentescoDeveSerMaiorQueZero, "Código do parentesco deve ser maior que Zero.", ACAlunoResponsavel));
        }
    }
}
