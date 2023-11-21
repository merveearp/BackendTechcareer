using AutoMapper;
using Day_6_efcore.Dtos.Responses;
using Day_6_efcore.Dtos.Reuqests;
using Day_6_efcore.Models;

namespace Day_6_efcore.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreatePlayerRequestDto, Player>();
        CreateMap<UpdatePlayerRequestDto, Player>();
        CreateMap<Player,PlayerResponseDto>();
        CreateMap<Branch , BranchDto>();
        CreateMap<Outfit , OutfitDto>();
        CreateMap<Team , TeamDto>();

    }
}
