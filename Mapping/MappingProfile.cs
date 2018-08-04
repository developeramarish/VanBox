using AutoMapper;
using VanBox.DTOs;
using VanBox.Models;

namespace VanBox.Mapping
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeDto>();
            CreateMap<Model,MdlDto>();
            CreateMap<Vehicle,VehicleDto>();
            
        }
        
    }
}