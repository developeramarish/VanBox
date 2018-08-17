using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VanBox.DTOs;
using VanBox.Models;

namespace VanBox.Controllers
{
    [Route("/api/vehicles")]
    public class VehiclesContorller : Controller
    {
        private readonly IMapper mapper;
        public VehiclesContorller(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpPost]
        public void Create([FromBody] string vehicleDto)
        {
         //   var vehicle = mapper.Map<VehicleDto,Vehicle>(vehicleDto);            

           // return Ok(vehicle);
         //   return Ok("vehicleDto");
        }

        [HttpGet]
        public int Get()
        {
            return 1;
        }

    }
}