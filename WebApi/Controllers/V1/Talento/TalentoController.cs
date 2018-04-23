using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Database.Interfaces;
using Database.Models;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

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

            var talentos = talentoRepository.GetAll().ToList();

            return mapper.Map<IEnumerable<TalentoModel>>(talentos);    
        }


        // GET api/talento/5
        [HttpGet("{id}")]
        public TalentoModel Get(Guid id)
        => mapper.Map<TalentoModel>(talentoRepository.GetById(id));

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
            var talento = talentoRepository.GetById(id);

            talento = mapper.Map<Talento>(model);

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
