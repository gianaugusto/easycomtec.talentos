using System;
using System.Collections.Generic;
//using FluentValidation;

namespace Database.Models
{
    public class Talento : EntityBase//, IValidatable//, IRequest<Response>, INotification
    {
        public Talento()
        {}

        public Talento(Guid id, 
                       string nome, 
                       string email, 
                       string skype, 
                       string telefone, 
                       string linkedIn, 
                       string cidade, 
                       string estado, 
                       string portfolio, 
                       decimal pretensao, 
                       string linkCrud,
                       bool  horasAteQuatro,
                       bool horasQuatroASeis,
                       bool  horasSeisAOito,
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

        }

        public void AddBanco(TalentoBanco banco) => Banco = banco;

        public void AddRangeConhecimento(List<TalentoConhecimento> conhecimentos) => Conhecimentos.AddRange(conhecimentos);

        public void AddConhecimento(TalentoConhecimento conhecimento) => Conhecimentos.Add(conhecimento);

        public virtual List<TalentoConhecimento> Conhecimentos { get; private set; }

        public virtual TalentoBanco Banco { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Telefone { get; private set; }

        public string Skype { get; private set; }

        public string Linkedin { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }

        public string Portfolio { get; private set; }

        public bool HorasAteQuatro { get; private set; }

        public bool HorasQuatroASeis { get; private set; }

        public bool HorasSeisAOito { get; private set; }

        public bool HorasAcimaDeOito { get; private set; }

        public bool HorasFimDeSemana { get; private set; }

        public bool PeriodoManha { get; private set; }

        public bool PeriodoTarde { get; private set; }

        public bool PeriodoNoite { get; private set; }

        public bool PeriodoMadrugada { get; private set; }

        public bool PeriodoComercial { get; private set; }

        public decimal Pretensao { get; private set; }
        
        public string InformacaoBancaria { get; private set; } 
        
        public string LinkCrud { get; private set; }

        //public void Validate()
        //{
        //    throw new NotImplementedException();
        //}

    }
}
