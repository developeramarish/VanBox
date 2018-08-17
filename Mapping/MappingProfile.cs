using System.Linq;
using AutoMapper;
using VanBox.DTOs;
using VanBox.Models;

namespace VanBox.Mapping
{
    public class MappingProfile : Profile 
    {
        public MappingProfile()
        {
            //Domain to API
            CreateMap<Make,MakeDto>();
            CreateMap<Model,MdlDto>();
            CreateMap<Vehicle,VehicleDto>();
            
            //API to Domain 
            CreateMap<VehicleDto,Vehicle>()
            .ForMember(v => v.ContactName, opt=>opt.MapFrom(vr =>vr.Contact.Name))
            .ForMember(v => v.ContactEmail, opt=>opt.MapFrom(vr =>vr.Contact.Email))
            .ForMember(v => v.ContactPhone, opt=>opt.MapFrom(vr =>vr.Contact.Phone))
            .ForMember(v => v.Features, opt=>opt.MapFrom(vr =>vr.Features.Select(id => new FeatureVehicle{ FeatureId = id})))            
            ;
        }
        
    }
}