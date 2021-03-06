﻿using RCM.Domain.Core.Models;
using RCM.Domain.Models.ChequeModels;
using RCM.Domain.Models.ValueObjects;
using System;
using System.Collections.Generic;

namespace RCM.Domain.Models.ClienteModels
{
    public class Cliente : Entity<Cliente>
    {
        public string Nome { get; private set; }

        public ClienteTipoEnum Tipo { get; private set; }

        public string Descricao { get; private set; }

        public ClientePontuacaoEnum Pontuacao { get; private set; }

        public Contato Contato { get; private set; }
        public Endereco Endereco { get; private set; }
        public Documento Documento { get; private set; }

        private List<Cheque> _cheques;
        public virtual IReadOnlyList<Cheque> Cheques
        {
            get
            {
                return _cheques;
            }
        }


        protected Cliente() { }

        public Cliente(Guid id, string nome, ClienteTipoEnum tipo, ClientePontuacaoEnum pontuacao, Documento documento, Contato contato, Endereco endereco, string descricao = null)
        {
            Id = id;
            Nome = nome;
            Tipo = tipo;
            Pontuacao = pontuacao;
            Documento = documento;
            Contato = contato;
            Endereco = endereco;
            Descricao = descricao;
            
            _cheques = new List<Cheque>();
        }

        public Cliente(string nome, ClienteTipoEnum tipo, ClientePontuacaoEnum pontuacao, Documento documento, Contato contato, Endereco endereco, string descricao = null)
        {
            Nome = nome;
            Tipo = tipo;
            Pontuacao = pontuacao;
            Documento = documento;
            Contato = contato;
            Endereco = endereco;
            Descricao = descricao;
            
            _cheques = new List<Cheque>();
        }
    }
}