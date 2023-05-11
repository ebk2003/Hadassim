using Dal;
using Dto;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entities.models;

namespace Bll
{
   
    public class MemberBll : IMemberBll
    {

        IMemberDal MemberDal;
        IMapper mapper;
        //----------------------------------------------------------------------------------

        public MemberBll(IMemberDal MemberDal, IMapper mapper)
        {
            this.MemberDal = MemberDal;
            this.mapper = mapper;
        }
        //----------------------------------------------------------------------------------

        public List<MemberDto> getAll()
        {
            List<MemberDto> membersDto = mapper.Map<List<MemberDto>>(this.MemberDal.GetAllMembers());
            return membersDto;
        }
        //----------------------------------------------------------------------------------

        public MemberDto getById(string id)
        {
            return mapper.Map<MemberDto>(this.MemberDal.GetMemberById(id));
        }
        //----------------------------------------------------------------------------------


        public void post(MemberDto Member)
        {
           
            this.MemberDal.AddMember(mapper.Map<Member>(Member));

        }
        //----------------------------------------------------------------------------------

        public bool AddMemberVaccine(string identity, CovidDto covid)
        {
            return this.MemberDal.AddMemberVaccine(identity,mapper.Map<Covid>(covid));
   

        }
        //----------------------------------------------------------------------------------


    }
}
