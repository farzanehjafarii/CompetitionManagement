using CompetitionManagement.Models;
using Microsoft.AspNetCore.Mvc;
using CompetitionManagement.DTO;

namespace CompetitionManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompetitionController : ControllerBase
    {

        private readonly ILogger<CompetitionController> _logger;

        public CompetitionController(ILogger<CompetitionController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetCompetitions")]
        [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 60)]
        public RestDTO<Competition[]> Get()
        {
            return new RestDTO<Competition[]>()
            {
                Data = new[]
                {
                    new Competition() {
                        Id = 1,
                        Name = "FootBall",
                        midScore = 0,
                        playDate = new DateTime(),
                        scoringCoach = new List<User>()
                        {
                            new User { Id = 1 },
                            new User { Id = 2 },
                        },
                    },
                    new Competition() {
                        Id = 1,
                        Name = "VollyBall",
                        midScore = 10,
                        playDate = new DateTime(),
                        scoringCoach = new List<User>()
                        {
                            new User { Id = 5 },
                            new User { Id = 2 },
                            new User { Id = 1 },

                        },
                    }, new Competition() {
                        Id = 1,
                        Name = "FootBall",
                        midScore = 5,
                        playDate = new DateTime(),
                        scoringCoach = new List<User>()
                        {
                            new User { Id = 6 },
                            new User { Id = 2 },
                        },
                    }, new Competition() {
                        Id = 1,
                        Name = "WaterPolo",
                        midScore = 12,
                        playDate = new DateTime(),
                        scoringCoach = new List<User>()
                        {
                            new User { Id = 1 },
                        },
                    },


                },
                Links = new List<LinkDTO> {
                        new LinkDTO(
                Url.Action(null, "Competition", null, Request.Scheme)!,
                "self",
                "GET"),
                    }
            };
        }


    }
}