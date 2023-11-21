using AutoMapper;
using Day_6_efcore.Dtos.Responses;
using Day_6_efcore.Dtos.Reuqests;
using Day_6_efcore.Exceptions;
using Day_6_efcore.Models;
using Day_6_efcore.Repositories.Abstract;
using Day_6_efcore.ReturnsModel;
using Day_6_efcore.Services.Abstract;

namespace Day_6_efcore.Services.Concrete;

public class PlayerService : IPlayerService
{
    private readonly IPlayerRepository _playerRepository;
    private readonly IMapper _mapper;

    public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
    {
        _playerRepository = playerRepository;
        _mapper = mapper;
    }

    public ReturnModel<PlayerResponseDto> Add(CreatePlayerRequestDto requestDto)
    {
        Player player =_mapper.Map<Player>(requestDto);
        _playerRepository.Add(player);
        
        PlayerResponseDto response = _mapper.Map<PlayerResponseDto>(player);
        ReturnModel<PlayerResponseDto> result = new ReturnModel<PlayerResponseDto>()
        {
            Data = response,
            Message = "Oyuncu başarıyla eklendi.",
            StatusCode = System.Net.HttpStatusCode.Created
        };
        return result;
    }

    public ReturnModel<PlayerResponseDto> Delete(int id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<PlayerResponseDto> GetById(int id)
    {
        try
        {
            var player = _playerRepository.GetById(id);
            PlayerResponseDto response = _mapper.Map<PlayerResponseDto>(player);
            return new ReturnModel<PlayerResponseDto>()
            {
                Data = response,
                Message = "Id ye ait oyuncu getirildi",
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }
        catch (NotFoundException ex)
        {
            return new ReturnModel<PlayerResponseDto>()
            {
                Message = ex.Message,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };
        }
    }

    public ReturnModel<List<PlayerResponseDto>> GetList()
    {
        throw new NotImplementedException();
    }

    public ReturnModel<PlayerResponseDto> Update(UpdatePlayerRequestDto requestDto)
    {
        throw new NotImplementedException();
    }
}
