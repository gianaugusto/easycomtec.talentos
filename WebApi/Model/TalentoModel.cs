using System;
using System.Collections.Generic;

namespace WebApi.Model
{
    public class TalentoModel
    {
        public TalentoModel()
        {

        }

        public TalentoModel(Guid id,
                       string nome,
                       string email,
                       string skype,
                       string telefone,
                       string linkedIn,
                       string cidade,
                       string estado,
                       string portfolio,
                       string informacaoBancaria,
                       decimal pretensao,
                       string linkCrud,
                       bool horasAteQuatro,
                       bool horasQuatroASeis,
                       bool horasSeisAOito,
                       bool horasAcimaDeOito,
                       bool horasFimDeSemana,
                       bool periodoManha,
                       bool periodoTarde,
                       bool periodoNoite,
                       bool periodoMadrugada,
                       bool periodoComercial
                      )
        {
            Id = id;

            Nome = nome;

            Email = email;

            Telefone = telefone;

            Skype = skype;

            Linkedin = linkedIn;

            Cidade = cidade;

            Estado = estado;

            Portfolio = portfolio;

            HorasAteQuatro = horasAteQuatro;

            HorasQuatroASeis = horasQuatroASeis;

            HorasSeisAOito = horasSeisAOito;

            HorasAcimaDeOito = horasAcimaDeOito;

            HorasFimDeSemana = horasFimDeSemana;

            PeriodoManha = periodoManha;

            PeriodoTarde = periodoTarde;

            PeriodoNoite = periodoNoite;

            PeriodoMadrugada = periodoMadrugada;

            PeriodoComercial = periodoComercial;

            Pretensao = pretensao;

            LinkCrud = linkCrud;

            InformacaoBancaria = informacaoBancaria;

        }

        public virtual List<TalentoConhecimentoModel> Conhecimentos { get; set; }

        public virtual TalentoBancoModel Banco { get; set; }

        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public string Skype { get; set; }

        public string Linkedin { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public string Portfolio { get; set; }

        public bool HorasAteQuatro { get; set; }

        public bool HorasQuatroASeis { get; set; }

        public bool HorasSeisAOito { get; set; }

        public bool HorasAcimaDeOito { get; set; }

        public bool HorasFimDeSemana { get; set; }

        public bool PeriodoManha { get; set; }

        public bool PeriodoTarde { get; set; }

        public bool PeriodoNoite { get; set; }

        public bool PeriodoMadrugada { get; set; }

        public bool PeriodoComercial { get; set; }

        public decimal Pretensao { get; set; }

        public string InformacaoBancaria { get; set; } 

        public string LinkCrud { get; set; }

    }
}
