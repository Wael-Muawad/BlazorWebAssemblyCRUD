using BlazorWebAssemblyCRUD.Shared.Entities;

namespace BlazorWebAssemblyCRUD.Shared.Services
{
    public interface IGameService
    {

        public Task CreateGame(Game game);

        //public Task<ApiResponseDto<TReadDto>> Update(TUpdateDto updateDto);

        //public Task<ApiResponseDto<bool>> Delete(int id);

        //public Task<ApiResponseDto<TReadDto>> GetByID(int id);
        //public Task<ApiResponseDto<TReadDto>> GetByName(string name);
        public Task<List<Game>> GetAll();
    }
}
