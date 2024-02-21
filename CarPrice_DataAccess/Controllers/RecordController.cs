
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

        [HttpPost]
        [Route("PostRecords")]
        public async Task<ActionResult<IEnumerable<PostRecordsDto>>> PostRecords([FromBody] SearchDataDto searchDataDto)
        {
            try
            {
                var postRecordsDtos = await _recordRepository.PostRecords(searchDataDto);
                if(postRecordsDtos.IsNullOrEmpty())
                {
                    return NotFound();
                }
                else
                {
                    return Ok(postRecordsDtos);
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
                if(uploadRecordDto == null)
                {
                    return BadRequest();
                }
                
                var result = await _recordRepository.UploadRecord(uploadRecordDto) ?? throw new InvalidOperationException("Error saving data from database.");  //Throw error if error during database save

                return Ok();

            }
            catch(Exception ex)
            {
                return StatusCode(500, ex.Message); 
            }
        }
}