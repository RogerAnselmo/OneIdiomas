﻿using One.Domain.Entities;
using One.Domain.Validation.Interface;
using System;

namespace One.Domain.Specifications.ACAvaliacaoSpecification
{
    public class NotaDeveSerValida : ISpecification<ACAvaliacao>
    {
        public bool IsSatisfiedBy(ACAvaliacao entity)
        {
            throw new NotImplementedException();
        }
    }
}
