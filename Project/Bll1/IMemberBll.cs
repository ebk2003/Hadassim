using Dal;
using Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   
    public interface IMemberBll
    {

        public void post(MemberDto Member);
        public List<MemberDto> getAll();
        public MemberDto getById(string id);
        public bool AddMemberVaccine(string identity, CovidDto covid);

    }
}
