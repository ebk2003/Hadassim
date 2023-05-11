using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.models
{
    public class Covid
    {   public Covid() { }
        public int id { get; set; }
        public DateTime vaccinationDate { get; set; }
        public string vaccineProductorName { get; set; } 
        public int memberId { get; set; }
        public Member member { get; set; }

    }
}
