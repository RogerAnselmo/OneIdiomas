﻿using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACProfessorSpecification
{
    public class RGDeveSerValido : ISpecification<ACProfessor>
    {
        public bool IsSatisfiedBy(ACProfessor entity) 
            => !string.IsNullOrEmpty(entity.RG) && entity.RG.Length <= 20;
    }
}
