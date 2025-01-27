using DesafioChatbot.Api.Interfaces;
using DesafioChatbot.Api.Models;

namespace DesafioChatbot.Api.Services
{
    public class GitHubRepositorioService : IGitHubRepositorioService
    {
        private readonly HttpClient _httpClient;

        public GitHubRepositorioService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.DefaultRequestHeaders.UserAgent.ParseAdd("Blip");
            _httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "");
        }

        public async Task<IEnumerable<GitHubRepositorio>> ObterTop5RepositoriosAntigosDeCSharp()
        {
            var url = "https://api.github.com/orgs/takenet/repos?sort=created&direction=asc";
            var response = await _httpClient.GetFromJsonAsync<List<GitHubRepositorio>>(url);

            var repositorios = response?
                .Where(repo => repo.Linguagem?.Equals("C#", StringComparison.OrdinalIgnoreCase) == true)
                .OrderBy(repo => repo.CriadoEm)
                .Take(5)
                .ToList();

            return repositorios;
        }
    }
}
