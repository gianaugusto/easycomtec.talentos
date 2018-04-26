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
        => mapper.Map<TalentoModel>(talentoRepository.GetById(id));

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
                    .GetById(id);
            //.Include(t => t.Banco)
            //.Include(t => t.Conhecimentos);

            try
            {

                talento = mapper.Map<Talento>(model);

                talentoRepository.Update(talento);
                talentoRepository.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw ex;
                //foreach (var entry in ex.Entries)
                //{
                //        var proposedValues = entry.CurrentValues;
                //        var databaseValues = entry.GetDatabaseValues();

                //        foreach (var property in proposedValues.Properties)
                //        {
                //            var proposedValue = proposedValues[property];
                //            var databaseValue = databaseValues[property];

                //            // TODO: decide which value should be written to database
                //            // proposedValues[property] = <value to be saved>;
                //        }

                //        // Refresh original values to bypass next concurrency check
                //        entry.OriginalValues.SetValues(databaseValues);
                   
                //}
            }

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
