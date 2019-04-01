using Icatu.EmployeeManagerAPI.Business;
using Microsoft.AspNetCore.Mvc;
using Icatu.EmployeeManagerAPI.Data.VO;

namespace Icatu.EmployeeManagerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonBusiness _personBusiness;

        public PersonsController(IPersonBusiness personBusiness)
        {
            _personBusiness = personBusiness;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_personBusiness.FindAll());
        }
        
        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody]PersonVO person)
        {
            if (person == null)
            {
                return BadRequest();
            }

            return new ObjectResult(_personBusiness.Create(person));
        }

        //[HttpPut("{id}")]
        public IActionResult Put([FromBody]PersonVO person)
        {
            if (person == null)
            {
                return BadRequest();
            }

            var updatedPerson = _personBusiness.Update(person);
            if(updatedPerson == null)
            {
                return NoContent();
            }

            return new ObjectResult(updatedPerson);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _personBusiness.Delete(id);
            return NoContent();
        }
    }
}
