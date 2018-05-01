using System;
using AutoMapper;
using AutoMapper.Configuration;
using Database.Models;
using WebApi.Model;

namespace WebApi.Map
{
   
        public static class MapperInitializer
        {
            /// <summary>
            /// Initialize mapper
            /// </summary>
            public static void Init()
            {

                Configuration.AddProfile<MapCustom>();
                      
                // Static mapper
                Mapper.Initialize(Configuration);
                

            }

            /// <summary>
            /// Mapper configuration
            /// </summary>
            public static MapperConfigurationExpression Configuration { get; } 
                                = new MapperConfigurationExpression();
        }
    }

