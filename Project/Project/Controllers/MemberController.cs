using Bll;
using Dto;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Project.Controllers
{
    [Route("api/members")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        IMemberBll memberBll;
        public MemberController(IMemberBll memberBll)
        {
            this.memberBll  = memberBll;
        }
        //----------------------------------------------------------------------------------
        //give all the members from the database
        [HttpGet]
        public IActionResult GetAllMembers()
        {
            var members= this.memberBll.getAll();
            if(members==null) { return BadRequest("Not found members"); }
            return Ok(members);
        }
        //----------------------------------------------------------------------------------
        // give member by identity number
        [HttpGet("{id}")]
        public ActionResult GetMemberById(string id)
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            var member = this.memberBll.getById(id);

            if (member == null) { return NotFound("there is no member with this identity"); }
            return Ok(member);
        }
        //----------------------------------------------------------------------------------
        // add the member to th table 
        [HttpPost]
        public IActionResult addMember([FromBody] MemberDto value)
        {   if(!(value.recoveryDate>value.possitiveResultDate)) { return BadRequest("The recovery date must be after possitive Corona Date"); }
            if(!ModelState.IsValid) { return BadRequest(ModelState); }
           
             this.memberBll.post(value);
            return Ok();
        }
        //----------------------------------------------------------------------------------
        ////add a vaccine to a member
        //[HttpPost("{identity}")]

        //public ActionResult AddVaccineToMember(string identity,[FromBody] CovidDto value)
        //{ if(!ModelState.IsValid) { return BadRequest(ModelState); }
        //    var member= this.memberBll.getById(identity);
        //    if(member==null) { return  NotFound("there is no member with this identity"); }
        //    this.memberBll.AddMemberVaccine(identity,value);
        //    return Ok();
        //}
        //----------------------------------------------------------------------------------
        [HttpPost("{identity}")]
        public IActionResult AddVaccineToMember(string identity, [FromBody] CovidDto value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var member = this.memberBll.getById(identity);

            if (member == null)
            {
                return NotFound("There is no member with this identity.");
            }

            bool vaccineAdded = this.memberBll.AddMemberVaccine(identity, value);

            if (vaccineAdded)
            {
                return Ok();
            }
            else
            {
                return BadRequest("Cannot add another Vaccine instance to member as maximum limit of 4 has been reached.");
            }
        }


    }
}
