using ef_di_rp_WebAPI.Models;

namespace ef_di_rp_WebAPI.Services.SuperHeroService
{
    public interface ISuperHeroService
    {
        List<SuperHero> GetAllHeroes();
        SuperHero? GetSingleHero(int id);
        List<SuperHero> AddHero(SuperHero hero);
        List<SuperHero>? UpdateHero(SuperHero request, int id);
        List<SuperHero>? DeleteHero(int id);
    }
}
