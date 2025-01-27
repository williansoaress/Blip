using DesafioChatbot.Api.Models;

namespace DesafioChatbot.Api.Interfaces
{
    public interface IGitHubRepositorioService
    {
        Task<IEnumerable<GitHubRepositorio>> ObterTop5RepositoriosAntigosDeCSharp();
    }
}
