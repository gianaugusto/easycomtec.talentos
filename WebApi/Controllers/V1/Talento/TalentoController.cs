using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Database.Interfaces;
using Database.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    
    [Route("api/v1/[controller]")]
    public class TalentoController : Controller
    {
        private readonly ITalentoRepository talentoRepository;
        private IMapper mapper;


        public TalentoController(ITalentoRepository talentoRepository, IMapper mapper)
        {
            this.talentoRepository = talentoRepository;
            this.mapper = mapper;
        }

        // GET api/talento
        [HttpGet]
        public IEnumerable<TalentoModel> Get(){

            try{
                var talentos = talentoRepository                   
                .GetAll()           
                .Include(t => t.Banco)
                .Include(t => t.Conhecimentos)
                .ToList();

                return mapper.Map<IEnumerable<TalentoModel>>(talentos);    
        
            }catch(Exception e){
                Console.Write(e);
                return new List<TalentoModel>();
            }
        }


        // GET api/talento/5
        [HttpGet("{id}")]
        public TalentoModel Get(Guid id)
        => mapper.Map<TalentoModel>(talentoRepository.GetByID(id));

        // GET api/talento/email/aa@qaa.com
        [HttpGet("email/{email}")]
        public TalentoModel Get(string email)
        => mapper.Map<TalentoModel>(talentoRepository.GetByEmail(email));

        // POST api/talento
        [HttpPost]
        public void Post([FromBody]TalentoModel model)
        {
            talentoRepository.Add(mapper.Map<Talento>(model));
            talentoRepository.SaveChanges();
        }

        // PUT api/talento/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody]TalentoModel model)
        {
            var talento = talentoRepository
                .GetAll()
                .Include(t => t.Banco)
                .Include(t => t.Conhecimentos)
                .FirstOrDefault(o => o.Id == id);

                talento.Update(
                       model.Nome,
                       model.Email,
                       model.Skype,
                       model.Telefone,
                       model.Linkedin,
                       model.Cidade,
                       model.Estado,
                       model.Portfolio,
                       model.Pretensao,
                       model.LinkCrud,
                       model.HorasAteQuatro,
                       model.HorasQuatroASeis,
                       model.HorasSeisAOito,
                       model.HorasAcimaDeOito,
                       model.HorasFimDeSemana,
                       model.PeriodoManha,
                       model.PeriodoTarde,
                       model.PeriodoNoite,
                       model.PeriodoMadrugada,
                       model.PeriodoComercial,
                       model.InformacaoBancaria
                );

            //
            if(model.Banco != null)
                talento.AddBanco(mapper.Map<TalentoBanco>(model.Banco));

            //
            if (model.Conhecimentos != null && model.Conhecimentos.Count > 0)
            {
                var conhecimentos = mapper.Map<List<TalentoConhecimento>>(model.Conhecimentos);
                talento.AddRangeConhecimento(conhecimentos);
               
            }
            talentoRepository.Update(talento);
            talentoRepository.SaveChanges();
           
        }


        // DELETE api/talento/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            talentoRepository.Remove(id);
            talentoRepository.SaveChanges();
        }
    }
}
