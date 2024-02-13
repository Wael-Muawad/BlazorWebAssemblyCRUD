using BlazorWebAssemblyCRUD.Shared.Data;
using BlazorWebAssemblyCRUD.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssemblyCRUD.Shared.Services
{
    public class GameService : IGameService
    {
        private readonly AppDataContext _context;

        public GameService(AppDataContext context)
        {
            _context = context;
        }

        public async Task CreateGame(Game game)
        {
            _context.Games.Add(game);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Game>> GetAll()
        {
            return await _context.Games.ToListAsync();
        }
    }
}
