using Dal;
using Bll;
using Microsoft.AspNetCore.Mvc;
using Dto;


namespace Project.Controllers
{
    [Route("api/Covid")]
    [ApiController]
    public class CovidController : ControllerBase
        
    {
        ICovidBll CovidBll;
        public CovidController(ICovidBll covidBll)
        {
           this.CovidBll = covidBll;
        }
        //----------------------------------------------------------------------------------

        //return all the vaccines in table corona
        [HttpGet]
        public IActionResult GetAllVaccines()
        { var covidVaccine=this.CovidBll.getAll();
          if(covidVaccine == null) { return BadRequest("Not found Vaccines"); }
          return Ok(covidVaccine);
        }
        //----------------------------------------------------------------------------------

        [HttpGet("{id}")]
        public IActionResult GetVaccineById(string id)
        {
            var member = this.CovidBll.getById(id);

            if (member== null || member.Count ==0)
            {
                return BadRequest("Invalid ID");
            }

            return Ok(member);
        }

        //----------------------------------------------------------------------------------

    }
}
