namespace NewBlazorServerPJ.Data
{
    public class GameServices : IGameServices
    {
        private readonly ApplicationDbContext _dbcontext;
        public GameServices(ApplicationDbContext context)
        {
            _dbcontext = context;
        }

        public void DeleteGame(int id)
        {
            var game = _dbcontext.Games.FirstOrDefault(x => x.Id == id);
            if (game != null)
            {
                _dbcontext.Games.Remove(game);
                _dbcontext.SaveChanges();
            }
        }

        public GameModel GetGameById(int id)
        {
            var game = _dbcontext.Games.SingleOrDefault(x => x.Id == id);
            return game;

        }

        public List<GameModel> GetGameList()
        {
            return _dbcontext.Games.ToList();
        }

        public void SaveGame(GameModel game)
        {
            if (game.Id == 0) _dbcontext.Games.Add(game);
            else _dbcontext.Games.Update(game);
            _dbcontext.SaveChanges();
        }
    }
}
