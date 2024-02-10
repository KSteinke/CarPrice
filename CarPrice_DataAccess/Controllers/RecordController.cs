
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace CarPrice_DataAccess.Controllers;
[Route("api/v1/[controller]")]
[ApiController]
public class RecordController : ControllerBase
{       
        [HttpGet]
        [Route("GetRecords")]
        public async Task<ActionResult<IEnumerable<RecordDto>>> GetRecords([FromBody] )
        {
            try
            {

            }
            catch(Exception)
            {
                //Internal Server Error Status Code
                return StatusCode(500, "Error retrieving data from database."); 
            }
        }
}