using System;
using AutoMapper;
using AutoMapper.Configuration;

namespace WebApi.Map
{
   
        public static class MapperInitializer
        {
            /// <summary>
            /// Initialize mapper
            /// </summary>
            public static void Init()
            {
                // Static mapper
                Mapper.Initialize(Configuration);

                // ...Or instance mapper
                var mapperConfiguration = new MapperConfiguration(Configuration);
                var mapper = mapperConfiguration.CreateMapper();
                // ...
            }

            /// <summary>
            /// Mapper configuration
            /// </summary>
            public static MapperConfigurationExpression Configuration { get; } = new MapperConfigurationExpression();
        }
    }

