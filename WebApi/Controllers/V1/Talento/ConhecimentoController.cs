
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Database;
using Database.Interfaces;
using Database.Models;
using Database.Repositories;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

namespace WebApi.Controllers
{
    
    [Route("api/v1/[controller]")]
    public class ConhecimentoController : Controller
    {
        private readonly IConhecimentoRepository conhecimentoRepository;
        private IMapper mapper;


        public ConhecimentoController(IConhecimentoRepository conhecimentoRepository, IMapper mapper)
        {
            this.conhecimentoRepository = conhecimentoRepository;
            this.mapper = mapper;
        }

        // GET api/talento
        [HttpGet]
        public IEnumerable<ConhecimentoModel> Get(){
            return mapper.Map<IEnumerable<ConhecimentoModel>>(conhecimentoRepository.GetAll().ToList());    
        }

    }
}
