using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }


        [HttpGet("getall")]

        public IActionResult GetAll()
        {
            var result = _carService.GetAll();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbydailyprice")]

        public IActionResult GetByDailyPrice()
        {
            var result = _carService.GetByDailyPrice(13000, 15000);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Message);
        }

        [HttpGet("getcarsbybrandid")]

        public IActionResult GetCarsByBrandId(int brandId)
        {
            var result = _carService.GetCarsByBrandId(4);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]

        public IActionResult GetById(int Id)
        {
            var result = _carService.GetById(2);
            if (result.Success)
            {
                return Ok(result.Data);

            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]

        public IActionResult Add(Car car)
        {
            var result = _carService.Add(car);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpDelete("delete")]

        public IActionResult Delete(Car car)
        {
            var result = _carService.Delete(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPut("update")]

        public IActionResult Update(Car car)
        {
            var result = _carService.Update(car);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbycolorid")]

        public IActionResult GetCarsByColorId(int colorId)
        {
            var result = _carService.GetCarsByColorId(3);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getcardetails")]

        public IActionResult GetCarDetails()
        {
            var result = _carService.GetCarDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
