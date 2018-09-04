using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using VanBox.API.Contracts;
using VanBox.API.DTOs;

namespace VanBox.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IMatchRepository repo;
        private readonly IMapper mapper;
        public UsersController(IMatchRepository repo, IMapper mapper)
        {
            this.mapper = mapper;
            this.repo = repo;

        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await repo.GetAllUser();
            var usersDto = mapper.Map<IEnumerable<UserForListDTO>>(users);
            return Ok(usersDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> getUser(int id)
        {
            var user = await repo.GetUser(id);
            var userDto = mapper.Map<UserForDetailsDTO>(user);
            return Ok(userDto);
        }

    }
}