using Microsoft.EntityFrameworkCore;
using Wipro_AutoMapper_29_08_2024.EntityFrameWork;
using Wipro_AutoMapper_29_08_2024.Models;


namespace Wipro_AutoMapper_29_08_2024.Repository
{
    public class CountryRepository : ICountryRepository
    {
        private readonly WiproDfa29082024Context wiproDfa29082024Context;
        public CountryRepository(WiproDfa29082024Context _wiproDfa29082024Context)
        {
            wiproDfa29082024Context = _wiproDfa29082024Context;

        }
        public int CreateCountry(Country country)
        {
            wiproDfa29082024Context.Country.Add(country);
            return wiproDfa29082024Context.SaveChanges();
        }

        public int DeleteCountry(Country country)
        {
            wiproDfa29082024Context.Country.Remove(country);
            return wiproDfa29082024Context.SaveChanges();
        }

        public IEnumerable<Country> GetCountries()
        {
            return wiproDfa29082024Context.Country.ToList();
        }

        public Country SearchCountry(int id)
        {
            return wiproDfa29082024Context.Country.Where(t=>t.CountryId==id).FirstOrDefault();
        }

        public int UpdateCountry(Country country)
        {
            wiproDfa29082024Context.Country.Update(country);
            return wiproDfa29082024Context.SaveChanges();
        }
    }
}
