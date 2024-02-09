using CarPrice_DataAccess.Entities;
using CarPrice_DataAccess.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.IdentityModel.Tokens;

namespace CarPrice_DataAccess.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class CarController : ControllerBase
{
    private readonly ICarRepository _carRepository;
    public CarController(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    [HttpGet]
    [Route("GetCarBrands")]
    public async Task<ActionResult<IEnumerable<string>>> GetCarBrands()
    {
        try
        {
            var carBrands = await _carRepository.GetCarBrands();
            if(carBrands.IsNullOrEmpty())
            {
                return NotFound();
            }
            else
            {
                return Ok(carBrands);                                                   
            }
        }
        catch(Exception)
        {
            return StatusCode(500, "Error retrieving car brand data from database.");   //Internal Server Error Status Code
        }
    }   


}