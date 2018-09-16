using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using VanBox.API.Contracts;
using VanBox.API.DTOs;
using VanBox.API.Helpers;
using VanBox.API.Models;

namespace VanBox.API.Controllers
{
    [Authorize]
    [Route("api/users/{userId}/photos")]
    [ApiController]
    public class PhotosController : ControllerBase
    {
        private IMatchRepository _repository { get; }
        private IMapper _mapper { get; }
        private IOptions<CloudinarySettings> _cloudinaryConfig { get; }
        public Cloudinary _cloudinary { get; }

        public PhotosController(
            IMatchRepository repository,
            IMapper mapper,
            IOptions<CloudinarySettings> cloudinaryConfig
         )
        {
            _repository = repository;
            _mapper = mapper;
            _cloudinaryConfig = cloudinaryConfig;

            Account account = new Account(
                _cloudinaryConfig.Value.CloudName ,
                _cloudinaryConfig.Value.ApiKey,
                _cloudinaryConfig.Value.ApiSecret
            ); 

            _cloudinary = new Cloudinary(account);
        }

        [HttpGet("{id}", Name="GetPhoto")]
        public async Task<IActionResult> GetPhoto(int id)
        {
            var photoFromRepo = await _repository.GetPhoto(id);

            var photo = _mapper.Map<PhotoForReturnDTO>(photoFromRepo);

            return Ok(photo);
        }

        [HttpPost]
        public async Task<IActionResult> AddPhotoForUser(int userId, [FromForm] PhotoForCreatorDto photoForCreatorDto)
        {
            if(userId != int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value))
            return Unauthorized();

            var userRepo = await _repository.GetUser(userId); 

           var file = photoForCreatorDto.File;

           var uploadResult = new ImageUploadResult();

           if(file.Length > 0)
           {
               using(var stream = file.OpenReadStream())
               {
                   var uploadParms = new ImageUploadParams(){
                       File = new FileDescription(file.Name,stream),
                       Transformation = new Transformation()
                       .Width(500).Height(500).Crop("fill").Gravity("face")
                   };

                   uploadResult = _cloudinary.Upload(uploadParms);
               }
           }

           photoForCreatorDto.Url = uploadResult.Uri.ToString();
           photoForCreatorDto.PublicId = uploadResult.PublicId;

           var photo = _mapper.Map<Photo>(photoForCreatorDto);

           if(!userRepo.Photos.Any(u => u.IsMain))
            photo.IsMain = true;  

            userRepo.Photos.Add(photo);

            if(await _repository.SaveAll())
            {
                var photoToReturn = _mapper.Map<PhotoForReturnDTO>(photo);

                return CreatedAtRoute("GetPhoto", new { id = photo.Id},photoToReturn);
            }

            return BadRequest("Photo adding failed !");
        }


    }
}