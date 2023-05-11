using AutoMapper;
using Dto;
using Entities;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bll
{
    public  class AutoMapperProfile:Profile
    {
        public AutoMapperProfile() {
            CreateMap<Member, MemberDto>();
            CreateMap<MemberDto, Member>();
            CreateMap<Covid, CovidDto>();
            CreateMap<CovidDto, Covid>();
        }
    }
}
