using Day_6_efcore.Dtos.Responses;
using Day_6_efcore.Dtos.Reuqests;
using Day_6_efcore.ReturnsModel;


namespace Day_6_efcore.Services.Abstract;

public interface IPlayerService
{

    ReturnModel<List<PlayerResponseDto>> GetList();
    ReturnModel<PlayerResponseDto> Add(CreatePlayerRequestDto requestDto);
    ReturnModel<PlayerResponseDto> Update(UpdatePlayerRequestDto requestDto);
    ReturnModel<PlayerResponseDto> Delete(int id);
    ReturnModel<PlayerResponseDto> GetById(int id);

}
