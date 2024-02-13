using BlazorWebAssemblyCRUD.Shared.Entities;
using BlazorWebAssemblyCRUD.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorWebAssemblyCRUD.Contrrolers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GamesController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpGet]
        public async Task<IActionResult> GetGames()
        {
            var result = await _gameService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddGame(Game game)
        {
            await _gameService.CreateGame(game);
            return Ok();
        }
    }
}
