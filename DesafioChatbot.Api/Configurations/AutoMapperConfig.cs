using AutoMapper;
using DesafioChatbot.Api.DTOs;
using DesafioChatbot.Api.Models;

namespace DesafioChatbot.Api.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<GitHubRepositorio, GitHubRepositorioDTO>().ReverseMap();
        }
    }
}
