namespace NewBlazorServerPJ.Data
{
    public interface IGameServices
    {
        List<GameModel> GetGameList();

        GameModel GetGameById(int id);

        void SaveGame(GameModel project);

        void DeleteGame(int id);
    }
}
