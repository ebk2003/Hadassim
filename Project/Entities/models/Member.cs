using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.models;

namespace Entities
{
    public partial class Member
    {
         public Member() { }
        public int id { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String identity { get; set; }
        public String city { get; set; }
        public String street { get; set; }
        public int houseNumber { get; set; }
        public DateTime birthDate { get; set; }
        public string phone { get; set; }
        public string mobilePhone { get; set; }
        public DateTime recoveryDate { get; set; }
        public DateTime possitiveResultDate { get; set; }
        public ICollection<Covid> covidDates  { get; set; }



    }
}
