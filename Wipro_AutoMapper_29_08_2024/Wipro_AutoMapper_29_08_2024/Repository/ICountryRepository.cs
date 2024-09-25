using Wipro_AutoMapper_29_08_2024.Models;

namespace Wipro_AutoMapper_29_08_2024.Repository
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetCountries();
        Country SearchCountry(int id);
        int UpdateCountry(Country country);
        int CreateCountry(Country country);
        int DeleteCountry(Country country);


    }
}
