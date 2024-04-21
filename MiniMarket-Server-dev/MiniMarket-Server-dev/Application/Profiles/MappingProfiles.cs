﻿using AutoMapper;
using MiniMarket_Server_dev.Application.DTOs;
using MiniMarket_Server_dev.Application.DTOs.Requests;
using MiniMarket_Server_dev.Model.Entities;

namespace MiniMarket_Server_dev.Application.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<ProductDto, Product>().ReverseMap();                          //Should be replaced with viewmodels down the line.
            CreateMap<CategoryDto, ProductCategory>().ReverseMap();
            CreateMap<OrderDetailsDto, OrderDetails>().ReverseMap();
            CreateMap<SaleOrderDto, SaleOrder>().ReverseMap();
            CreateMap<SaleOrderDetailsDto, SaleOrder>().ReverseMap();
            CreateMap<CompanyCodeDto, CompanyCode>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<UserDto, Seller>().ReverseMap();
            CreateMap<UserDto, SuperAdmin>().ReverseMap();
            CreateMap<SellerDto, User>().ReverseMap();                              //


            CreateMap<AddCategoryDto, ProductCategory>().ReverseMap();
            CreateMap<AddProductDto, Product>().ReverseMap();
            CreateMap<AddCompanyCodeDto, CompanyCode>().ReverseMap();
            CreateMap<UpdateCategoryDto, ProductCategory>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();

            CreateMap<CreateSellerDto, Seller>().ReverseMap();
            CreateMap<CreateUserDto, Customer>().ReverseMap();
            CreateMap<CreateUserDto, SuperAdmin>().ReverseMap();

            CreateMap<CreateOrderDto, SaleOrder>()
                .ForSourceMember(c => c.NewDetails, opt => opt.DoNotValidate());                    //Prevents mapping the incomplete details from the DTO

            CreateMap<CreateDetailDto, OrderDetails>().ReverseMap();


        }

    }
}
