using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmpSpaceDataAccess.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmpSpaceWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpSpaceController : ControllerBase
    {
        IEmpSpaceRepository _empRepository;

        public EmpSpaceController(IEmpSpaceRepository empRepository)
        {
            _empRepository = empRepository;
        }


        
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var allEmployee = _empRepository.GetEmployees();
            return Ok(allEmployee);
        }

   

        //// GET api/values/5
        //[HttpGet("{id}")]
        //public ActionResult<string> Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
