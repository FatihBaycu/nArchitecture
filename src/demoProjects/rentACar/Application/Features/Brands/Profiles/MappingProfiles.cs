using Application.Features.Brands.Command.CreateBrand;
using Application.Features.Brands.Dtos;
using Application.Features.Brands.Models;
using Application.Features.someFeature.Dtos;
using AutoMapper;
using Core.Persistence.Paging;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.someFeature.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Brand, CreatedBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandCommand>().ReverseMap();
            CreateMap<Brand, BrandListDto>().ReverseMap();
            CreateMap<IPaginate<Brand>, BrandListModel>().ReverseMap();
            CreateMap<Brand,BrandGetByIdDto>().ReverseMap();


            }
        }
    }

 