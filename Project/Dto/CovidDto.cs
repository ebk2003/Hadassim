using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class CovidDto

    {public CovidDto() { }
       
        //--------------------------------------------------------------------------
        [Required(ErrorMessage = "The date is required")]
        public DateTime vaccinationDate { get; set; }
        //--------------------------------------------------------------------------
        [Required(ErrorMessage = "Manufacturer is required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters.")]
        public string vaccineProductorName { get; set; }
      //--------------------------------------------------------------------------
    }
}
