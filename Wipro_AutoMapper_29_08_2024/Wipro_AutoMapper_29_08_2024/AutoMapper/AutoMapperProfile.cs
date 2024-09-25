using AutoMapper;
using Wipro_AutoMapper_29_08_2024.DTO;
using Wipro_AutoMapper_29_08_2024.Models;

namespace Wipro_AutoMapper_29_08_2024.AutoMapper
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CreateCountryDTO, Country>().ForMember(dest=>dest.CountryName,opt=>opt.MapFrom(src=>src.CountryName));
           // CreateMap<UpdateCountryDTO , Country>();
        }
    }
}
