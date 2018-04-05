﻿using FluentValidation;
using RCM.Domain.Commands.DuplicataCommands;
using System;

namespace RCM.Domain.Validators.DuplicataCommandValidators
{
    public abstract class DuplicataCommandValidator<T> : AbstractValidator<T> where T : DuplicataCommand
    {
        protected void ValidateId()
        {
            RuleFor(c => c.Id)
                .NotEmpty()
                .WithMessage("O Id da duplicata não deve estar vazio.");
        }

        protected void ValidateNumeroDocumento()
        {
            RuleFor(d => d.NumeroDocumento)
                .NotEmpty()
                .MinimumLength(5)
                .MaximumLength(20)
                .WithMessage("O número do documento deve ter entre 5 e 20 caracteres e não pode estar vazio.");
        }

        protected void ValidateObservacao()
        {
            RuleFor(d => d.Observacao)
                .MaximumLength(1000)
                .WithMessage("O campo observação deve ter até 1000 caracteres.");
        }

        protected void ValidateDataEmissao()
        {
            RuleFor(d => d.DataEmissao)
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now)
                .WithMessage("A data de emissão deve estar em um formato válido.");
        }

        protected void ValidateDataVencimento()
        {
            RuleFor(d => d.DataVencimento)
                .NotEmpty()
                .GreaterThanOrEqualTo(d => d.DataEmissao)
                .WithMessage("A data de vencimento deve estar em um formato válido.");
        }

        protected void ValidateValor()
        {
            RuleFor(d => d.Valor)
                .NotEmpty()
                .ExclusiveBetween(1, 99999)
                .WithMessage("O valor da duplicata deve estar em um formato válido.");
        }
    }
}
