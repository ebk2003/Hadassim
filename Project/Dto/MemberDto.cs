using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.models;

namespace Dto
{
    public class MemberDto

    {
        public MemberDto() { }
      
        //A first name can only contain letters, the first name at least 2 letters , first name is Required field
        //-------------------------------------------------------------------------------------------
        [Required(ErrorMessage = "First name is required")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters long")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters.")]
        public String firstName { get; set; }
        //A last name can only contain letters, the last name at least 2 letters , last name is Required field
        //-------------------------------------------------------------------------------------------
        [Required(ErrorMessage = "Last name is required")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters long")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters.")]
        public String lastName { get; set; }
        //------------------------------------------------------------------------------------------
        //identity is must be 9 digits , identity is required,must have just digits
        [Required(ErrorMessage = "identity is required")]
        [RegularExpression("^[0-9]*$")]
        [StringLength(9)]
        public String identity { get; set; }
        //------------------------------------------------------------------------------------------
        [Required(ErrorMessage = "city is required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters.")]
        
        public String city { get; set; }
        //------------------------------------------------------------------------------------------
        
        [Required(ErrorMessage = "street is required")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The {0} field must only contain letters.")]
        public String street { get; set; }
        //-------------------------------------------------------------------------------------------
        [Required(ErrorMessage = "House number is required")]

        [RegularExpression("^[0-9]+$", ErrorMessage = "The {0} field must only contain numbers.")]
        public int houseNumber { get; set; }
        //-------------------------------------------------------------------------------------------
        [Required(ErrorMessage = " Birthdate is required")]
        [DataType(DataType.Date)]
        public DateTime birthDate { get; set; }
        //------------------------------------------------------------------------------------------
        [Phone]
        public string phone { get; set; }
        //------------------------------------------------------------------------------------------
        [Phone]
        [Required(ErrorMessage = " Mobile phone is required")]

        public string mobilePhone { get; set; }
        //------------------------------------------------------------------------------------------

        [DataType(DataType.Date)]
        public DateTime recoveryDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime possitiveResultDate { get; set; }
       //-------------------------------------------------------------------------------------------
      
    }
}
