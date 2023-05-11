using Entities;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{

    public class CovidDal : ICovidDal
    {
        public Hmo hmo;
        //----------------------------------------------------------------------------------
        public CovidDal(Hmo hmo)
        {
            this.hmo = hmo;
        }
        //----------------------------------------------------------------------------------
        public List<Covid> GetAllCovids()
        {
            return hmo.covids.ToList();
        }
        //----------------------------------------------------------------------------------
        public List<Covid> GetCovidById(string memberId)
        {
            return hmo.covids.Where(p => p.member.identity.Equals(memberId)).ToList();
        }



    }
}
