using System.Runtime.CompilerServices;

namespace ef_di_rp_WebAPI.Services.SuperHeroService
{
    public class SuperHeroService : ISuperHeroService
    {
        private static List<SuperHero> superHeroes = new List<SuperHero>
        {
            new SuperHero
            {
                Id = 1,
                Name = "Invincible",
                FirstName = "Mark",
                LastName = "Nolan",
                Place = "New York City"
            },

            new SuperHero
            {
                Id =2,
                Name = "The Butcher",
                FirstName = "William",
                LastName = "Butcher",
                Place = "London"
            }

        };

        public List<SuperHero> AddHero(SuperHero hero)
        {
            superHeroes.Add(hero);
            return superHeroes;
        }


        public List<SuperHero> GetAllHeroes()
        {
            return superHeroes;
        }

        public SuperHero? GetSingleHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }
            return hero;
        }

        public List<SuperHero>? UpdateHero(SuperHero request, int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }
            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;

            return superHeroes;
        }
        public List<SuperHero>? DeleteHero(int id)
        {
            var hero = superHeroes.Find(x => x.Id == id);
            if (hero == null)
            {
                return null;
            }

            superHeroes.Remove(hero);
            return superHeroes;
        }
    }
}
