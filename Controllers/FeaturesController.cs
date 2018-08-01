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
    public class FeaturesController : Controller
    {
        private readonly VanBoxDbContext context;
        private readonly IMapper mapper;
        public FeaturesController(VanBoxDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        // https://localhost:5001/api/features/5
        [HttpGet("/api/features/{id}")]
        public async Task<IEnumerable<FeatureDto>> GetFeatures(int id)
        {
            var features = await context.Features.Where(m => m.ModelId == id).ToListAsync(); 

            return mapper.Map<List<Feature>,List<FeatureDto>>(features);
        }

    }
}