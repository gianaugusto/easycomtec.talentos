using System;
using System.Collections.Generic;
using Database.Interfaces;
using Database.Models;

namespace Database.Tools
{
    public class Seed
    {
        private readonly ITalentoRepository talentoRepository;
        private readonly Context context;
       

        public Seed(ITalentoRepository talentoRepository, Context context)
        {
            this.talentoRepository = talentoRepository;
            this.context = context;
        }

        public void ConhecimentoInicial(){
            foreach (var item in GetConhecimentos())
            {
                context.Add<Conhecimento>(item);
            }

            context.SaveChanges();
        }

        public void UsuarioInicial(){
            var talento = GetTalento();

            // informacoes do banco
            talento.AddBanco(GetBanco(talento.Id));

            talentoRepository.Add(talento);

            talentoRepository.SaveChanges();
        }

        public Talento GetTalento()
        => new Talento(Guid.Parse("312294c7-b6c6-452b-a44e-000000000000"),
                       "Giancarlos Macedo",
                       "gianaugusto@gmail.com",
                       "gianaugusto",
                        "15997575127",
                       "http://gianaugusto@gmail.com",
                "gianaugusto",
                "sorocaba",
                "SP",
                70,
                "http://github.com/gianaugusto",
                       true, true, true, true, true, true, true, true, true,true);


        public TalentoBanco GetBanco(Guid talentoID)
            => new TalentoBanco(
            Guid.NewGuid(),
            talentoID,
            "330.252.328-00",
            "Itau",
            "8513",
            true,
            false,
            "07543-1",
            "Giancarlos Augusto Macedo");

        public IEnumerable<TalentoConhecimento> GetTalentoConhecimentos(Guid talentoID)
        {

            var conhecimentos = new List<TalentoConhecimento>();

            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7251ad"), talentoID, NivelConhecimento.Senior));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7252ad"), talentoID, NivelConhecimento.Senior));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7253ad"), talentoID, NivelConhecimento.Senior));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7254ad"), talentoID, NivelConhecimento.Senior));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7255ad"),talentoID, NivelConhecimento.Senior));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7256ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7257ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7258ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7259ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7211ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7221ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7231ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7241ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7251ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7261ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7271ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7281ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7291ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7151ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7251ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7351ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7451ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7551ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7651ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7751ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7851ad"),talentoID));


            return conhecimentos;
        }

        public IEnumerable<Conhecimento> GetConhecimentos(){

            var conhecimentos = new List<Conhecimento>();

            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7251ad"),"Ionic"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7252ad"), "Android"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7253ad"), "IOS"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7254ad"), "HTML"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7255ad"), "CSS"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7256ad"), "Bootstrap"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7257ad"), "Jquery"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7258ad"), "AngularJs"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7259ad"), "Java"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7211ad"), "Asp.Net MVC "));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7221ad"), "C"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7231ad"), "C++"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7241ad"), "Cake"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7251ad"), "Django"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7261ad"), "Majento"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7271ad"), "PHP"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7281ad"), "Veu"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7291ad"), "Wordpress"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7151ad"), "Phyton"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7251ad"), "Ruby"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7351ad"), "My SQL Server"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7451ad"), "My SQL"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7551ad"), "Salesforce"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7651ad"), "Photoshop"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7751ad"), "Illustrator"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("312294c7-b6c6-452b-a44e-2a680e7851ad"), "SEO"));


            return conhecimentos;
        }

    }
}
