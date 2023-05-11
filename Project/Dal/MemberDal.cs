using Entities;
using Entities.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{

    public class MemberDal : IMemberDal
    {
        public Hmo hmo;
        public MemberDal(Hmo hmo)
        {
            this.hmo = hmo;
        }
        //----------------------------------------------------------------------------------
        //public void AddMemberVaccine(string identity, Covid Covid)
        //{

        //    var member = hmo.members.Include(p=>p.covidDates).Where(p => p.identity == identity).FirstOrDefault();
        //    if (member != null)
        //    {
        //        Covid.member = member;
        //        Covid.memberId = member.id;
        //        if (member.covidDates != null)
        //        {
        //            if (member.covidDates.Count() <4)
        //            {
        //                member.covidDates.Add(Covid);
        //            }
        //            else
        //            {
        //                throw new Exception("Cannot add another Covid instance to member as maximum limit of 4 has been reached.");
        //            }
        //        }
        //        else
        //        {
        //            member.covidDates = new List<Covid>();
        //            member.covidDates.Add(Covid);
        //        }
        //        hmo.SaveChanges();
        //    }
        //    else
        //    {
        //        throw new Exception("member does not exists");
        //    }
        //}
        //----------------------------------------------------------------------------------
        public bool AddMemberVaccine(string identity, Covid Covid)
        {
            var member = hmo.members.Include(p => p.covidDates).Where(p => p.identity == identity).FirstOrDefault();
            if (member != null)
            {
                Covid.member = member;
                Covid.memberId = member.id;
                if (member.covidDates != null)
                {
                    if (member.covidDates.Count() < 4)
                    {
                        member.covidDates.Add(Covid);
                        hmo.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    member.covidDates = new List<Covid>();
                    member.covidDates.Add(Covid);
                    hmo.SaveChanges();
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        //--------------------------------------------------------------------------------
        public void AddMember(Member member)
        {
            hmo.members.Add(member);
            hmo.SaveChanges();
          
        }

        public List<Member> GetAllMembers()
        {
            return hmo.members.ToList();
        }

        public Member GetMemberById(string memberId)
        {
         
            return hmo.members.FirstOrDefault(p => p.identity.Equals(memberId));
        }
        //----------------------------------------------------------------------------------


    }
}
