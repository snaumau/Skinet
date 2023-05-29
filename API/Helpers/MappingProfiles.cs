﻿using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(dest => dest.ProductBrand, opt => opt.MapFrom(source => source.ProductBrand!.Name))
                .ForMember(dest => dest.ProductType, opt => opt.MapFrom(source => source.ProductType!.Name));
        }
    }
}
