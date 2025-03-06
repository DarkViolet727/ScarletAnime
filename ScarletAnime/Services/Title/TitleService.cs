namespace ScarletAnime.Services.Title;

using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class TitleService : ITitleService
{
    private readonly HttpClient _httpClient;

    public TitleService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Models.Title>> GetTitles()
    {
        return await _httpClient.GetFromJsonAsync<List<Models.Title>>("titles");
    }
}
