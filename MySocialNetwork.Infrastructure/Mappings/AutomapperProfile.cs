using AutoMapper;
using MySocialNetwork.Core.DTOs;
using MySocialNetwork.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySocialNetwork.Infrastructure.Mappings
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Post, PostDTO>();
            CreateMap<PostDTO, Post>();

            CreateMap<Security, SecurityDTO>();
            CreateMap<SecurityDTO, Security>();
        }
    }
}
