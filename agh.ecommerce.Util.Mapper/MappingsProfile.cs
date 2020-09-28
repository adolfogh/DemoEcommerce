using agh.ecommerce.Application.DTO;
using agh.ecommerce.Domain.Entity;
using AutoMapper;
using System;

namespace agh.ecommerce.Util.Mapper
{
    public class MappingsProfile : Profile
    {

        public MappingsProfile()
        {
            CreateMap<Customers, CustomersDTO>().ReverseMap();

            //CreateMap<Customers, CustomersDTO>().ReverseMap()
            //    .ForMember(d => d.CustomerId, s => s.MapFrom(src => src.CustomerId))
            //    .ForMember(d => d.CompanyName, s => s.MapFrom(src => src.CompanyName))
            //    .ForMember(d => d.ContactName, s => s.MapFrom(src => src.ContactName))
            //    .ForMember(d => d.Address, s => s.MapFrom(src => src.Address))
            //    .ForMember(d => d.City, s => s.MapFrom(src => src.City))
            //    .ForMember(d => d.Region, s => s.MapFrom(src => src.Region))
            //    .ForMember(d => d.PostalCode, s => s.MapFrom(src => src.PostalCode))
            //    .ForMember(d => d.Country, s => s.MapFrom(src => src.Country))
            //    .ForMember(d => d.Phone, s => s.MapFrom(src => src.Phone))
            //    .ForMember(d => d.Fax, s => s.MapFrom(src => src.Fax));

        }

    }
}
