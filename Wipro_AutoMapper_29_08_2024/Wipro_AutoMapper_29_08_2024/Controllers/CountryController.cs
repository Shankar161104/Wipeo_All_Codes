using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_AutoMapper_29_08_2024.DTO;
using Wipro_AutoMapper_29_08_2024.Models;
using Wipro_AutoMapper_29_08_2024.Repository;

namespace Wipro_AutoMapper_29_08_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository countryRepository;
        private readonly IMapper mapper;
        public CountryController(ICountryRepository _countryRepository, IMapper _mapper)
        {
            countryRepository = _countryRepository;
            mapper = _mapper;
        }

        [HttpPost("CreateCountry")]

        public ActionResult CreateCountry(CreateCountryDTO countryDTO)
        {
            return Ok(countryRepository.CreateCountry(mapper.Map<Country>(countryDTO)));
        }

        [HttpPut("UpdateCountry")]

        public ActionResult UpdateCountry(Country country)
        {
            return Ok(countryRepository.UpdateCountry(country));
        }

        [HttpPut("DeleteCountry")]

        public ActionResult DeleteCountry(Country country)
        {
            return Ok(countryRepository.DeleteCountry(country));
        }
        [HttpPost("ListOfCountries")]

        public ActionResult GetCountries()
        {
            return Ok(countryRepository.GetCountries());
        }

        [HttpGet("SearchCountry")]

        public ActionResult SearchCountry(int id)
        {
            return Ok(countryRepository.SearchCountry(id));
        }



    }
}
