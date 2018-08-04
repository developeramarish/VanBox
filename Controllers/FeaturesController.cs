using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VanBox.DTOs;
using VanBox.Models;
using VanBox.Persistence;

namespace VanBox.Controllers
{    
    public class VehiclesController : Controller
    {
        private readonly VanBoxDbContext context;
        private readonly IMapper mapper;
        public VehiclesController(VanBoxDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        // https://localhost:5001/api/vehicles/5
        [HttpGet("/api/vehicles/{id}")]
        public async Task<IEnumerable<VehicleDto>> GetVehicles(int id)
        {
            var Vehicles = await context.Vehicles.Where(m => m.ModelId == id).ToListAsync(); 

            return mapper.Map<List<Vehicle>,List<VehicleDto>>(Vehicles);
        }

       // [HttpGet("/api/vehicles/model-feature")]
      //  public async Task<IEnumerable<>>



    }
}