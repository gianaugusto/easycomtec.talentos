using System;
using System.Collections.Generic;
using System.Linq;
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
                       bool periodoComercial,
                       string informacaoBancaria
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

            Conhecimentos = new List<TalentoConhecimento>();
        }

        public void Update(
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
                       bool horasAteQuatro,
                       bool horasQuatroASeis,
                       bool horasSeisAOito,
                       bool horasAcimaDeOito,
                       bool horasFimDeSemana,
                       bool periodoManha,
                       bool periodoTarde,
                       bool periodoNoite,
                       bool periodoMadrugada,
                       bool periodoComercial,
                       string informacaoBancaria
                      )
        {
          
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

            if (Conhecimentos == null)
                Conhecimentos = new List<TalentoConhecimento>();
        }

        public void AddBanco(TalentoBanco banco) {

            if(this.Banco == null)
                this.Banco = banco;
            else{
                
                this.Banco.BancoAgencia = banco.BancoAgencia;
                this.Banco.BancoBeneficiario = banco.BancoBeneficiario;
                this.Banco.BancoConta = banco.BancoConta;
                this.Banco.BancoCpf = banco.BancoCpf;
                this.Banco.BancoNome = banco.BancoNome;
                this.Banco.BancoContaCorrente = banco.BancoContaCorrente;
                this.Banco.BancoContaPoupanca = banco.BancoContaPoupanca;

            }

        } 


		//public void AddBanco(TalentoBanco banco) => Banco = banco;

        public void AddRangeConhecimento(IEnumerable<TalentoConhecimento> conhecimentos)
        {
            TalentoConhecimento conhecimento;

            foreach (var item in conhecimentos)
            {
                conhecimento = Conhecimentos.FirstOrDefault(c => c.ConhecimentoID == item.ConhecimentoID && c.TalentoID == item.TalentoID);

                if (conhecimento != null)
                    conhecimento.SetNivel(item.Nivel);
                else
                    AddConhecimento(item);
            }

        }

        public void AddConhecimento(TalentoConhecimento conhecimento)
        {
            if(Conhecimentos == null)
                Conhecimentos = new List<TalentoConhecimento>();

            Conhecimentos.Add(conhecimento);
        }

        public virtual List<TalentoConhecimento> Conhecimentos { get ; private set; }

        public virtual TalentoBanco Banco { get; private set; }

        public string Nome { get; private set; }

        public string Email { get; private set; }

        public string Telefone { get; private set; }

        public string Skype { get; private set; }

        public string Linkedin { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }

        public string Portfolio { get; private set; }

        public bool? HorasAteQuatro { get; private set; }

        public bool? HorasQuatroASeis { get; private set; }

        public bool? HorasSeisAOito { get; private set; }

        public bool? HorasAcimaDeOito { get; private set; }

        public bool? HorasFimDeSemana { get; private set; }

        public bool? PeriodoManha { get; private set; }

        public bool? PeriodoTarde { get; private set; }

        public bool? PeriodoNoite { get; private set; }

        public bool? PeriodoMadrugada { get; private set; }

        public bool? PeriodoComercial { get; private set; }

        public decimal? Pretensao { get; private set; }
        
        public string InformacaoBancaria { get; private set; } 
        
        public string LinkCrud { get; private set; }

        //public void Validate()
        //{
        //    throw new NotImplementedException();
        //}

    }
}
