﻿using FluentValidation;
using RCM.Domain.Commands.ProdutoCommands;

namespace RCM.Domain.Validators.ProdutoCommandValidators
{
    public class ProdutoCommandValidator<T> : AbstractValidator<T> where T : ProdutoCommand 
    {
        public void ValidateId()
        {
            RuleFor(p => p.Id)
                .NotEmpty()
                .WithMessage("O Id do produto não pode estar em branco.");
        }

        public void ValidateNome()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .WithMessage("O nome do produto deve ter entre 5 e 100 caracteres e não deve estar em branco.");
        }

        public void ValidateAplicacao()
        {
            RuleFor(p => p.Aplicacao)
                .NotEmpty()
                .WithMessage("A aplicação do produto deve entre 10 e 1000 carateres e não deve estar em branco.");
        }

        public void ValidateQuantidade()
        {
            RuleFor(p => p.Quantidade)
                .NotEmpty()
                .WithMessage("A quantidade do produto não deve estar em branco.");
        }


        public void ValidatePrecoVenda()
        {
            RuleFor(p => p.PrecoVenda)
                .NotEmpty()
                .WithMessage("O preço de venda do produto não deve estar em branco.");
        }
    }
}
