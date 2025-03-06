namespace ScarletAnime.Services.Title;

public interface ITitleService
{
    Task<List<Models.Title>> GetTitles();
}