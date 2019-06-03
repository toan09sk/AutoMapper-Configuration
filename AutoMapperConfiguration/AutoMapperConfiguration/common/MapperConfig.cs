using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using AutoMapper;
using AutoMapperConfiguration.DTO;

namespace AutoMapperConfiguration.common
{
    public static class MapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<FileInfo, FileViewModel>()
                .ReverseMap();
            });
        }
    }
}