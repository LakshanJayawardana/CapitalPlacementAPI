using AutoMapper;
using CapitalPlacementAPI.Models.Dtos;
using CapitalPlacementAPI.Models.Entities;

namespace CapitalPlacementAPI.Mapping;
public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<ApplicationForm, ApplicationFormDto>().ReverseMap();
    }
}