using System;
using System.Collections.Generic;
using Database.Interfaces;
using Database.Models;

namespace Database.Tools
{
    public class Seed
    {
        //private readonly ITalentoRepository talentoRepository;
        private readonly Context context;
       

        public Seed( Context context)
        {
            //this.talentoRepository = talentoRepository;
            this.context = context;
        }

        public void ConhecimentoInicial(){
            try
            {
                foreach (var item in GetConhecimentos())
                {
                    context.Add<Conhecimento>(item);
                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }

        public void UsuarioInicial(){

            try{
                var talento = GetTalento();

                // informacoes do banco
                talento.AddBanco(GetBanco(talento.Id));

                // conhecimento
                talento.AddRangeConhecimento(GetTalentoConhecimentos(talento.Id));

                // add to context
                context.Add<Talento>(talento);

                // save
                context.SaveChanges();
            }catch(Exception e){
                Console.Write(e);
            }

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
                       true, true, true, true, true, true, true, true, true,true,"");


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

            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("002294c7-b6c6-452b-a44e-2a680e7551ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("012294c7-b6c6-452b-a44e-2a680e7651ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("022294c7-b6c6-452b-a44e-2a680e7751ad"),talentoID));
            conhecimentos.Add(new TalentoConhecimento(Guid.Parse("032294c7-b6c6-452b-a44e-2a680e7851ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("042294c7-b6c6-452b-a44e-2a680e7251ad"), talentoID, NivelConhecimento.Senior));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("052294c7-b6c6-452b-a44e-2a680e7252ad"), talentoID, NivelConhecimento.Senior));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("072294c7-b6c6-452b-a44e-2a680e7253ad"), talentoID, NivelConhecimento.Senior));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("082294c7-b6c6-452b-a44e-2a680e7254ad"), talentoID, NivelConhecimento.Senior));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("092294c7-b6c6-452b-a44e-2a680e7255ad"),talentoID, NivelConhecimento.Senior));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("102294c7-b6c6-452b-a44e-2a680e7256ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("112294c7-b6c6-452b-a44e-2a680e7257ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("122294c7-b6c6-452b-a44e-2a680e7258ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("132294c7-b6c6-452b-a44e-2a680e7259ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("142294c7-b6c6-452b-a44e-2a680e7211ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("152294c7-b6c6-452b-a44e-2a680e7221ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("162294c7-b6c6-452b-a44e-2a680e7231ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("172294c7-b6c6-452b-a44e-2a680e7241ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("182294c7-b6c6-452b-a44e-2a680e7251ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("192294c7-b6c6-452b-a44e-2a680e7261ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("202294c7-b6c6-452b-a44e-2a680e7271ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("212294c7-b6c6-452b-a44e-2a680e7281ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("222294c7-b6c6-452b-a44e-2a680e7291ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("232294c7-b6c6-452b-a44e-2a680e7151ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("242294c7-b6c6-452b-a44e-2a680e7251ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("252294c7-b6c6-452b-a44e-2a680e7351ad"),talentoID));
			conhecimentos.Add(new TalentoConhecimento(Guid.Parse("262294c7-b6c6-452b-a44e-2a680e7451ad"),talentoID));


            return conhecimentos;
        }

        public IEnumerable<Conhecimento> GetConhecimentos(){

            var conhecimentos = new List<Conhecimento>();

            conhecimentos.Add(new Conhecimento(Guid.Parse("002294c7-b6c6-452b-a44e-2a680e7551ad"),"Ionic"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("012294c7-b6c6-452b-a44e-2a680e7651ad"), "Android"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("022294c7-b6c6-452b-a44e-2a680e7751ad"), "IOS"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("032294c7-b6c6-452b-a44e-2a680e7851ad"), "HTML"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("042294c7-b6c6-452b-a44e-2a680e7251ad"), "CSS"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("052294c7-b6c6-452b-a44e-2a680e7252ad"), "Bootstrap"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("072294c7-b6c6-452b-a44e-2a680e7253ad"), "Jquery"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("082294c7-b6c6-452b-a44e-2a680e7254ad"), "AngularJs"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("092294c7-b6c6-452b-a44e-2a680e7255ad"), "Java"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("102294c7-b6c6-452b-a44e-2a680e7256ad"), "Asp.Net MVC "));
            conhecimentos.Add(new Conhecimento(Guid.Parse("112294c7-b6c6-452b-a44e-2a680e7257ad"), "C"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("122294c7-b6c6-452b-a44e-2a680e7258ad"), "C++"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("132294c7-b6c6-452b-a44e-2a680e7259ad"), "Cake"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("142294c7-b6c6-452b-a44e-2a680e7211ad"), "Django"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("152294c7-b6c6-452b-a44e-2a680e7221ad"), "Majento"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("162294c7-b6c6-452b-a44e-2a680e7231ad"), "PHP"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("172294c7-b6c6-452b-a44e-2a680e7241ad"), "Veu"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("182294c7-b6c6-452b-a44e-2a680e7251ad"), "Wordpress"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("192294c7-b6c6-452b-a44e-2a680e7261ad"), "Phyton"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("202294c7-b6c6-452b-a44e-2a680e7271ad"), "Ruby"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("212294c7-b6c6-452b-a44e-2a680e7281ad"), "My SQL Server"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("222294c7-b6c6-452b-a44e-2a680e7291ad"), "My SQL"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("232294c7-b6c6-452b-a44e-2a680e7151ad"), "Salesforce"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("242294c7-b6c6-452b-a44e-2a680e7251ad"), "Photoshop"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("252294c7-b6c6-452b-a44e-2a680e7351ad"), "Illustrator"));
            conhecimentos.Add(new Conhecimento(Guid.Parse("262294c7-b6c6-452b-a44e-2a680e7451ad"), "SEO"));


            return conhecimentos;
        }

    }
}
