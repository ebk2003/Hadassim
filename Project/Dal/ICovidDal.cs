using Entities;
using Entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{

    public interface ICovidDal
    {
        public List<Covid> GetAllCovids();
   
        public List<Covid> GetCovidById(string Id);
        
    }
}
