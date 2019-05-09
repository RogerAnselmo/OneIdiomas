using One.Domain.Entities;
using One.Domain.Specifications.ACProfessorSpecification;
using One.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace One.Domain.Validations.ACProfessorValidation
{
    public class ACProfessorConsistenteValidation : Validator<ACProfessor>
    {
         public ACProfessorConsistenteValidation(ACProfessor ACProfessor)
        {
            var CPFDeveSerValido = new CPFDeveSerValido();
            var DataDeNascimentoDeveSerValida = new DataDeNascimentoDeveSerValida();
            var CodigoDeUsuarioDeveSerMaiorQueZero = new CodigoDeUsuarioDeveSerMaiorQueZero();
            var RGDeveSerValido = new RGDeveSerValido();

            base.Add("CPFDeveSerValido", new Rule<ACProfessor>(CPFDeveSerValido, "Professor deve ter um CPF válido.", ACProfessor));
            base.Add("DataDeNascimentoDeveSerValida", new Rule<ACProfessor>(DataDeNascimentoDeveSerValida, "Professor deve ter data de nascimento válida.", ACProfessor));
            base.Add("CodigoDeUsuarioDeveSerMaiorQueZero", new Rule<ACProfessor>(CodigoDeUsuarioDeveSerMaiorQueZero, "Professor deve ter um código de usuário.", ACProfessor));
            base.Add("RGDeveSerValido", new Rule<ACProfessor>(RGDeveSerValido, "RG do professor deve ser válido.", ACProfessor));
        }
    }
}
