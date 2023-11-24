using ef_di_rp_WebAPI.Services.SuperHeroService;
using Microsoft.AspNetCore.Mvc;

namespace ef_di_rp_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return _superHeroService.GetAllHeroes();
        }

        [HttpGet("id")]
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var result = _superHeroService.GetSingleHero(id);
            if (result == null)
            {
                return NotFound("Sorry, the hero don't exists on our registrations");
            }
            return Ok(result);
        }

        [HttpPost]

        public async Task<ActionResult<Task<SuperHero>>> AddHero(SuperHero hero)
        {
            var result = _superHeroService.AddHero(hero);
            if (result == null)
            {
                return NotFound("Sorry, the hero don't exists on our registrations");
            }
            return Ok(result);
        }


        [HttpPut("id")]
        public async Task<ActionResult<Task<SuperHero>>> UpdateHero(int id, SuperHero request)
        {
            var result = _superHeroService.UpdateHero(request, id);
            if (result == null)
            {
                return NotFound("Sorry, the hero don't exists on our registrations");
            }
            return Ok(result);
        }


        [HttpDelete("id")]
        public async Task<ActionResult<Task<SuperHero>>> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);
            if (result == null)
            {
                return NotFound("Sorry, the hero don't exists on our registrations");
            }
            return Ok(result);
        }


    }
}
