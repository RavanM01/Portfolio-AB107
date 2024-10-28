using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galaxy
{
    internal class Country
    {
        private static int _countryId;
        public string CountryName;
        public double Area;
        public string Anthem;
        public Region Region;
        public int CountryId { get; }

        public Country(string countryName, double area, string anthem,Region region)
        {
            ++_countryId;
            CountryId = _countryId;            
            CountryName = countryName;
            Area = area;
            Anthem = anthem;
            Region=region;
        }

    }
}
