using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    internal class Planet
    {
        private static int _planetId;
        public string Name;
        public double Area;

        public Planet(string name, double area)
        {
            ++_planetId;
            PlanetId = _planetId;
            Name = name;
            Area = area;
        }

        public int PlanetId { get; }
    }
}
