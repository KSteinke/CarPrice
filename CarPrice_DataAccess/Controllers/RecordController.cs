
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using CarPrice_Models.Dtos;
using CarPrice_DataAccess.Repositories.Interfaces;
using Microsoft.IdentityModel.Tokens;

namespace CarPrice_DataAccess.Controllers;
[Route("api/v1/[controller]")]
[ApiController]
public class RecordController : ControllerBase
{       

        private readonly IRecordRepository _recordRepository;
        public RecordController(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        [HttpGet]
        [Route("GetRecords")]
        public async Task<ActionResult<IEnumerable<GetRecordsDto>>> GetRecords([FromBody] SearchDataDto searchDataDto)
        {
            try
            {
                var getRecordsDtos = await _recordRepository.GetRecords(searchDataDto);
                if(getRecordsDtos.IsNullOrEmpty())
                {
                    return NotFound();
                }
                else
                {
                    return Ok(getRecordsDtos);
                }
            }
            catch(Exception)
            {
                //Internal Server Error Status Code
                return StatusCode(500, "Error retrieving data from database."); 
            }
        }

        [HttpPost]
        [Route("UploadRecord")]
        public async Task<ActionResult> UploadRecord([FromBody] UploadRecordDto uploadRecordDto)
        {
            try
            {
                
            }
            catch(Exception)
            {

            }
        }
}