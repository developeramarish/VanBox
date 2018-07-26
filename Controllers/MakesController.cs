using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VanBox.DTOs;
using VanBox.Models;
using VanBox.Persistence;

namespace VanBox.Controllers
{
    public class MakesController : Controller
    {
        private readonly VanBoxDbContext context;
        private readonly IMapper mapper;

        public MakesController(VanBoxDbContext context, IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeDto>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return mapper.Map<List<Make>,List<MakeDto>>(makes);

        }

    }
}