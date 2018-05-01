using System;
using AutoMapper;
using Database.Models;
using WebApi.Model;

namespace WebApi.Map
{
    public class MapCustom: Profile
    {
        public MapCustom()
        {
            CreateMap<TalentoConhecimentoModel, TalentoConhecimento>()
                .ForMember(x => x.Conhecimento, opt => opt.Ignore())
                .ForMember(x => x.Talento, opt => opt.Ignore());
            
        }
    }
}
