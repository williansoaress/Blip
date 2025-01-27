using AutoMapper;
using DesafioChatbot.Api.DTOs;
using DesafioChatbot.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DesafioChatbot.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepositoriosController : ControllerBase
    {
        private readonly IGitHubRepositorioService _gitHubRepositorioService;
        private readonly IMapper _mapper;

        public RepositoriosController(IGitHubRepositorioService gitHubRepositorioService, IMapper mapper)
        {
            _gitHubRepositorioService = gitHubRepositorioService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<GitHubRepositorioDTO>> ObterTop5RepositoriosAntigosDeCSharp()
        {
            var repositoriosBlip = await _gitHubRepositorioService.ObterTop5RepositoriosAntigosDeCSharp();

            var repositoriosBlipDTO = _mapper.Map<IEnumerable<GitHubRepositorioDTO>>(repositoriosBlip);
            
            return repositoriosBlipDTO;
        }
    }
}
