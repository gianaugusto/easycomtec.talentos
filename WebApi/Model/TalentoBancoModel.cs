﻿using System;

namespace WebApi.Model
{
    public class TalentoBancoModel
    {
        public TalentoBancoModel(
                                Guid id,
                                Guid talentoID,
                                string bancoCpf,
                                string bancoNome,
                                string bancoAgencia,
                                bool bancoContaCorrente,
                                bool bancoContaPoupanca,
                                string bancoConta,
                                string banco,
                                string bancoBeneficiario)
        {

            Id = id;

            TalentoID = talentoID;

            BancoCpf = bancoCpf;

            BancoNome = bancoNome;

            BancoAgencia = bancoAgencia;

            BancoContaCorrente = bancoContaCorrente;

            BancoContaPoupanca = bancoContaPoupanca;

            BancoConta = bancoConta;

            Banco = banco;

            BancoBeneficiario = bancoBeneficiario;

        }

        public Guid Id { get; set; }

        public Guid? TalentoID { get; set; }

        public string Banco { get; set; }

        public string BancoBeneficiario { get; set; }

        public string BancoCpf { get; set; }

        public string BancoNome { get; set; }

        public string BancoAgencia { get; set; }

        public bool BancoContaCorrente { get; set; }

        public bool BancoContaPoupanca { get; set; }

        public string BancoConta { get; set; }

        public virtual TalentoModel Talento { get; set; }

    }
}