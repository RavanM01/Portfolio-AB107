using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    internal static class AppDbContext
    {

        static List<Country> Countries = new List<Country>();
        static List<Planet> Planets = new List<Planet>();

        public static void CreateCountry(Country country)
        { 
            Countries.Add(country);
            Console.WriteLine(country);
        }
        public static  void UpdateCountry(int id)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                if (id == Countries[i].CountryId)
                {

                }
            }
        }
        public static  void RemoveCountry(int id)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                if (id== Countries[i].CountryId)
                {
                Countries.Remove(Countries[i]);

                }
            }
        }
        public static  void GetAllCountries()
        {
            for(int i = 0;i < Countries.Count; i++)
            {
                Countries[i].ToString();
            }
        }

        public static List<Country> GetCountryByRegion(Region region)
        {
            return Countries.FindAll(x => x.Region == region);
        }
        

        public static void CreatePlanet(Planet planet)
        {
            Planets.Add(planet);
            Console.WriteLine(planet);

        }
        public static void RemovePlanet(int id)
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                if (id == Planets[i].PlanetId)
                {
                    Planets.Remove(Planets[i]);

                }
            }

        }
        public static void GetAllPlanets()
        {
            for(int i = 0; i < Planets.Count; i++)
            {
                Console.WriteLine($"ID:{Planets[i].PlanetId}\nName:{Planets[i].Name}\nArea:{Planets[i].Area}");
            }
        }

    }
}
