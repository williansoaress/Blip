using System.Text.Json.Serialization;

namespace DesafioChatbot.Api.Models
{
    public class GitHubRepositorio
    {
        [JsonPropertyName("full_name")]
        public string? Nome { get; set; }
        [JsonPropertyName("description")]
        public string? Descricao { get; set; }
        [JsonPropertyName("language")]
        public string? Linguagem { get; set; }
        [JsonPropertyName("created_at")]
        public DateTime? CriadoEm { get; set; }
    }
}
